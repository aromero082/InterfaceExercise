using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {

        }

        public double EngineSize { get; set; } = 2.4;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Honda";
        public string Motto { get; set; } = "Lasts forever";
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving foward...");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("can't park until we cahnge gears");
            }
            
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                 HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("can't reverse until we cahnge gears");
            }
            
        }
    }
}
