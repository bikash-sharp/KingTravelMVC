using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class AuthenticateResponse
    {
        public int Status { get; set; }
        public string TokenId { get; set; }
        public Error Error { get; set; }
        public Member Member { get; set; }

        public AuthenticateResponse()
        {
            Error = new Error();
            Member = new Member();
        }
    }
}