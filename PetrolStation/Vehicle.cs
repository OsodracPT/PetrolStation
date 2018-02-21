using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Vehicle
    {
        /// <summary>
        /// variable declaration
        /// </summary>
        #region

        //declaring a random
        private static Random randFuelN = new Random();


        private string[] typesAvailable;
        public string[] TypesAvailable
        {
            get
            {
                return typesAvailable;
            }

            set
            {
                typesAvailable = value;
            }
        }

        private string carType;
        private string vehicleFuel;
        public string VehicleFuel
        {
            get
            {
                return vehicleFuel;
            }

            set
            {
                vehicleFuel = value;
            }
        }

        private int fuelAmount;
        public int FuelAmount
        {
            get
            {
                return fuelAmount;
            }

            set
            {
                fuelAmount = value;
            }
        }

        private int fuelTank;
        public int FuelTank
        {
            get
            {
                return fuelTank;
            }

            set
            {
                fuelTank = value;
            }
        }

        public int EmptyTank
        {
            get
            {
                return emptyTank;
            }

            set
            {
                emptyTank = value;
            }
        }
        private int emptyTank;

        public string[] fuelType;
        #endregion

        public Vehicle()
        {
            TypesAvailable = "Car|Van|HGV".Split('|');
            fuelType = "LPG|Diesel|Unleaded".Split('|');
        }

        /// <summary>
        /// The class constructor that will randomize the type of fuel and the ammount
        /// </summary>
        /// <param name="vehicleTypeTemp">Get the vehicle type</param>
        /// <param name="vehicleFuelTemp">Get the fuel type</param>
        #region
        public Vehicle(string vehicleTypeTemp, string vehicleFuelTemp)
        {
            this.carType = vehicleTypeTemp;
            this.vehicleFuel = vehicleFuelTemp;

            //get total and current fuel value

            //check if the vehicle is a Car with a fuel tank of 40 litres max
            if (this.carType == "Car")
            {
                this.fuelAmount = randFuelN.Next(0, 10);
                this.fuelTank = 40;
                this.emptyTank = this.fuelTank - this.fuelAmount;

            }
            //check if the vehicle is a Van with a fuel tank of 80 litres max
            if (this.carType == "Van")
            {
                this.fuelAmount = randFuelN.Next(0, 20);
                this.fuelTank = 80;
                this.emptyTank = this.fuelTank - this.fuelAmount;

            }
            //vehicle is a HGV so its fuel tank is 150l max
            if (this.carType == "HGV")
            {
                this.fuelAmount = randFuelN.Next(0, 37);
                this.fuelTank = 150;
                this.emptyTank = this.fuelTank - this.fuelAmount;
            }

        }
        #endregion
    }
}
