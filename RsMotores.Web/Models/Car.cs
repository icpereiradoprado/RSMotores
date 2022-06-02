using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Car(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public static List<Car> ShowCars()
        {
            List<Car> cars = new();
            cars.Add(new Car(1, "vectra", "carro quatro portas"));
            cars.Add(new Car(2, "Uno", "carro duas portas"));
            cars.Add(new Car(3, "Celta", "carro duas portas"));
            cars.Add(new Car(4, "Monza", "carro quatro portas"));

            return cars;
        }
    }
}
