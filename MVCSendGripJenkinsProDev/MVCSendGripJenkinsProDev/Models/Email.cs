using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSendGripJenkinsProDev.Models
{
    public class Email
    {
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string DeliveryType { get; set; }
    }
}