using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClinic_View.Logging
{
    internal class LoggingMethod
    {
        public static void EventLogger(string message, EventLogEntryType logType)
        {
            string sourceName = "Clinic_App";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }

            // Log an information event
            EventLog.WriteEntry(sourceName, message, logType);

        }
    
    
    }


}
