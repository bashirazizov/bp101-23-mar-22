using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiclesFb.ModelV
{
    class MotoredVehicle
    {
        public string Model;
        public string Make;
        public int ProductionYear;
        public int MotorSize;
        public int FuelTankSize;
        public int FuelAmount;
        public double FuelUsedPerKm;
        public string Color;
        public int HorsePower;
        public int PassangerCount;

        public MotoredVehicle()
        {}

        public MotoredVehicle(string model, string make, int year)
        {
            Model = model;
            Make = make;
            ProductionYear = year;
        }

        public string GetInfo()
        {
            return $"{Model} - {Make} - {ProductionYear}";
        }

        public string GetDetailedInfo()
        {
            return $"{Model} - {Make} - {ProductionYear} - {MotorSize}";
        }
    }
}
