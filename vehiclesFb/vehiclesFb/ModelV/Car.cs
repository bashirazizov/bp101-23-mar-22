using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclesFb.ModelV
{
    class Car : MotoredVehicle
    {
        public string Transmission;
        public bool IsOn;

        public void Go(int distance)
        {
            if (IsOn)
            {
                if (distance*FuelUsedPerKm<=FuelAmount)
                {
                    FuelAmount -= (int)(distance * FuelUsedPerKm);
                    Console.WriteLine($"Car went {distance} kms. Remaining fuel: {FuelAmount}");
                }
                else
                {
                    Console.WriteLine($"Not enough fuel! Available range: {FuelAmount/ FuelUsedPerKm}.");
                }
            }
            else
            {
                Console.WriteLine("Car is off. Please turn on the car.");
            }
        }

        public void TurnOn()
        {
            if (IsOn)
            {
                Console.WriteLine("Car is already on!");
            }
            else
            {
                IsOn = true;
                Console.WriteLine("Car turned on!");
            }
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                IsOn = false;
                Console.WriteLine("Car turned off!");
            }
            else
            {
                Console.WriteLine("Car is already off!");
            }
        }

        public Car(string model, string make, int year, int motorSize) : base(model,make,year)
        {
            MotorSize = motorSize;
        }
    }
}
