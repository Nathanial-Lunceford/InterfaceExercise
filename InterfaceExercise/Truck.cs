using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string color { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int numofWheels { get; set; }
        public string logo { get; set; }
        public string name { get; set; }


        /* Members that are specific to this class*/

        public double bedSize { get; set; }
        public bool hasABrushGuard { get; set; }

        public Truck(string color, string model, string year, int numofWheels, 
            string logo, string name, double bedSize, bool hasABrushGuard)
        {
            this.color = color;
            this.model = model;
            this.year = year;
            this.numofWheels = numofWheels;
            this.logo = logo;
            this.name = name;
            this.bedSize = bedSize;
            this.hasABrushGuard = hasABrushGuard;
        }

        public void CrashDescription()
        {
            Console.WriteLine($"This truck is a {this.color} {this.model} from the year {this.year}. It has {this.numofWheels} wheels still intact. The logo, {this.logo}, has been bent out of " + $"its original shape. It is a {this.name}, it has a bed size of {this.bedSize} inches, and" + $" does it still have a brush guard? {this.hasABrushGuard}");
        }
    }
}
