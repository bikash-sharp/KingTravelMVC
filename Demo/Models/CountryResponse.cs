using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class CountryResponse
    {
        public string CountryList { get; set; }
        public Error Error { get; set; }
        public int Status { get; set; }
        public string TokenId { get; set; }

        public CountryResponse()
        {
            Error = new Error();
        }
    }
}