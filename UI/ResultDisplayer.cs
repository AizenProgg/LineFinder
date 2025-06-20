using LineFinder.Types;

namespace LineFinder.UI
{
    internal static class ResultDisplayer
    {
        public static void MatchDisplay(FileLineInfo[] fileLineInfos)
        {
            foreach (var resultItem in fileLineInfos)
            {
                Console.WriteLine($"\n[PATH]: {resultItem.filePath}\n[LINE]: {resultItem.lineIndex}\n[TEXT]: {resultItem.line}");
            }
        }

        public static void NoMatchDisplay()
        {
            Console.WriteLine("\nNo matches.");
        }
    }
}
