using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace TaskRunner.Util
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public class Logger
    {
        private static readonly log4net.ILog m_log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Logger()
        {

        }

        public static void Log(string message)
        {
            m_log.Info(message);
        }

        public static void Log(string message, Exception ex)
        {
            m_log.Info(message, ex);
        }

    }
}
