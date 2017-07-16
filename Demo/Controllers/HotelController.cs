using Demo.Common;
using Demo.Models;
using Demo.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    [RoutePrefix("Hotel")]
    public class HotelController : Controller
    {
        
        // GET: Hotel
        [Route]
        public ActionResult Index()
        {
            try
            {
                if (Session["Token"] == null)
                {
                    string result = CommonCL.Instance().Login();
                }
            }

            catch (Exception ex)
            {
                
            }
            return View();
        }
        [HttpGet]
        [Route("Search")]
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        [Route("Search")]
        public ActionResult Search(HotelSearchViewModel Model)
        {
            return View("Search",Model);
        }

        [Route("Countries")]
        public JsonResult CountryList()
        {
            return new JsonResult();
        }
    }
}