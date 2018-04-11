using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;

namespace Vueling.Common.Logic
{
    public class CustomSmtpAppender : log4net.Appender.SmtpAppender
    {
        protected override void SendEmail(string messageBody)
        {
            base.SendEmail(messageBody);
        }
    }
}
