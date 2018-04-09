using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[assembly: log4net.Config.XmlConfigurator(Watch = true, ConfigFile="log4net.config")]
namespace Vueling.Common.Logic
{
    public sealed class Logger : ILogger
    {
        private readonly log4net.ILog Log;
        private readonly bool isInfoEnabled = true;
        private readonly bool isWarnEnabled = true;
        private readonly bool isDebugEnabled = true;
        private readonly bool isErrorEnabled = true;
        private readonly bool isFatalEnabled = true;

        public TimeSpan ExecutionTime { get; set; }
        public int counter { get; set; }

        public Logger(Type tipo)
        {
            Log = log4net.LogManager.GetLogger(tipo);
        }


        public void Debug(string message)
        {
            if(isDebugEnabled) Log.Debug(message);
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
            if(isErrorEnabled) Log.Error(message);
        }

        public void Error(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Exception(Exception exception, string message)
        {
            Log.Error(message, exception);
        }

        public void Exception(Exception exception)
        {
            Log.Error(exception);
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
