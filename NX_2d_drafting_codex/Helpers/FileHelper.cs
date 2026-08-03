using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NX_2d_drafting_codex.Helpers
{
    internal static class FileHelper
    {
        public static bool IsNxPartFile(string filePath)
        {
            return !string.IsNullOrWhiteSpace(filePath)
                && File.Exists(filePath)
                && string.Equals(Path.GetExtension(filePath), ".prt", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Finds all .prt files directly inside the given folder.
        /// Whether each one turns out to be an assembly or a piece part
        /// can only be determined once it is opened in NX, so this just
        /// gathers candidate files by extension.
        /// </summary>
        public static List<string> FindPartFiles(string folderPath, bool includeSubfolders)
        {
            if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath))
            {
                return new List<string>();
            }

            SearchOption searchOption = includeSubfolders
                ? SearchOption.AllDirectories
                : SearchOption.TopDirectoryOnly;

            return Directory.EnumerateFiles(folderPath, "*.prt", searchOption)
                .OrderBy(path => path, StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

        public static string BuildOutputPath(string outputFolder, string sourcePartFile, string extension)
        {
            string baseName = Path.GetFileNameWithoutExtension(sourcePartFile);
            return Path.Combine(outputFolder, baseName + extension);
        }
    }
}
