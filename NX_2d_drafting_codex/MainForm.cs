using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using NX_2d_drafting_codex.Helpers;
using NX_2d_drafting_codex.NXOpen;

namespace NX_2d_drafting_codex
{
    public partial class MainForm : Form
    {
        private List<string> foundPartFiles = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            Text = "NX Auto Drawing Generator";

            comboBox_drawing_set_paper_size.SelectedItem = "A4";
            comboBox_drawing_set_projection.SelectedItem = "Third Angle";

            checkBox_Save_Drawing.Checked = true;
            checkBox_Options_Export_PDF.Checked = true;
            checkBox_Options_Hidden_Line_rem.Checked = true;

            ViewSection_front.Checked = true;
            ViewSection_top.Checked = true;
            ViewSection_right.Checked = true;
            ViewSection_isometric.Checked = true;

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            Input_Browser_button.Click += Input_Browser_button_Click;
            Output_Browser_button.Click += Output_Browser_button_Click;
            button_generate.Click += button_generate_Click;
            button_cancel.Click += button_cancel_Click;
            button_about.Click += button_about_Click;
        }

        private void Input_Browser_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select folder containing NX part (.prt) files";
                dialog.ShowNewFolderButton = false;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    Input_textBox.Text = dialog.SelectedPath;
                    RescanInputFolder();
                }
            }
        }

        private void RescanInputFolder()
        {
            foundPartFiles = FileHelper.FindPartFiles(Input_textBox.Text, includeSubfolders: false);
            Input_Label.Text = "Files found : " + foundPartFiles.Count;
        }

        private void Output_Browser_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select PDF output folder";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    Output_textBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            // Folder contents may have changed since the last browse/scan.
            RescanInputFolder();

            if (foundPartFiles.Count == 0)
            {
                MessageBox.Show(this, "No .prt files were found in the selected input folder.",
                    "Nothing To Process", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetBusyState(true);
            ResetProgress();

            int generatedCount = 0;
            int skippedAssemblyCount = 0;
            int failedCount = 0;

            DrawingGenerator generator = new DrawingGenerator();

            for (int i = 0; i < foundPartFiles.Count; i++)
            {
                string partFilePath = foundPartFiles[i];

                label_progress_current_file.Text = "Current file: " + Path.GetFileName(partFilePath);
                AppendStatus("------------------------------------");
                AppendStatus("File " + (i + 1) + " of " + foundPartFiles.Count + ": " + Path.GetFileName(partFilePath));

                try
                {
                    DrawingGenerationRequest request = new DrawingGenerationRequest
                    {
                        PartFilePath = partFilePath,
                        OutputFolderPath = Output_textBox.Text,
                        SaveDrawing = checkBox_Save_Drawing.Checked,
                        ExportPdf = checkBox_Options_Export_PDF.Checked,
                        ReportProgress = AppendStatus
                    };

                    PartProcessResult result = generator.GenerateDrawing(request);

                    switch (result)
                    {
                        case PartProcessResult.SkippedAssembly:
                            skippedAssemblyCount++;
                            AppendStatus("Skipped (assembly, not a part).");
                            break;
                        case PartProcessResult.DrawingGenerated:
                            generatedCount++;
                            AppendStatus("Drawing generated.");
                            break;
                        default:
                            failedCount++;
                            AppendStatus("Failed.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    failedCount++;
                    AppendStatus("Failed: " + ex.Message);
                }

                UpdateOverallProgress(i + 1, foundPartFiles.Count);
            }

            AppendStatus("------------------------------------");
            AppendStatus(string.Format(
                "Done. {0} drawing(s) generated, {1} assembly file(s) skipped, {2} failed.",
                generatedCount, skippedAssemblyCount, failedCount));

            SetBusyState(false);

            MessageBox.Show(this,
                string.Format(
                    "Processing complete.\n\nDrawings generated: {0}\nAssemblies skipped: {1}\nFailed: {2}",
                    generatedCount, skippedAssemblyCount, failedCount),
                "Completed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "NX Auto Drawing Generator V1\n\n" +
                "Scans a selected input folder for NX .prt files. Assembly files are skipped " +
                "automatically; piece-part files each get a 2D drawing and optional PDF export.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(Input_textBox.Text) || !Directory.Exists(Input_textBox.Text))
            {
                MessageBox.Show(this, "Please select a valid input folder.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(Output_textBox.Text) || !Directory.Exists(Output_textBox.Text))
            {
                MessageBox.Show(this, "Please select a valid output folder.", "Output Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ResetProgress()
        {
            progressBar.Value = 0;
            current_file_richTextBox.Clear();
            label_progress_current_file.Text = "Current file: -";
        }

        private void UpdateOverallProgress(int filesProcessed, int totalFiles)
        {
            if (totalFiles <= 0)
            {
                return;
            }

            int percent = (int)Math.Round(filesProcessed * 100.0 / totalFiles);
            progressBar.Value = Math.Max(0, Math.Min(100, percent));
        }

        private void AppendStatus(string message)
        {
            current_file_richTextBox.AppendText(message + Environment.NewLine);
            current_file_richTextBox.SelectionStart = current_file_richTextBox.TextLength;
            current_file_richTextBox.ScrollToCaret();
            current_file_richTextBox.Refresh();

            Application.DoEvents();
        }

        private void SetBusyState(bool isBusy)
        {
            Cursor = isBusy ? Cursors.WaitCursor : Cursors.Default;
            button_generate.Enabled = !isBusy;
            Input_Browser_button.Enabled = !isBusy;
            Output_Browser_button.Enabled = !isBusy;
        }
    }
}
