using LineFinder.Logging;
using LineFinder.Types;
using LineFinder.Utils;
using LineFinder.UI;
using LineFinder.Search;

internal class Program
{
    private static void Main()
    {
        LogDirectoryCreator.CreateLogDirectoryIfNotExist();

        Log log = new();
        LogWriter.Message(log, LogInformationType.start); // start log

        while (true)
        {
            UserRequestData requestData = new();
            requestData.Parse();

            if (requestData.IsValidInput)
            {
                FileLineInfo[] result = MatchingFilesSearch.Find(requestData.LineText, DirectorySearch.GetFilesInDirectory(requestData.Path), log: log); // match find

                if(result.Length != 0) 
                {
                    ResultDisplayer.MatchDisplay(result);

                    PromptResultLogger.MatchLog(requestData, log, result); // match log
                }
                else
                {
                    ResultDisplayer.NoMatchDisplay();

                    PromptResultLogger.NoMatchLog(requestData, log); // no match log
                }

                ConsolePauseDisplayer.WaitForKeyPress(); // press for continue...
            }
        }
    }
}