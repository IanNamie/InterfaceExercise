using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany
    {
        public bool HasTrunk { get; set; }
        public bool LowToTheGround { get; set; }
       

        // IVehicle 
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string ModelOfCar { get; set; }
        public int RowsOfSeating { get; set; }
        

        // ICompany
        public string CompanyName { get; set; }
        public string CompanyMotto { get; set; }


    }
}
