using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VienShops.Models;

namespace VienShops.Controllers
{
	public class HomeController : Controller
	{
		DBVienShopsDataContext Db = new DBVienShopsDataContext();

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		// sản phẩm mới 
		public ActionResult NewProduct()
		{
			var newProduct = Db.SANPHAMs.OrderBy(n => n.MASP).Take(4).ToList();
			return PartialView(newProduct);
		}
		public ActionResult FeaturedProduct() {
			var featuredProduct = Db.SANPHAMs.OrderBy(n => n.GIA).Take(4).ToList();
			return PartialView(featuredProduct);
		} 
        public ActionResult Products()
        {
            var products = Db.LOAISANPHAMs.ToList();
            return PartialView(products);
        }
	}
}