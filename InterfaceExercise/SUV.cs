using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {

        public SUV()
        {
        }


        public double EngineSize { get; set; } = 3.4;
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Rougue";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "Nissan";
        public string Motto { get; set; } = "Japanese engineering";
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
            if(HasChangedGears == true)
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
                Console.WriteLine("can't park until we change gears");
            }
        }
            



    }
}