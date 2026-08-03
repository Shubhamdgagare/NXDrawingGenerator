using System;

namespace NX_2d_drafting_codex.NXOpen
{
    internal sealed class DrawingGenerationRequest
    {
        public string PartFilePath { get; set; }

        public string OutputFolderPath { get; set; }

        public bool SaveDrawing { get; set; }

        public bool ExportPdf { get; set; }

        public Action<string> ReportProgress { get; set; }
    }
}
