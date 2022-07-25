using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV
            // DONE


            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            // DONE

            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */
            //  DONE

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            // DONE

            //Now, create objects of your 3 classes and give their members values;
            Truck newTruck = new Truck("Blue", "F150", "2007", 3, "Ford with a circle around it", "Ford", 20.4, true);
            Car newCar = new Car("Red", "Camry", "2015", 2, "three overlapping circles", "Toyota", 5.4, true);
            SUV newSUV = new SUV("Yellow", "Veracruz", "2008", 4, "a Stylized H", "Hyundai", 7, true);
            


            //Creatively display and organize their values

            Console.WriteLine($"Three Cars have gotten in a wreck. These are their descriptions.");
            Console.WriteLine("");

            newTruck.CrashDescription();
            newCar.CrashDescription();
            newSUV.CrashDescription();
        }
    }
}
