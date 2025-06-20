using LineFinder.Logging;

namespace LineFinder.Search
{
    internal static class DirectorySearch
    {
        public static string[] GetFilesInDirectory(string filePath)
        {
            try
            {
                return Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
            }

            catch (Exception ex)
            {
                if(ex is UnauthorizedAccessException)
                {
                    Console.WriteLine($"\n[Access to the directory is denied.]");
                }
                else if (ex is DirectoryNotFoundException)
                {
                    Console.WriteLine($"\n[Directory not found.]");
                }
                else if (ex is PathTooLongException)
                {
                    Console.WriteLine($"\n[Path to the directory is too long.]");
                }

                return Array.Empty<string>();
            }
        }
    }
}

