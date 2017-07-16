using Demo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Demo.Common
{
    public enum ResponseType
    {
        INFO,
        PRIMARY,
        SUCCESS,
        WARNING,
        DANGER,
        DEFAULT
    }
    public enum Verbs
    {
        GET,
        POST
    }
    public class CommonCL
    {
        private static readonly CommonCL _instance;

        static CommonCL()
        {
            _instance = new CommonCL();
        }

        public static CommonCL Instance()
        {
            return _instance;
        }

        public static string Baseurl = ConfigurationManager.AppSettings["apiUrl"].ToString();

        public string Login()
        {
            string LoginResult = string.Empty;
            try
            {
                AuthenticateCL auth = new AuthenticateCL();
                auth.ClientId =  ConfigurationManager.AppSettings["ClientId"].ToString();
                auth.EndUserIp = ConfigurationManager.AppSettings["EndUserIp"].ToString();
                auth.UserName = ConfigurationManager.AppSettings["UserName"].ToString();
                auth.Password = ConfigurationManager.AppSettings["Password"].ToString();
                var jsonStringObject = JsonConvert.SerializeObject(auth);
                String Qualifiedurl = Baseurl + "SharedServices/SharedData.svc/rest/Authenticate";
                var result = HotelOperation.Instance().GetResponse(Qualifiedurl, Verbs.POST, jsonStringObject);
                if (result != null)
                {
                    AuthenticateResponse authResponse = new AuthenticateResponse();
                    authResponse = JsonConvert.DeserializeObject<AuthenticateResponse>(result);
                    if (authResponse.Error != null)
                    {
                        if (authResponse.Error.ErrorCode > 0)
                        {
                            HttpContext.Current.Session["ErrorMsg"] = authResponse.Error.ErrorMessage;
                            LoginResult = authResponse.Error.ErrorMessage;
                        }
                        else
                        {
                            HttpContext.Current.Session["Token"] = authResponse.TokenId.ToString();
                            HttpContext.Current.Session["AgencyId"] = authResponse.Member.AgencyId.ToString();
                            HttpContext.Current.Session["MemberId"] = authResponse.Member.MemberId.ToString();
                        }
                    }
                    else
                    {
                        LoginResult = "Sucess";
                    }
                    
                }
            }
            catch
            {
                LoginResult = "Failed";
            }
            return LoginResult;
        }

        public string Logout()
        {
            String logoutresult = string.Empty;
            LogoutResponse logout = new LogoutResponse();
            try
            {
                
                int MemberId = 0;
                int AgencyId = 0;
                LogoutRequest requestLogout = new LogoutRequest();
                requestLogout.ClientId =  ConfigurationManager.AppSettings["ClientId"].ToString();
                requestLogout.EndUserIp = ConfigurationManager.AppSettings["EndUserIp"].ToString();
                int.TryParse(HttpContext.Current.Session["AgencyId"].ToString(), out AgencyId);
                int.TryParse(HttpContext.Current.Session["MemberId"].ToString(), out MemberId);
                requestLogout.TokenAgencyId = AgencyId; 
                requestLogout.TokenMemberId = MemberId;
                requestLogout.TokenId = HttpContext.Current.Session["Token"].ToString();
                var jsonStringObject = JsonConvert.SerializeObject(requestLogout);
                String Qualifiedurl = Baseurl + "SharedServices/SharedData.svc/rest/Logout";
                var result = HotelOperation.Instance().GetResponse(Qualifiedurl, Verbs.POST, jsonStringObject);
                if (result != null)
                {
                    logout = JsonConvert.DeserializeObject<LogoutResponse>(result);
                    if(logout != null)
                    {
                        if(logout.Error != null)
                        {
                            if(logout.Error.ErrorCode > 0)
                            {
                                logoutresult = logout.Error.ErrorMessage;
                            }
                        }
                        else
                        {
                            logoutresult = "success";
                        }
                    }
                }
                else
                {
                    logoutresult = "Failed";
                }
            }
            catch (Exception ex)
            {
                logoutresult = "Failed";
            }
            return logoutresult;
        }
    }
}