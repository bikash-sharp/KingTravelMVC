using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class CountryRequest
    {
        public string TokenId { get; set; }
        public string ClientId { get; set; }
        public string EndUserIp { get; set; }
    }
}