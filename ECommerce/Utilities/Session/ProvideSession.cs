using ECommerce.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Utilities.Session
{
    [Serializable]
    public class UserSession
    {
        public string UserEmail { get; set; }
    }
    public class ProvideSession
    {
        public static void SetSession(UserSession userSession)
        {
            HttpContext.Current.Session["SessionUserLogin"] = userSession;
        }

        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["SessionUserLogin"];
            if(session == null)
            {
                return null;
            }
            else
            {
                return session as UserSession;
            }
        }
    }
}