using ShoppingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingSite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ShoppingDB db = new ShoppingDB();


			List<Item> AllItems = db.Items.ToList();

			

			return View(AllItems);
		}
	}
		
}