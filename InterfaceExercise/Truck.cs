using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public double EngineSize { get; set; } = 5.7;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Tundra";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Tundra";
        public string Motto { get; set; } = "Lats forerver";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;

        }

        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving foward...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving foward...");
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
                Console.WriteLine("can't reverse until we change gears");
            }

        }

        public void Park()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("we can't park until we change gears");
            }
        }






    }
}
