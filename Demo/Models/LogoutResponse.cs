using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class LogoutResponse
    {
        public Error Error { get; set; }
        public int Status { get; set; }

        public LogoutResponse()
        {
            Error = new Error();
        }
    }
}