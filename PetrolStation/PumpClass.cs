using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class PumpClass
    {
        //variable declaration
        #region
        private string pumpStatus;
        private bool pumbAvailable;

        public string PumpStatus
        {
            get
            {
                return pumpStatus;
            }

            set
            {
                pumpStatus = value;
            }
        }

        public bool PumbAvailable
        {
            get
            {
                return pumbAvailable;
            }

            set
            {
                pumbAvailable = value;
            }
        }
        #endregion

        //Constructor
        #region
        public PumpClass(string valueOne)
        {
            this.pumpStatus = valueOne;
            this.pumbAvailable = true;
        }
        #endregion

        /// <summary>
        /// Method that automates the selection of the pump
        /// </summary>
        /// <param name="arrayPumps"></param>
        /// <returns>Returns the available and selected pump number</returns>
        public static int ChangePumpStatus(PumpClass[] arrayPumps)
        {
            int Input = 0;

            if (arrayPumps[0].PumpStatus == "Free")
            {
                if (arrayPumps[1].PumpStatus == "Free")
                {
                    if (arrayPumps[2].PumpStatus == "Free")
                    {
                        return Input = 3;
                    }
                    return Input = 2;
                }
                return Input = 1;
            }

            //check the second line
            if (arrayPumps[3].PumpStatus == "Free")
            {
                if (arrayPumps[4].PumpStatus == "Free")
                {
                    if (arrayPumps[5].PumpStatus == "Free")
                    {
                        return Input = 6;
                    }
                    return Input = 5;
                }
                return Input = 4;
            }

            //check the third line
            if (arrayPumps[6].PumpStatus == "Free")
            {
                if (arrayPumps[7].PumpStatus == "Free")
                {
                    if (arrayPumps[8].PumpStatus == "Free")
                    {
                        return Input = 9;
                    }
                    return Input = 8;
                }
                return Input = 7;
            }

            return Input;
        }
    }
}
