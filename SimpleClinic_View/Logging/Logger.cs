using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Logging
{
    public class Logger
    {
        public delegate void LogAction(string message, EventLogEntryType logType = EventLogEntryType.Error);

        LogAction _logAction;
        public Logger(LogAction logAction)
        {
            _logAction = logAction;
        }

        public void Log(string message, EventLogEntryType logType = EventLogEntryType.Error)
        {
            _logAction(message, logType);
        }
    }
}
