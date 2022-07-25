using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public string color { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public int numofWheels { get; set; }
    }
}
