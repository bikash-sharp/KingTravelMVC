using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int MemberId { get; set; }
        public int AgencyId { get; set; }
        public string LoginName { get; set; }
        public string LoginDetails { get; set; }
        public Boolean isPrimaryAgent { get; set; }
    }
}