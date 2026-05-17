using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Logging
{
    internal class MemoryLogger
    {
        private int _infoCount;
        private int _warningCount;
        private int _errorCount;

        #region Singleton Implementation
        //private static readonly MemoryLogger _instance = new MemoryLogger(); Eager Loading

        //private static readonly Lazy<MemoryLogger> _instance = new Lazy<MemoryLogger>(() => new MemoryLogger()); // Lazy Loading 


        private static MemoryLogger _instance = null;

        private static readonly Lock _lock = new();
        #endregion


        private List<LogMessage> _logs = [];

        public IReadOnlyCollection<LogMessage> Logs => _logs.AsReadOnly();


        private MemoryLogger()
        {

        }

        public static MemoryLogger GetLogger
        {
            get
            {
                if (_instance == null) 
                { 
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                         return _instance = new MemoryLogger();
                        }

                    }
                }
                return _instance; 
            }

            
        }

        private void Log(string message, LogType logType)
        {
            _logs.Add(new LogMessage
            {
                Message = message,
                Type = logType,
                CreatedAt = DateTime.Now
            });
        }
        public void LogInfo(string message)
        {
            ++_infoCount;
            Log(message,LogType.INFO);
        }
        public void LogWarning(string message)
        {
            ++_warningCount;
            Log(message,LogType.WARNING);
        }
        public void LogError(string message)
        {
            ++_errorCount;
            Log(message,LogType.ERROR);
        }

        internal void ShowLog()
        {
            _logs.ForEach(log => Console.WriteLine(log));
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($" INFO: {_infoCount}, Warning: {_warningCount}, Errors: {_errorCount}");
        }
    }
}
