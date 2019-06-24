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

			List<Item> sortedItems = new List<Item>();

			string sortString = "";

			//name search
			if(name.ToLower().Equals(""))
			{
				sortString += 0;
			}
			else
			{
				sortString += 1;
			}

			//brand search
			if(brand.ToLower().Equals("all"))
			{
				sortString += 0;
			}
			else
			{
				sortString += 1;
			}

			//category search
			if(category.ToLower().Equals("all"))
			{
				sortString += 0;
			}
			else
			{
				sortString += 1;
			}

			sortString += sort;

			//NO SEARCH JUST SORT

			//nothing selected, return in alphabetical order
			if(sortString.Equals("0000"))
			{

			}
			//nothing selected but low to high sort
			else if(sortString.Equals("0001"))
			{

			}
			//nothing selected but high to low sort
			else if(sortString.Equals("0002"))
			{

			}
			//nothing selected but newest sort
			else if(sortString.Equals("0003"))
			{

			}
			//nothing selected but oldest sort
			else if(sortString.Equals("0004"))
			{

			}

			//NAME SEARCH

			//search by name only, alphabetical
			else if(sortString.Equals("1000"))
			{

			}
			//search by name, sort low to high
			else if(sortString.Equals("1001"))
			{

			}
			//search by name, sort high to low
			else if(sortString.Equals("1002"))
			{

			}
			//search by name, newest
			else if (sortString.Equals("1003"))
			{

			}
			//search by name, oldest
			else if (sortString.Equals("1004"))
			{

			}

			//NAME AND BRAND

			//search by name and brand, alphabetical
			else if (sortString.Equals("1100"))
			{

			}
			//search by name and brand, low to high
			else if (sortString.Equals("1101"))
			{

			}
			//search by name and brand, high to low
			else if (sortString.Equals("1102"))
			{

			}
			//search by name and brand, newest
			else if (sortString.Equals("1103"))
			{

			}
			//search by name and brand, oldest
			else if (sortString.Equals("1104"))
			{

			}

			//NAME, BRAND, and CATEGORY

			//alphabetical
			else if (sortString.Equals("1110"))
			{

			}
			//low to high
			else if (sortString.Equals("1111"))
			{

			}
			//high to low
			else if (sortString.Equals("1112"))
			{

			}
			//newest
			else if (sortString.Equals("1113"))
			{

			}
			//oldest
			else if (sortString.Equals("1114"))
			{

			}

			//JUST BRAND

			//alphabetical
			else if (sortString.Equals("0100"))
			{

			}
			//low to high
			else if (sortString.Equals("0101"))
			{

			}
			//high to low
			else if (sortString.Equals("0102"))
			{

			}
			//newest
			else if (sortString.Equals("0103"))
			{

			}
			//oldest
			else if (sortString.Equals("0104"))
			{

			}

			//JUST CATEGORY

			//alphabetical
			else if (sortString.Equals("0010"))
			{

			}
			//low to high
			else if (sortString.Equals("0011"))
			{

			}
			//high to low
			else if (sortString.Equals("0012"))
			{

			}
			//newest
			else if (sortString.Equals("0013"))
			{

			}
			//oldest
			else if (sortString.Equals("0014"))
			{

			}

			//BRAND AND CATEGORY

			//alphabetical
			else if (sortString.Equals("0110"))
			{

			}
			//low to high
			else if (sortString.Equals("0111"))
			{

			}
			//high to low
			else if (sortString.Equals("0112"))
			{

			}
			//newest
			else if (sortString.Equals("0113"))
			{

			}
			//oldest
			else if (sortString.Equals("0114"))
			{

			}


			return View(sortedItems);

		}

		//public List<Item> sortItemsBy(List<Item> sortList, int sort)
		//{
		//}

	}


		
}