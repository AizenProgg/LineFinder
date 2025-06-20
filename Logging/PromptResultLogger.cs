using LineFinder.Types;

namespace LineFinder.Logging
{
    internal static class PromptResultLogger
    {
        public static void NoMatchLog(UserRequestData userRequestData, Log log)
        {
            LogWriter.Message(log, LogInformationType.Info, $"[Request: {userRequestData.Path} | {userRequestData.LineText}] No matches");
        }

        public static void MatchLog(UserRequestData userRequestData, Log log, FileLineInfo[] fileLineInfos)
        {
            foreach(var lineInfo in fileLineInfos)
            {
                LogWriter.Message(log, LogInformationType.Info, $"[Request: {userRequestData.Path} | {userRequestData.LineText}] file: {lineInfo.filePath} | line: {lineInfo.lineIndex} | line text: {lineInfo.line}");
            }
        }
    }
}
