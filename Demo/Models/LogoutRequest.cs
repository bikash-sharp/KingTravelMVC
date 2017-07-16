using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class LogoutRequest
    {
        public string ClientId { get; set; }
        public string EndUserIp { get; set; }
        public int TokenAgencyId { get; set; }
        public int TokenMemberId { get; set; }
        public string TokenId { get; set; }
    }
}