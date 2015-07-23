using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuThentication.Models
{
    public class SessionWrapper
    {
        public static string UserRole
        {
            get
            {
                if (HttpContext.Current.Session["UserRole"] != null)
                    return HttpContext.Current.Session["UserRole"] as string;
                return "";
            }
            set
            {
                HttpContext.Current.Session["UserRole"] = value;
            }
        }

        public static string UserName
        {
            get
            {
                if (HttpContext.Current.Session["UserName"] != null)
                    return HttpContext.Current.Session["UserName"] as string;
                return "";
            }
            set
            {
                HttpContext.Current.Session["UserName"] = value;
            }
        }

        public static int UserId
        {
            get
            {
                if (HttpContext.Current.Session["UserId"] == null)
                    return 0;
                return int.Parse(HttpContext.Current.Session["UserId"].ToString());
            }
            set
            {
                HttpContext.Current.Session["UserId"] = value;
            }
        }

        public static void SignOut()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}