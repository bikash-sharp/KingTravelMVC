using KingTravel.Models;
using KingTravel_Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KingTravel.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult HotelInfo()
        {
            HotelInfoCL htlinfo = new HotelInfoCL();
            //var GetCountryList = DataProviderWrapper.Instance.GetCountryList();
            htlinfo.CountryList = new List<System.Web.WebPages.Html.SelectListItem>();
            ViewBag.Adultlist = new List<SelectListItem>();
            ViewBag.Childrenlist = new List<SelectListItem>();
            ViewBag.Roomlist = new List<SelectListItem>();
            ViewBag.NightStayList = new List<SelectListItem>();

            return View(htlinfo);
        }

        [HttpGet]
        public ActionResult BookingInfo()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CancellationInfo()
        {
            return View();
        }
    }
}