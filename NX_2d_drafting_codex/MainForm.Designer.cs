namespace NX_2d_drafting_codex
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Input_Folder = new System.Windows.Forms.GroupBox();
            this.Input_Browser_button = new System.Windows.Forms.Button();
            this.Input_Label = new System.Windows.Forms.Label();
            this.Input_textBox = new System.Windows.Forms.TextBox();
            this.groupBox_Output_Folder = new System.Windows.Forms.GroupBox();
            this.Output_textBox = new System.Windows.Forms.TextBox();
            this.Output_Browser_button = new System.Windows.Forms.Button();
            this.groupBox_Drawing_Setting = new System.Windows.Forms.GroupBox();
            this.groupBox_viewSection = new System.Windows.Forms.GroupBox();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.groupBox_Progress = new System.Windows.Forms.GroupBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.Drawing_setting_psize_label = new System.Windows.Forms.Label();
            this.comboBox_drawing_set_paper_size = new System.Windows.Forms.ComboBox();
            this.comboBox_drawing_set_projection = new System.Windows.Forms.ComboBox();
            this.Drawing_setting_projection_label = new System.Windows.Forms.Label();
            this.checkBox_Save_Drawing = new System.Windows.Forms.CheckBox();
            this.ViewSection_front = new System.Windows.Forms.CheckBox();
            this.ViewSection_top = new System.Windows.Forms.CheckBox();
            this.ViewSection_right = new System.Windows.Forms.CheckBox();
            this.ViewSection_isometric = new System.Windows.Forms.CheckBox();
            this.checkBox_Options_Export_PDF = new System.Windows.Forms.CheckBox();
            this.checkBox_Options_Overwrite = new System.Windows.Forms.CheckBox();
            this.checkBox_Options_Hidden_Line_rem = new System.Windows.Forms.CheckBox();
            this.checkBox_Export_BOM = new System.Windows.Forms.CheckBox();
            this.checkBox_Open_PDF = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_progress_current_file = new System.Windows.Forms.Label();
            this.current_file_richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox_Input_Folder.SuspendLayout();
            this.groupBox_Output_Folder.SuspendLayout();
            this.groupBox_Drawing_Setting.SuspendLayout();
            this.groupBox_viewSection.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.groupBox_Progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Input_Folder
            // 
            this.groupBox_Input_Folder.Controls.Add(this.Input_Browser_button);
            this.groupBox_Input_Folder.Controls.Add(this.Input_Label);
            this.groupBox_Input_Folder.Controls.Add(this.Input_textBox);
            this.groupBox_Input_Folder.Location = new System.Drawing.Point(12, 23);
            this.groupBox_Input_Folder.Name = "groupBox_Input_Folder";
            this.groupBox_Input_Folder.Size = new System.Drawing.Size(624, 77);
            this.groupBox_Input_Folder.TabIndex = 0;
            this.groupBox_Input_Folder.TabStop = false;
            this.groupBox_Input_Folder.Text = "Input Folder";
            // 
            // Input_Browser_button
            // 
            this.Input_Browser_button.Location = new System.Drawing.Point(523, 24);
            this.Input_Browser_button.Name = "Input_Browser_button";
            this.Input_Browser_button.Size = new System.Drawing.Size(88, 28);
            this.Input_Browser_button.TabIndex = 2;
            this.Input_Browser_button.Text = "Browse...";
            this.Input_Browser_button.UseVisualStyleBackColor = true;
            // 
            // Input_Label
            // 
            this.Input_Label.AutoSize = true;
            this.Input_Label.Location = new System.Drawing.Point(6, 53);
            this.Input_Label.Name = "Input_Label";
            this.Input_Label.Size = new System.Drawing.Size(86, 16);
            this.Input_Label.TabIndex = 1;
            this.Input_Label.Text = "File Found : 0";
            // 
            // Input_textBox
            // 
            this.Input_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.Input_textBox.Location = new System.Drawing.Point(6, 27);
            this.Input_textBox.Name = "Input_textBox";
            this.Input_textBox.Size = new System.Drawing.Size(480, 22);
            this.Input_textBox.TabIndex = 0;
            // 
            // groupBox_Output_Folder
            // 
            this.groupBox_Output_Folder.Controls.Add(this.Output_Browser_button);
            this.groupBox_Output_Folder.Controls.Add(this.Output_textBox);
            this.groupBox_Output_Folder.Location = new System.Drawing.Point(12, 104);
            this.groupBox_Output_Folder.Name = "groupBox_Output_Folder";
            this.groupBox_Output_Folder.Size = new System.Drawing.Size(624, 60);
            this.groupBox_Output_Folder.TabIndex = 0;
            this.groupBox_Output_Folder.TabStop = false;
            this.groupBox_Output_Folder.Text = "Output Folder";
            // 
            // Output_textBox
            // 
            this.Output_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.Output_textBox.Location = new System.Drawing.Point(9, 21);
            this.Output_textBox.Name = "Output_textBox";
            this.Output_textBox.Size = new System.Drawing.Size(480, 22);
            this.Output_textBox.TabIndex = 3;
            // 
            // Output_Browser_button
            // 
            this.Output_Browser_button.Location = new System.Drawing.Point(523, 15);
            this.Output_Browser_button.Name = "Output_Browser_button";
            this.Output_Browser_button.Size = new System.Drawing.Size(88, 28);
            this.Output_Browser_button.TabIndex = 3;
            this.Output_Browser_button.Text = "Browse...";
            this.Output_Browser_button.UseVisualStyleBackColor = true;
            // 
            // groupBox_Drawing_Setting
            // 
            this.groupBox_Drawing_Setting.Controls.Add(this.comboBox_drawing_set_projection);
            this.groupBox_Drawing_Setting.Controls.Add(this.Drawing_setting_projection_label);
            this.groupBox_Drawing_Setting.Controls.Add(this.comboBox_drawing_set_paper_size);
            this.groupBox_Drawing_Setting.Controls.Add(this.Drawing_setting_psize_label);
            this.groupBox_Drawing_Setting.Location = new System.Drawing.Point(12, 170);
            this.groupBox_Drawing_Setting.Name = "groupBox_Drawing_Setting";
            this.groupBox_Drawing_Setting.Size = new System.Drawing.Size(624, 60);
            this.groupBox_Drawing_Setting.TabIndex = 1;
            this.groupBox_Drawing_Setting.TabStop = false;
            this.groupBox_Drawing_Setting.Text = "Drawing Setting";
            // 
            // groupBox_viewSection
            // 
            this.groupBox_viewSection.Controls.Add(this.ViewSection_isometric);
            this.groupBox_viewSection.Controls.Add(this.ViewSection_right);
            this.groupBox_viewSection.Controls.Add(this.ViewSection_top);
            this.groupBox_viewSection.Controls.Add(this.ViewSection_front);
            this.groupBox_viewSection.Location = new System.Drawing.Point(12, 236);
            this.groupBox_viewSection.Name = "groupBox_viewSection";
            this.groupBox_viewSection.Size = new System.Drawing.Size(624, 60);
            this.groupBox_viewSection.TabIndex = 2;
            this.groupBox_viewSection.TabStop = false;
            this.groupBox_viewSection.Text = "View Selection";
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.checkBox_Open_PDF);
            this.groupBox_options.Controls.Add(this.checkBox_Export_BOM);
            this.groupBox_options.Controls.Add(this.checkBox_Options_Hidden_Line_rem);
            this.groupBox_options.Controls.Add(this.checkBox_Options_Overwrite);
            this.groupBox_options.Controls.Add(this.checkBox_Options_Export_PDF);
            this.groupBox_options.Controls.Add(this.checkBox_Save_Drawing);
            this.groupBox_options.Location = new System.Drawing.Point(12, 302);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(624, 76);
            this.groupBox_options.TabIndex = 3;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // groupBox_Progress
            // 
            this.groupBox_Progress.Controls.Add(this.current_file_richTextBox);
            this.groupBox_Progress.Controls.Add(this.label_progress_current_file);
            this.groupBox_Progress.Controls.Add(this.progressBar);
            this.groupBox_Progress.Location = new System.Drawing.Point(12, 384);
            this.groupBox_Progress.Name = "groupBox_Progress";
            this.groupBox_Progress.Size = new System.Drawing.Size(624, 151);
            this.groupBox_Progress.TabIndex = 4;
            this.groupBox_Progress.TabStop = false;
            this.groupBox_Progress.Text = "Progress";
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(19, 541);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(111, 26);
            this.button_generate.TabIndex = 5;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(149, 541);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(111, 26);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(525, 541);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(111, 26);
            this.button_about.TabIndex = 7;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            // 
            // Drawing_setting_psize_label
            // 
            this.Drawing_setting_psize_label.AutoSize = true;
            this.Drawing_setting_psize_label.Location = new System.Drawing.Point(6, 27);
            this.Drawing_setting_psize_label.Name = "Drawing_setting_psize_label";
            this.Drawing_setting_psize_label.Size = new System.Drawing.Size(82, 16);
            this.Drawing_setting_psize_label.TabIndex = 0;
            this.Drawing_setting_psize_label.Text = "Paper Size : ";
            // 
            // comboBox_drawing_set_paper_size
            // 
            this.comboBox_drawing_set_paper_size.FormattingEnabled = true;
            this.comboBox_drawing_set_paper_size.Items.AddRange(new object[] {
            "A4",
            "A3",
            "A2",
            "A1"});
            this.comboBox_drawing_set_paper_size.Location = new System.Drawing.Point(91, 24);
            this.comboBox_drawing_set_paper_size.Name = "comboBox_drawing_set_paper_size";
            this.comboBox_drawing_set_paper_size.Size = new System.Drawing.Size(151, 24);
            this.comboBox_drawing_set_paper_size.TabIndex = 1;
            // 
            // comboBox_drawing_set_projection
            // 
            this.comboBox_drawing_set_projection.FormattingEnabled = true;
            this.comboBox_drawing_set_projection.Items.AddRange(new object[] {
            "First Angle",
            "Third Angle"});
            this.comboBox_drawing_set_projection.Location = new System.Drawing.Point(460, 24);
            this.comboBox_drawing_set_projection.Name = "comboBox_drawing_set_projection";
            this.comboBox_drawing_set_projection.Size = new System.Drawing.Size(151, 24);
            this.comboBox_drawing_set_projection.TabIndex = 3;
            // 
            // Drawing_setting_projection_label
            // 
            this.Drawing_setting_projection_label.AutoSize = true;
            this.Drawing_setting_projection_label.Location = new System.Drawing.Point(378, 27);
            this.Drawing_setting_projection_label.Name = "Drawing_setting_projection_label";
            this.Drawing_setting_projection_label.Size = new System.Drawing.Size(76, 16);
            this.Drawing_setting_projection_label.TabIndex = 2;
            this.Drawing_setting_projection_label.Text = "Projection : ";
            // 
            // checkBox_Save_Drawing
            // 
            this.checkBox_Save_Drawing.AutoSize = true;
            this.checkBox_Save_Drawing.Checked = true;
            this.checkBox_Save_Drawing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Save_Drawing.Location = new System.Drawing.Point(9, 22);
            this.checkBox_Save_Drawing.Name = "checkBox_Save_Drawing";
            this.checkBox_Save_Drawing.Size = new System.Drawing.Size(113, 20);
            this.checkBox_Save_Drawing.TabIndex = 0;
            this.checkBox_Save_Drawing.Text = "Save Drawing";
            this.checkBox_Save_Drawing.UseVisualStyleBackColor = true;
            // 
            // ViewSection_front
            // 
            this.ViewSection_front.AutoSize = true;
            this.ViewSection_front.Checked = true;
            this.ViewSection_front.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewSection_front.Location = new System.Drawing.Point(9, 26);
            this.ViewSection_front.Name = "ViewSection_front";
            this.ViewSection_front.Size = new System.Drawing.Size(59, 20);
            this.ViewSection_front.TabIndex = 1;
            this.ViewSection_front.Text = "Front";
            this.ViewSection_front.UseVisualStyleBackColor = true;
            // 
            // ViewSection_top
            // 
            this.ViewSection_top.AutoSize = true;
            this.ViewSection_top.Checked = true;
            this.ViewSection_top.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewSection_top.Location = new System.Drawing.Point(167, 26);
            this.ViewSection_top.Name = "ViewSection_top";
            this.ViewSection_top.Size = new System.Drawing.Size(54, 20);
            this.ViewSection_top.TabIndex = 2;
            this.ViewSection_top.Text = "Top";
            this.ViewSection_top.UseVisualStyleBackColor = true;
            // 
            // ViewSection_right
            // 
            this.ViewSection_right.AutoSize = true;
            this.ViewSection_right.Checked = true;
            this.ViewSection_right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewSection_right.Location = new System.Drawing.Point(317, 26);
            this.ViewSection_right.Name = "ViewSection_right";
            this.ViewSection_right.Size = new System.Drawing.Size(60, 20);
            this.ViewSection_right.TabIndex = 3;
            this.ViewSection_right.Text = "Right";
            this.ViewSection_right.UseVisualStyleBackColor = true;
            // 
            // ViewSection_isometric
            // 
            this.ViewSection_isometric.AutoSize = true;
            this.ViewSection_isometric.Checked = true;
            this.ViewSection_isometric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewSection_isometric.Location = new System.Drawing.Point(460, 26);
            this.ViewSection_isometric.Name = "ViewSection_isometric";
            this.ViewSection_isometric.Size = new System.Drawing.Size(83, 20);
            this.ViewSection_isometric.TabIndex = 4;
            this.ViewSection_isometric.Text = "Isometric";
            this.ViewSection_isometric.UseVisualStyleBackColor = true;
            // 
            // checkBox_Options_Export_PDF
            // 
            this.checkBox_Options_Export_PDF.AutoSize = true;
            this.checkBox_Options_Export_PDF.Checked = true;
            this.checkBox_Options_Export_PDF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Options_Export_PDF.Location = new System.Drawing.Point(153, 22);
            this.checkBox_Options_Export_PDF.Name = "checkBox_Options_Export_PDF";
            this.checkBox_Options_Export_PDF.Size = new System.Drawing.Size(97, 20);
            this.checkBox_Options_Export_PDF.TabIndex = 1;
            this.checkBox_Options_Export_PDF.Text = "Export PDF";
            this.checkBox_Options_Export_PDF.UseVisualStyleBackColor = true;
            // 
            // checkBox_Options_Overwrite
            // 
            this.checkBox_Options_Overwrite.AutoSize = true;
            this.checkBox_Options_Overwrite.Location = new System.Drawing.Point(317, 22);
            this.checkBox_Options_Overwrite.Name = "checkBox_Options_Overwrite";
            this.checkBox_Options_Overwrite.Size = new System.Drawing.Size(85, 20);
            this.checkBox_Options_Overwrite.TabIndex = 2;
            this.checkBox_Options_Overwrite.Text = "Overwrite";
            this.checkBox_Options_Overwrite.UseVisualStyleBackColor = true;
            // 
            // checkBox_Options_Hidden_Line_rem
            // 
            this.checkBox_Options_Hidden_Line_rem.AutoSize = true;
            this.checkBox_Options_Hidden_Line_rem.Checked = true;
            this.checkBox_Options_Hidden_Line_rem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Options_Hidden_Line_rem.Location = new System.Drawing.Point(460, 21);
            this.checkBox_Options_Hidden_Line_rem.Name = "checkBox_Options_Hidden_Line_rem";
            this.checkBox_Options_Hidden_Line_rem.Size = new System.Drawing.Size(164, 20);
            this.checkBox_Options_Hidden_Line_rem.TabIndex = 3;
            this.checkBox_Options_Hidden_Line_rem.Text = "Hidden Line Removed";
            this.checkBox_Options_Hidden_Line_rem.UseVisualStyleBackColor = true;
            // 
            // checkBox_Export_BOM
            // 
            this.checkBox_Export_BOM.AutoSize = true;
            this.checkBox_Export_BOM.Location = new System.Drawing.Point(9, 50);
            this.checkBox_Export_BOM.Name = "checkBox_Export_BOM";
            this.checkBox_Export_BOM.Size = new System.Drawing.Size(100, 20);
            this.checkBox_Export_BOM.TabIndex = 4;
            this.checkBox_Export_BOM.Text = "Export BOM";
            this.checkBox_Export_BOM.UseVisualStyleBackColor = true;
            // 
            // checkBox_Open_PDF
            // 
            this.checkBox_Open_PDF.AutoSize = true;
            this.checkBox_Open_PDF.Location = new System.Drawing.Point(153, 50);
            this.checkBox_Open_PDF.Name = "checkBox_Open_PDF";
            this.checkBox_Open_PDF.Size = new System.Drawing.Size(92, 20);
            this.checkBox_Open_PDF.TabIndex = 5;
            this.checkBox_Open_PDF.Text = "Open PDF";
            this.checkBox_Open_PDF.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(7, 22);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(604, 23);
            this.progressBar.TabIndex = 0;
            // 
            // label_progress_current_file
            // 
            this.label_progress_current_file.AutoSize = true;
            this.label_progress_current_file.Location = new System.Drawing.Point(4, 57);
            this.label_progress_current_file.Name = "label_progress_current_file";
            this.label_progress_current_file.Size = new System.Drawing.Size(79, 16);
            this.label_progress_current_file.TabIndex = 1;
            this.label_progress_current_file.Text = "Current file: -";
            // 
            // current_file_richTextBox
            // 
            this.current_file_richTextBox.Location = new System.Drawing.Point(6, 77);
            this.current_file_richTextBox.Name = "current_file_richTextBox";
            this.current_file_richTextBox.Size = new System.Drawing.Size(605, 74);
            this.current_file_richTextBox.TabIndex = 2;
            this.current_file_richTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 580);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.groupBox_Progress);
            this.Controls.Add(this.groupBox_options);
            this.Controls.Add(this.groupBox_viewSection);
            this.Controls.Add(this.groupBox_Drawing_Setting);
            this.Controls.Add(this.groupBox_Output_Folder);
            this.Controls.Add(this.groupBox_Input_Folder);
            this.Name = "MainForm";
            this.Text = "NX Auto Drawing Generator";
            this.groupBox_Input_Folder.ResumeLayout(false);
            this.groupBox_Input_Folder.PerformLayout();
            this.groupBox_Output_Folder.ResumeLayout(false);
            this.groupBox_Output_Folder.PerformLayout();
            this.groupBox_Drawing_Setting.ResumeLayout(false);
            this.groupBox_Drawing_Setting.PerformLayout();
            this.groupBox_viewSection.ResumeLayout(false);
            this.groupBox_viewSection.PerformLayout();
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.groupBox_Progress.ResumeLayout(false);
            this.groupBox_Progress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Input_Folder;
        private System.Windows.Forms.GroupBox groupBox_Output_Folder;
        private System.Windows.Forms.Label Input_Label;
        private System.Windows.Forms.TextBox Input_textBox;
        private System.Windows.Forms.Button Input_Browser_button;
        private System.Windows.Forms.Button Output_Browser_button;
        private System.Windows.Forms.TextBox Output_textBox;
        private System.Windows.Forms.GroupBox groupBox_Drawing_Setting;
        private System.Windows.Forms.GroupBox groupBox_viewSection;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.GroupBox groupBox_Progress;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.ComboBox comboBox_drawing_set_paper_size;
        private System.Windows.Forms.Label Drawing_setting_psize_label;
        private System.Windows.Forms.ComboBox comboBox_drawing_set_projection;
        private System.Windows.Forms.Label Drawing_setting_projection_label;
        private System.Windows.Forms.CheckBox ViewSection_isometric;
        private System.Windows.Forms.CheckBox ViewSection_right;
        private System.Windows.Forms.CheckBox ViewSection_top;
        private System.Windows.Forms.CheckBox ViewSection_front;
        private System.Windows.Forms.CheckBox checkBox_Save_Drawing;
        private System.Windows.Forms.CheckBox checkBox_Open_PDF;
        private System.Windows.Forms.CheckBox checkBox_Export_BOM;
        private System.Windows.Forms.CheckBox checkBox_Options_Hidden_Line_rem;
        private System.Windows.Forms.CheckBox checkBox_Options_Overwrite;
        private System.Windows.Forms.CheckBox checkBox_Options_Export_PDF;
        private System.Windows.Forms.Label label_progress_current_file;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox current_file_richTextBox;
    }
}
