using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace XDS_Subscriber
{
    public class SubscriptionLog
    {
        private string logPath;
        private string logFilename = "SubscriberLog";
        private Timer logTimer;
        private DateTime currentDate = DateTime.Now;

        public SubscriptionLog(string logPath)
        {
            logTimer = new Timer();
            logTimer.Interval = 3600000;
            logTimer.Start();
            logTimer.Elapsed += new ElapsedEventHandler(logTimer_Elapsed);
            this.logPath = logPath;
        }

        private void logTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(DateTime.Now.Date > currentDate.Date)
            {
                currentDate = DateTime.Now;
            }
        }

        public void WriteLog(string logText)
        {
            using(StreamWriter sw = new StreamWriter(logPath + @"\" + logFilename + "_" + currentDate.Date.ToString("ddMMyyyy") + ".txt",true))
            {
                sw.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff") + ": " + logText);
            }
        }
    }
}
