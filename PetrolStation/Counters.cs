using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Counters
    {
        //variable declaration
        #region
        /// <summary>
        /// declaring private atributtes of the Counters Class
        /// </summary>
        private int vehiclesServiced, vehiclesLeft, vehiclesWaiting;
        private double litresDispensed, comission, totalGains, dieselDispensed, unleadedDispensed, LPGDispensed;

        public double LitresDispensed
        {
            get
            {
                return litresDispensed;
            }

            set
            {
                litresDispensed = value;
            }
        }

        public double Comission
        {
            get
            {
                return comission;
            }

            set
            {
                comission = value;
            }
        }

        public double TotalGains
        {
            get
            {
                return totalGains;
            }

            set
            {
                totalGains = value;
            }
        }

        public int VehiclesServiced
        {
            get
            {
                return vehiclesServiced;
            }

            set
            {
                vehiclesServiced = value;
            }
        }

        public int VehiclesLeft
        {
            get
            {
                return vehiclesLeft;
            }

            set
            {
                vehiclesLeft = value;
            }
        }

        public int VehiclesWaiting
        {
            get
            {
                return vehiclesWaiting;
            }

            set
            {
                vehiclesWaiting = value;
            }
        }

        public double DieselDispensed
        {
            get
            {
                return dieselDispensed;
            }

            set
            {
                dieselDispensed = value;
            }
        }

        public double UnleadedDispensed
        {
            get
            {
                return unleadedDispensed;
            }

            set
            {
                unleadedDispensed = value;
            }
        }

        public double LPGDispensed1
        {
            get
            {
                return LPGDispensed;
            }

            set
            {
                LPGDispensed = value;
            }
        }
        #endregion

        //the constructor
        #region
        public Counters(double _litresDispensed, double _totalGains, double _Commision)
        {
            //add starting values
            this.litresDispensed = _litresDispensed;
            this.totalGains = _totalGains;
            this.Comission = _Commision;
            this.VehiclesLeft = 0;
            this.DieselDispensed = 0;
            this.UnleadedDispensed = 0;
            this.VehiclesServiced = 0;
            this.LPGDispensed1 = 0;
            this.vehiclesWaiting = 0;

        }
        #endregion
    }
}

