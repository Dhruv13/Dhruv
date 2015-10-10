using AjexCRUDMore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjexCRUDMore.Controllers
{
    public class HomeController : Controller
    {
        private AjexDbEntities db = new AjexDbEntities();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Products = db.Products.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View(new ProductViewModel());
        }
        [HttpPost]
        public ActionResult Add(ProductViewModel model,HttpPostedFileBase photo)
        {
            if (ModelState.IsValid)
            {
                

                var search = db.Products.FirstOrDefault(x => x.ProductName == model.ProductName);
                if(search==null)
                {
                    db.Products.Add(new Product
                    {
                        ProductName = model.ProductName
                    });
                    db.SaveChanges();
                    
                    return Content("Added");
                }
                else
                {
                    return Content("Already Available");
                }
            }
            else
            {
                return Content("Fill The Required Fields");
            }
       
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var search = db.Products.FirstOrDefault(x => x.ProductId == id.Value);
            if(search==null)
            {
                return Content("Not Aviailable");
            }
            else
            {
                ProductViewModel model = new ProductViewModel()
                {
                    ProductId = search.ProductId,
                    ProductName = search.ProductName,
                };
                return View(model);
            }
        }
        [HttpPost]
        public ActionResult Edit(ProductViewModel model)
        {
            if(ModelState.IsValid)
            {
                var search = db.Products.Where(x => x.ProductId == model.ProductId).FirstOrDefault();
                if(search==null)
                {
                    return Content("Cant Found");
                }
                else
                {
                    search.ProductName = model.ProductName;
                    db.SaveChanges();
                    return Content("Updated");
                }
            }
            else
            {
                return Content("Fill Required Fileds");
            }
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var search = db.Products.Where(x => x.ProductId == id.Value).FirstOrDefault();
            if(search==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ProductViewModel model = new ProductViewModel()
                {
                    ProductId = search.ProductId,
                    ProductName = search.ProductName
                };
                return View(model);
            }
        }
        [HttpPost]
        public ActionResult Delete(ProductViewModel model)
        {
            var search = db.Products.Where(x => x.ProductId == model.ProductId).FirstOrDefault();
            if(search==null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                db.Products.Remove(search);
                db.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index");

            }
        }

    }
}