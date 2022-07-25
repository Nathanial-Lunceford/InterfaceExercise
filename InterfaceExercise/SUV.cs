using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string color { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int numofWheels { get; set; }
        public string logo { get; set; }
        public string name { get; set; }


        /* Members that are specific to this class*/
        
        public int howManySeats { get; set; }
        public bool hasATrunk { get; set; }

        public SUV(string color, string model, string year, int numofWheels, string logo, string name, int howManySeats, bool hasATrunk)
        {
            this.color = color;
            this.model = model;
            this.year = year;
            this.numofWheels = numofWheels;
            this.logo = logo;
            this.name = name;
            this.howManySeats = howManySeats;
            this.hasATrunk = hasATrunk;
        }

        public void CrashDescription()
        {
            Console.WriteLine($"This SUV is a {this.color} {this.model} from the year {this.year}. It has {this.numofWheels} wheels still intact. The logo, {this.logo}, has been bent out of " + $"its original shape. It is a {this.name}, it has {this.howManySeats} seats still intact, and" + $" does it have a trunk? {this.hasATrunk}");
        }
    }
}
