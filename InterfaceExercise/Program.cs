using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            List<Car> carInfo = new();
            List<Truck> truckInfo = new();
            List<Suv> suvInfo= new();


            var honda = new Car();
            honda.HasTrunk = true;
            honda.ModelOfCar = "Civic";
            honda.RowsOfSeating = 2;
            honda.LowToTheGround = true;
            honda.NumberOfDoors = 4;
            honda.NumberOfWheels = 4;
            honda.CompanyMotto = "The Power Of Dreams!";
            honda.CompanyName = "Honda";

            carInfo.Add(honda);

            var chevy = new Truck();
            chevy.HasTruckBed = true;
            chevy.ModelOfCar = "Silverado";
            chevy.RowsOfSeating = 2;
            chevy.BadGasMilage = true;
            chevy.NumberOfDoors = 4;
            chevy.NumberOfWheels = 4;
            chevy.CompanyMotto = "Find New Roads!";
            chevy.CompanyName = "Chevy";

            truckInfo.Add(chevy);

            var mazda = new Suv();
            mazda.ThirdRow = false;
            mazda.ModelOfCar = "CX-5";
            mazda.RowsOfSeating = 2;
            mazda.TotalPassangers = 5;
            mazda.NumberOfDoors = 4;
            mazda.NumberOfWheels = 4;
            mazda.CompanyMotto = "Celebrate Driving!";
            mazda.CompanyName = "Mazda";
        
            suvInfo.Add(mazda);

            Console.WriteLine("CARS:");
            Console.WriteLine("");

            foreach(var car in carInfo) 
            {
                Console.WriteLine($"Company Name: {car.CompanyName}");
                Console.WriteLine($"Company Motto: {car.CompanyMotto}");
                Console.WriteLine($"model: {car.ModelOfCar}");
                Console.WriteLine($"Number of doors: {car.NumberOfDoors} // Number of wheels: {car.NumberOfWheels} " +
                    $"// low to the ground: {car.LowToTheGround} // Trunk: {car.HasTrunk}");
                Console.WriteLine("_________________________________________________________________________________________");

            }

            Console.WriteLine("TRUCKS:");
            Console.WriteLine("");

            foreach (var truck in truckInfo)
            {
                Console.WriteLine($"Company Name: {truck.CompanyName}");
                Console.WriteLine($"Company Motto: {truck.CompanyMotto}");
                Console.WriteLine($"model: {truck.ModelOfCar}");
                Console.WriteLine($"Number of doors: {truck.NumberOfDoors} // Number of wheels: {truck.NumberOfWheels} " +
                    $"// low MPG: {truck.BadGasMilage} // Truck Bed: {truck.HasTruckBed }");
                Console.WriteLine("_________________________________________________________________________________________");

            }

            Console.WriteLine("SUVS:");
            Console.WriteLine("");

            foreach (var suv in suvInfo)
            {
                Console.WriteLine($"Company Name: {suv.CompanyName}");
                Console.WriteLine($"Company Motto: {suv.CompanyMotto}");
                Console.WriteLine($"model: {suv.ModelOfCar}");
                Console.WriteLine($"Number of doors: {suv.NumberOfDoors} // Number of wheels: {suv.NumberOfWheels} " +
                    $"// Seating Rows: {suv.RowsOfSeating} // Third Row: {suv.ThirdRow}");
                Console.WriteLine("_________________________________________________________________________________________");

            }



        }
    }
}
