using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDMORE.Models
{
    public class U
    {
        public static IEnumerable<SelectListItem> GetCity
        {
            get
            {
                using(CRUDDataEntities db=new CRUDDataEntities())
                {
                    foreach(var city in db.Cities)
                    {
                        yield return new SelectListItem { Text = city.CityName, Value = city.CityId.ToString() };
                    }
                }
            }
        }
        public static string GetCityNameByCityId(int? id)
        {
            using(CRUDDataEntities db=new CRUDDataEntities())
            {
                var search = db.Logins.Where(x => x.CityId == id).FirstOrDefault();
                return search.City.CityName;
            }
        }
        public static string GetGender(bool a)
        {
            using(CRUDDataEntities db= new CRUDDataEntities())
            {
                var Search = db.Logins.Where(x => x.Gender == a).FirstOrDefault();
                if(Search!=null && Search.Gender!=false)
                {
                    return "Male";
                }
                else
                {
                    return "Female";
                }
            }
        }
    }
}