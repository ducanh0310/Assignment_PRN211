using AutomobileWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutomobileWebApp.Controllers
{
    public class CarController : Controller
    {
		 static string  msg = "";
        public IActionResult List()
        {
            using (var context = new MyStockContext())
            {
                List<Car> list = context.Cars.ToList();
                ViewBag.list = list;

            }

            return View();
        }

		public IActionResult Back()
		{
			return RedirectToAction("List");
		}

		public IActionResult Delete(int id)
		{
			using (var context = new MyStockContext())
			{

                Car e = context.Cars.FirstOrDefault(x => x.CarId == id);
				context.Cars.Remove(e);
                context.SaveChanges();

			}

			return RedirectToAction("List");
		}

		public IActionResult Add()
        {
			ViewBag.msg = msg;
			if(!msg.Equals(""))
			{
				ViewBag.msg = msg;
				msg = "";
			}
			return View();
        }


		public IActionResult Edit(int id)
		{

			using (var context = new MyStockContext())
			{

				Car e = context.Cars.FirstOrDefault(x => x.CarId == id);
				ViewBag.car = e;
				context.SaveChanges();

			}

			
			return View();
		}

		public IActionResult DoAdd()
		{
			

			try
			{

				string name = HttpContext.Request.Form["name"];
				string manufacture = HttpContext.Request.Form["manufacture"];
				Decimal price = Decimal.Parse(HttpContext.Request.Form["price"]);
				int year = int.Parse(HttpContext.Request.Form["year"]);
				if(year < 1000 && year > 2023)
				{
					msg = "Please enter a valid year";
					return RedirectToAction("Add");
				}

				int id = int.Parse(HttpContext.Request.Form["id"]);
				using (var context = new MyStockContext())
				{
					Car e = context.Cars.FirstOrDefault(x => x.CarId == id);
					if (e != null)
					{
						msg = "Id has already exist";
						return RedirectToAction("Add");
					}

				}
				

				using (var context = new MyStockContext())
				{


					Car e = new Car();
					e.CarId = id;
					e.CarName = name;
					e.Manufacturer = manufacture;
					e.ReleasedYear = year;
					e.Price = price;

					context.Cars.Add(e);
					context.SaveChanges();

				}


				

			} catch(Exception e)
			{
				msg = "Please input all fields and correct format!";
				return RedirectToAction("Add");
			}


			return RedirectToAction("List");
		}


		public IActionResult DoEdit()
		{


			try
			{

				int id = int.Parse(HttpContext.Request.Form["id"]);
				string name = HttpContext.Request.Form["name"];
				string manufacture = HttpContext.Request.Form["manufacture"];
				Decimal price = Decimal.Parse(HttpContext.Request.Form["price"]);
				int year = int.Parse(HttpContext.Request.Form["year"]);
				if (year < 1000 && year > 2023)
				{
					msg = "Please enter a valid year";
					return RedirectToAction("Add");
				}

				using (var context = new MyStockContext())
				{

					Car e = new Car();
					e.CarId = id;
					e.CarName = name;
					e.Manufacturer = manufacture;
					e.ReleasedYear = year;
					e.Price = price;

					context.Cars.Update(e);
					context.SaveChanges();

				}
			} catch(Exception e)
			{
				msg = "Please input all fields and correct format!";
				return RedirectToAction("Add");
			}

			

			return RedirectToAction("List");
		}



	}
}
