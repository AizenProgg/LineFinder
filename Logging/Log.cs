namespace LineFinder.Logging
{
	internal class Log
	{
		private readonly DateTime _sessionStarted;
		private readonly string _logPath;
		private List<string> _sessionLogs = new();
		
		public string LogPath { get { return _logPath; } }
		public DateTime SessionStarted { get { return _sessionStarted; } }

		public Log()
		{
			_sessionStarted = DateTime.Now;

			_logPath = Path.Combine(
				Directory.GetCurrentDirectory() + 
				"/logs" + 
				$"/log{_sessionStarted.Year}-" +
				$"{_sessionStarted.Day}-" +
				$"{_sessionStarted.Hour}-" +
				$"{_sessionStarted.Minute}.txt");

			File.Create(_logPath).Close();
		}
	}
}
