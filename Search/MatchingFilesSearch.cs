using LineFinder.Logging;
using LineFinder.Types;

namespace LineFinder.Search
{
    internal static class MatchingFilesSearch
    {

        public static FileLineInfo[] Find(string lineText, string[] files, Log log)
        {    
            List<FileLineInfo> result = new List<FileLineInfo>();

            foreach (string file in files)
            {
                try
                {
                    FileLineSearch.FindAndAddLineInfo(file ,lineText, result);
                }
                catch (Exception exception)
                {
                    LogWriter.Message(log, LogInformationType.Warning, exception.Message);
                }
            }

            return result.ToArray();
        }
    }
}
