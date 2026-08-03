using System;
using System.Windows.Forms;

namespace NX_2d_drafting_codex
{
    public static class NXJournal
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Program.Run();
        }

        public static int GetUnloadOption(string dummy)
        {
            return (int)global::NXOpen.Session.LibraryUnloadOption.Immediately;
        }
    }

    internal static class Program
    {
        [STAThread]
        public static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
