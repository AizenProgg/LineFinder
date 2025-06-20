using LineFinder.Types;

namespace LineFinder.Logging
{
    internal static class PromptResultLogger
    {
        public static void LogMatchInfo(UserRequestData userRequestData, Log log, FileLineInfo[]? fileLineInfos = null)
        {
            if (fileLineInfos == null || fileLineInfos.Length == 0)
            {
                LogWriter.Message(log, LogInformationType.Info,
                    $"[Request: {userRequestData.Path} | {userRequestData.LineText}] No matches");
            }
            else
            {
                foreach (var lineInfo in fileLineInfos)
                {
                    LogWriter.Message(log, LogInformationType.Info,
                        $"[Request: {userRequestData.Path} | {userRequestData.LineText}] file: {lineInfo.filePath} | line: {lineInfo.lineIndex} | line text: {lineInfo.line}");
                }
            }
        }
    }
}
