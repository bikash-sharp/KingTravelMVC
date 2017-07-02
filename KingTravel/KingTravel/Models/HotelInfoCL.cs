using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace KingTravel.Models
{
    public class HotelInfoCL
    {
        public int ID { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage="*Required")]
        public int CountryID { get; set; }

        public List<SelectListItem> CountryList { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "*Required")]
        public int CityId { get; set; }

        public List<SelectListItem> CityList { get; set; }

        [Display(Name = "Top City")]
        [Required(ErrorMessage = "*Required")]
        public int TopCityID { get; set; }

        public List<SelectListItem> TopCityList { get; set; }

        [Required(ErrorMessage = "*Required")]
        public DateTime CheckIn { get; set; }

        [Display(Name = "Guest Nationality")]
        [Required(ErrorMessage = "*Required")]
        public int GuestNationalityID { get; set; }

        [Display(Name = "Adults(18+)")]
        [Required(ErrorMessage = "*Required")]
        public int Adults { get; set; }

        [Required(ErrorMessage = "*Required")]
        public int Children { get; set; }

        [Required(ErrorMessage = "*Required")]
        public int Room { get; set; }

        [Required(ErrorMessage = "*Required")]
        public int NightStay { get; set; }

        public bool CheckNearbyHotel { get; set; }

        public HotelInfoCL()
        {
            CountryList = new List<SelectListItem>();
        }
    }
}