namespace NX_2d_drafting_codex.NXOpen
{
    internal sealed class PdfExporter
    {
        public void Export(
            global::NXOpen.Part workPart,
            global::NXOpen.Drawings.DraftingDrawingSheet sheet,
            string pdfPath)
        {
            global::NXOpen.PrintPDFBuilder printPdfBuilder = workPart.PlotManager.CreatePrintPdfbuilder();

            try
            {
                printPdfBuilder.Scale = 1.0;
                printPdfBuilder.Size = global::NXOpen.PrintPDFBuilder.SizeOption.ScaleFactor;
                printPdfBuilder.Units = global::NXOpen.PrintPDFBuilder.UnitsOption.English;
                printPdfBuilder.XDimension = 8.5;
                printPdfBuilder.YDimension = 11.0;
                printPdfBuilder.OutputText = global::NXOpen.PrintPDFBuilder.OutputTextOption.Polylines;
                printPdfBuilder.RasterImages = true;
                printPdfBuilder.Watermark = string.Empty;

                global::NXOpen.NXObject[] sheets = new global::NXOpen.NXObject[1];
                sheets[0] = sheet;
                printPdfBuilder.SourceBuilder.SetSheets(sheets);
                printPdfBuilder.Filename = pdfPath;

                printPdfBuilder.Commit();
            }
            finally
            {
                printPdfBuilder.Destroy();
            }
        }
    }
}
