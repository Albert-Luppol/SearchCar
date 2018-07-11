using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SearchCar.Models
{

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }
        public int Year { get; set; }
        public double EngineSize { get; set; }
        public int Millage { get; set; }

    }
}