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
		[HttpGet]
		public ActionResult Index()
		{
			ShoppingDB db = new ShoppingDB();


			List<Item> AllItems = db.Items.ToList();

			

			return View(AllItems);
		}

		[HttpPost]
		public ActionResult Index(string name, string brand, string category, int sort)
		{
			ShoppingDB db = new ShoppingDB();

			List<Item> sortItems = new List<Item>();

			//if there is a name search - doesn't equal "all"
			if(!name.ToLower().Equals("none")) 
			{
				//if brand is selected
				if(!name.ToLower().Equals("all"))
				{
					//if category is selected
					if (!category.ToLower().Equals("all"))
					{

					}
					//if no category is selected
					else
					{

					}


				}
				//if no brand selected
				else
				{

				}

			}
			//if there isn't a name search - equals "none"
			else
			{

			}

			

			return View(sortedItems);

		}

	}


		
}