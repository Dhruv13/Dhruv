using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuThentication.Models
{
    public class AuthoriseAttribute:System.Web.Mvc.AuthorizeAttribute
    {
         protected override bool AuthorizeCore(HttpContextBase httpContext)
         {
             var array = Roles.Split(',');
             return array.Contains(SessionWrapper.UserRole) && SessionWrapper.UserId != null;
         }
         protected override void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext)
         {
             filterContext.HttpContext.Response.Redirect("~/Home/Login");
         }
    }
}