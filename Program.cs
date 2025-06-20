using LineFinder.Logging;
using LineFinder.Types;
using LineFinder.Utils;
using LineFinder.UI;
using LineFinder.Search;
using System.Reflection;

internal class Program
{
    private static void Main()
    {
        Log log = new();

        UserRequestData requestData = new();
        FileLineInfo[] promptResult;

        LogDirectoryCreator.CreateLogDirectoryIfNotExist();

        log.InitializeLogFile();

        LogWriter.Message(log, LogInformationType.Start); // Start log

        while (true)
        {
            requestData.Parse();

            if (requestData.IsValidInput)
            {
                promptResult = MatchingFilesSearch.Find(requestData.LineText, DirectorySearch.GetFilesInDirectory(requestData.Path), log: log); // match find

                if (promptResult.Length != 0) 
                {
                    ResultDisplayer.MatchDisplay(promptResult);

                    PromptResultLogger.LogMatchInfo(requestData, log, promptResult);
                }
                else
                {
                    ResultDisplayer.NoMatchDisplay();

                    PromptResultLogger.LogMatchInfo(requestData, log); // no match log
                }

                ConsolePauseDisplayer.WaitForKeyPress(); // press for continue...
            }
        }
    }
}