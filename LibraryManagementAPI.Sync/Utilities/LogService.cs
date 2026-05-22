namespace LibraryManagementAPI.Utilities
{
    public class LogService : ILogService
    {
        private readonly ILogger<LogService> _logger;

        public LogService(ILogger<LogService> logger)
        {
            _logger = logger;
        }

        public void SaveLog(string message)
        {
            _logger.LogError(message);
        }
    }

}
