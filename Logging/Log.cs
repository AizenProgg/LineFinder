namespace LineFinder.Logging
{
	internal class Log
	{
		private DateTime _sessionStarted;
		private string _logPath;
		private List<string> _sessionLogs = new();
		
		public string LogPath { get { return _logPath; } }
		public DateTime SessionStarted { get { return _sessionStarted; } }

		public Log()
		{
            _sessionStarted = DateTime.Now;

            _logPath = Path.Combine(Directory.GetCurrentDirectory(), "logs", $"log{_sessionStarted:yyyy-MM-dd-HH-mm}.txt");
        }

		public void InitializeLogFile()
		{
            File.Create(_logPath).Close();
        }
	}
}
