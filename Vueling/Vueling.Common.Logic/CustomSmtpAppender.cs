using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;

namespace Vueling.Common.Logic
{
    public class CustomSmtpAppender : log4net.Appender.BufferingAppenderSkeleton
    {
        protected override void SendBuffer(LoggingEvent[] events)
        {
            throw new NotImplementedException();
        }
    }
}
