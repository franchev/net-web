using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CitiInfo.API.Services
{
    public class CloudMailService: IMailService
    {
        private string _mailTo = Startup.configuration["mailSettings.mailToAddress"];
        private string _mailFrom = Startup.configuration["mailSettings.mailFromAddress"];

        public void Send(string subject, string message)
        {
            // send mail - output to debug window
            Debug.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with CloudMailService.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
