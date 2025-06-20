using LineFinder.Types;

namespace LineFinder.Search
{
    internal static class FileLineSearch
    {
        public static void FindAndAddLineInfo(string file, string lineText, List<FileLineInfo> result)
        {
            string extension = Path.GetExtension(file);

            if (extension != ".luau" && extension != ".txt") { return; }

            List<string>  lines = File.ReadAllLines(file).ToList();
            int index = lines.FindIndex(line => line.Contains(lineText, StringComparison.OrdinalIgnoreCase));

            if (index >= 0)
            {
                result.Add(new FileLineInfo
                {
                    filePath = Path.GetFullPath(file),
                    line = lines[index],
                    lineIndex = ++index
                });
            }
            
        }
    }
}
