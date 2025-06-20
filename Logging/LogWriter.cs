namespace LineFinder.Logging
{
    static internal class LogWriter
    {
        static internal void Message (Log log, LogInformationType type, string text ="")
        {
            string message = $"[{type} {DateTime.Now}] {text} ";
            File.AppendAllLines(log.LogPath, [message]);
        }
    }
}