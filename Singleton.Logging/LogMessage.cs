using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Logging
{
    internal class LogMessage
    {
        public string Message { get; set; } = string.Empty;
        public LogType Type { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"[{Type}] [{CreatedAt:yyyy-MM-dd HH:mm:ss}] {Message}";
        }
    }
}
