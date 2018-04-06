using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: log4net.Config.XmlConfigurator(Watch = true, ConfigFile="log4net.config")]
namespace Vueling.Common.Logic
{
    public sealed class Logger : ITargetAdapterForLogger
    {
        private log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Logger));
        private bool isInfoEnabled = true;
        private bool isWarnEnabled = true;
        private bool isDebugEnabled = true;
        private bool isErrorEnabled = true;
        private bool isFatalEnabled = true;

        public TimeSpan ExecutionTime { get; set; }
        public int counter { get; set; }

        public void Debug(string message)
        {
            Log.Debug("#"+message);
        }

        public void Debug(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void EmailException(string msg)
        {
            throw new NotImplementedException();
        }

        public void Error(string message)
        {
            Log.Error(message);
        }

        public void Error(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Exception(Exception exception, string message)
        {
            throw new NotImplementedException();
        }

        public void Exception(Exception exception, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(string message)
        {
            throw new NotImplementedException();
        }

        public void Warn(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
    }
}
