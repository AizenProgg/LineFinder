using LineFinder.Logging;
using LineFinder.Types;

namespace LineFinder.Utils
{
    internal static class LogDirectoryCreator
    {
        public static void CreateLogDirectoryIfNotExist()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "/logs"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/logs");
            }
        }
    }
}
