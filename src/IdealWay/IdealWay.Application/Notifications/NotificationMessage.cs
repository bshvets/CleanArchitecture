﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWay.Application.Notifications
{
    public class NotificationMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
