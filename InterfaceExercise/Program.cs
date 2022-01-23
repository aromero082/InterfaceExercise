using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {

        static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();

            var suv = new SUV();

            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();

                vehicle.Reverse();
            }







        }
    }
}
