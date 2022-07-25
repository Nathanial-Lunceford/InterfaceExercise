using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public  class Car : IVehicle, ICompany
    {
        public string color { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int numofWheels { get; set; }
        public string logo { get; set; }
        public string name { get; set; }


        /* Members that are specific to this class*/

        public double trunkArea { get; set; }
        public bool has4Seats { get; set; }

        public Car(string color, string model, string year, int numofWheels, string logo, string name, double trunkArea, bool has4Seats)
        {
            this.color = color;
            this.model = model;
            this.year = year;
            this.numofWheels = numofWheels;
            this.logo = logo;
            this.name = name;
            this.trunkArea = trunkArea;
            this.has4Seats = has4Seats;
        }

        public void CrashDescription()
        {
            Console.WriteLine($"This Car is a {this.color} {this.model} from the year {this.year}. It has {this.numofWheels} wheels still intact. The logo, {this.logo}, has been bent out of " + $"its original shape. It is a {this.name}, it has a trunk size of {this.trunkArea} feet, and" + $" does it still have 4 seats? {this.has4Seats}");
        }
    }
}
