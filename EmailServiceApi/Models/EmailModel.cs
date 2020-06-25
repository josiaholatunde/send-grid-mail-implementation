﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmailServiceApi.Models
{
    public class EmailModel
    {
        public string To { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
