using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.ViewModels
{
    public class HotelSearchViewModel
    {
        [Display(Name ="Country Name")]
        public string CountryValue {get;set;}
        public string CityName { get; set; }
        public string TopCityName { get; set;}
        public DateTime CheckInDate { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomCount { get; set; }
        public int NightStayCount { get; set; }
        public string guestCountry { get; set; }
        public int MaxratingStar { get; set; }
        public int MinRatingStar { get; set; } 
    }
}