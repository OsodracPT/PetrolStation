using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Transaction
    {
        //variable declaration
        #region
        /// <summary>
        /// declaring private atributtes of the Transaction Class
        /// </summary>
        private int pumpNumber;
        private float litresDispensed, comission, totalGains, dieselDispensed, unleadedDispensed, LPGDispensed;
        private string vehicleType, vehicleFuelType;

        //flag for the loop to know if this transactions was already read and added to the counter
        //each time a car leaves and a timer runs
        private bool loopFlag;
        private bool transactionLoopFlag;

        public float LitresDispensed
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

        public float Comission
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

        public float TotalGains
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

        public int PumpNumber
        {
            get
            {
                return pumpNumber;
            }

            set
            {
                pumpNumber = value;
            }
        }


        public string VehicleType
        {
            get
            {
                return vehicleType;
            }

            set
            {
                vehicleType = value;
            }
        }

        public string VehicleFuelType
        {
            get
            {
                return vehicleFuelType;
            }

            set
            {
                vehicleFuelType = value;
            }
        }

        public bool LoopFlag
        {
            get
            {
                return loopFlag;
            }

            set
            {
                loopFlag = value;
            }
        }

        public float DieselDispensed
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

        public float UnleadedDispensed
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

        public float LPGDispensed1
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

        public bool TransactionLoopFlag
        {
            get
            {
                return transactionLoopFlag;
            }

            set
            {
                transactionLoopFlag = value;
            }
        }
        #endregion

        //The constructor
        #region
        public Transaction(int _pumpNumber, float _litresDispensed, string _vehicleType, string _vehicleFuelType, bool _loopFlag)
        {

            this.pumpNumber = _pumpNumber;
            this.litresDispensed = _litresDispensed;
            this.vehicleType = _vehicleType;
            this.vehicleFuelType = _vehicleFuelType;

            switch (vehicleFuelType)
            {
                case "Diesel":
                    //1.2 is the price of diesel fuel
                    this.totalGains = this.litresDispensed * 1.20f;
                    this.DieselDispensed = this.litresDispensed;
                    break;

                case "Unleaded":
                    //1.18 is the price of unleaded fuel
                    this.totalGains = this.litresDispensed * 1.18f;
                    this.UnleadedDispensed = this.litresDispensed;
                    break;

                case "LPG":
                    //0.58 is the price of LPG
                    this.totalGains = this.litresDispensed * 0.58f;
                    this.LPGDispensed1 = this.litresDispensed;
                    break;
            }

            //0.01% comission
            this.comission = totalGains * 0.01f;

            //setup loop flags for future loop reference
            this.loopFlag = _loopFlag;
            this.TransactionLoopFlag = false;
        }
        #endregion
    }
}
