using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Npgsql;
using SearchCar.Models;

namespace SearchCar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Add a new car:";

            return View();
        }

        public ActionResult ViewAll()
        {
            var connString = "Server=127.0.0.1;Port=5432;Database=Cars;User Id=postgres;Password=sYk2f3Tn;";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Retrieve all rows
                using (var cmd = new NpgsqlCommand("SELECT some_field FROM data", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));
            }
        
        List<Car> cars = new List<Car>();
            cars.Add(new Car { Make = "Lotus", Model = "Elise", Fuel = "Petrol", Year = 2017, EngineSize = 2.6, Millage = 10000 });
            cars.Add(new Car { Make = "Lotus", Model = "Exige", Fuel = "Petrol", Year = 2017, EngineSize = 2.6, Millage = 10000 });
            cars.Add(new Car { Make = "Mersedes", Model = "E260", Fuel = "Diesel", Year = 2012, EngineSize = 3.0, Millage = 105000 });
            return View(cars);
        }
    }
}