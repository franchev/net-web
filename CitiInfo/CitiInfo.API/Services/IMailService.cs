﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiInfo.API.Services
{
    interface IMailService
    {
        void Send(string subject, string message);
    }
}
