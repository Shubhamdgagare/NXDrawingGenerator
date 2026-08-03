namespace NX_2d_drafting_codex.NXOpen
{
    /// <summary>
    /// Outcome of attempting to process a single .prt file found in the
    /// selected input folder.
    /// </summary>
    internal enum PartProcessResult
    {
        /// <summary>A 2D drawing (and optionally a PDF) was generated successfully.</summary>
        DrawingGenerated,

        /// <summary>The file is an assembly (has a root component), so it was skipped.</summary>
        SkippedAssembly,

        /// <summary>The file could not be opened or processed as an NX part.</summary>
        Failed
    }
}
