using Demo.Common;
using Demo.Models;
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
    }
}