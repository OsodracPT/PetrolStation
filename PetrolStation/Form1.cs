using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolStation
{

    public partial class PetrolStation : Form
    {
        //array of pumps declaration
        private PumpClass[] arrayPumps = new PumpClass[9];


        //variables that store the vehicle object data
        public string vehicleFuel = "";
        public string vehicleType = "";
        public int currentFuel = 0;
        public int emptyTank = 0;

        //declaration of a new object that will hold the data of a spawned car
        Vehicle myCar = new Vehicle();

        //Indexes to keep track of the pumps that are realy busy and not just obstructed
        public int pumpIndex1 = 0;
        public int pumpIndex2 = 0;
        public int pumpIndex3 = 0;
        public int pumpIndex4 = 0;
        public int pumpIndex5 = 0;
        public int pumpIndex6 = 0;
        public int pumpIndex7 = 0;
        public int pumpIndex8 = 0;
        public int pumpIndex9 = 0;

        //declaring a list of transactions
        private static List<Transaction> transactionList = new List<Transaction>();

        //declaring a list to hold the transaction data and later print it to the user
        public static List<string> listBoxData = new List<string>();

        //declaring the first state of the counter
        private Counters myCounter = new Counters(0, 0, 0);

        //raise flag if all the pumps are busy
        public bool noPumpFlag = false;

        //Random number to create random vehicle carachteristics; name and fuel type
        public Random _RandomName = new Random();
        public Random randomFuelType = new Random();

        public PetrolStation()
        {


            //start the program by setting all the pumps to a free status
            arrayPumps[0] = new PumpClass("Free");
            arrayPumps[1] = new PumpClass("Free");
            arrayPumps[2] = new PumpClass("Free");
            arrayPumps[3] = new PumpClass("Free");
            arrayPumps[4] = new PumpClass("Free");
            arrayPumps[5] = new PumpClass("Free");
            arrayPumps[6] = new PumpClass("Free");
            arrayPumps[7] = new PumpClass("Free");
            arrayPumps[8] = new PumpClass("Free");


            InitializeComponent();
        }

        //this timer runs everytime a vehicle spawns. the interval is random
        private void timer1_Tick(object sender, EventArgs e)
        {
            //create a random vehicle with random properties
            SpawnedVehicleCreator();

            if (listBoxData.Count > 0)
            {
                Console.WriteLine(listBoxData[0]);
            }

            //Creating a random number to change the timer interval everytime it runs
            Random timerRandom = new Random();
            timer1.Interval = timerRandom.Next(1500, 2200);

            SelectAvailablePump();

            /*check if all the pumps are busy
            if not then no vehicle should be waiting
            disable vehicle wait timer
             */
            if (noPumpFlag == false)
            {
                vehicleWaitTimer.Enabled = false;
            }

            //get the time the pump will take to fuel the vehicle
            GetPumpTimer();

            //for debug purposes
            Console.WriteLine(Convert.ToInt32(GetPumpTimer()));

            //start the timer of the pump the car just chose
            StartPumpTimers();

            //Update the display for the user
            UpdatePumpDisplay();


        }

        /// <summary>
        /// this method runs everytime a vehicle spawns
        /// it creates a vehicle with random properties
        /// </summary>
        public void SpawnedVehicleCreator()
        {
            //getting a random vehicle type from the vehicle class
            vehicleType = myCar.TypesAvailable[_RandomName.Next(0, myCar.TypesAvailable.Length)];

            //if its a car then all the fuels are available
            if (vehicleType == "Car")
            {
                //get a random fuel type
                vehicleFuel = myCar.fuelType[randomFuelType.Next(0, 3)];
            }
            //if its a van than only LPG and diesel are available
            else if (vehicleType == "Van")
            {
                //get a random fuel type
                vehicleFuel = myCar.fuelType[randomFuelType.Next(0, 2)];
            }
            //if its a HGV than only diesel fuel is available
            else if (vehicleType == "HGV")
            {
                vehicleFuel = "Diesel";
            }

            //creating a new object to hold the newly created vehicle data
            Vehicle _newCar = new Vehicle(vehicleType, vehicleFuel);

            //getting the values for the fuel ammount from a random creator present in the vehicle class
            currentFuel = _newCar.FuelAmount;
            emptyTank = _newCar.EmptyTank;

            //debug purposes
            Console.WriteLine(vehicleType + " " + vehicleFuel + " " + currentFuel + " " + emptyTank);
        }

        /// <summary>
        /// Method that automates which pump should be selected by a spawn car
        /// and changes its status to Busy
        /// if output is 0 then all the pumps are filled
        /// </summary>
        public int SelectAvailablePump()
        {
            //variable the will hold the pump number selected by automation
            int output;
            output = PumpClass.ChangePumpStatus(arrayPumps);

            //change the selected pump to a busy status
            switch (output)
            {
                case 1:

                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(1, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();

                    return output;

                case 2:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(2, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                case 3:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(3, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                case 4:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(4, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                case 5:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(5, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                case 6:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(6, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();

                    return output;

                case 7:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(7, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                case 8:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(8, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                case 9:
                    arrayPumps[output - 1].PumpStatus = "Busy";
                    //add the transaction data to the list
                    transactionList.Add(new Transaction(9, emptyTank, vehicleType, vehicleFuel, false));

                    VehicleLeftDecrement();
                    return output;

                default:
                    Console.WriteLine("All Pumps are busy.");

                    noPumpFlag = true;
                    //if all the pumps are busy than a queue of vehicles will start 
                    vehicleWaitTimer.Enabled = true;

                    //the queue of waiting vehicles cant be greater than 5
                    if (myCounter.VehiclesWaiting < 5)
                    {
                        Console.WriteLine(myCounter.VehiclesWaiting);
                        myCounter.VehiclesWaiting = myCounter.VehiclesWaiting + 1;
                        Console.WriteLine(myCounter.VehiclesWaiting);

                        //update the user display
                        vehiclesWaiting.Text = myCounter.VehiclesWaiting.ToString();
                    }
                    //stop spawning vehicles if there are more than 5 vehicles waiting
                    else if (myCounter.VehiclesWaiting >= 5)
                    {
                        timer1.Enabled = false;
                    }

                    return output;

            }

        }

        /// <summary>
        /// This Method changes the pumps pictures according to its state and the car its has in
        /// </summary>
        public void ChangePictureBox()
        {

            if (arrayPumps[0].PumpStatus == "Busy" && pictureBox1.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }

            if (arrayPumps[1].PumpStatus == "Busy" && pictureBox2.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox2.Visible = true;
                        pictureBox2.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox2.Visible = true;
                        pictureBox2.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox2.Visible = true;
                        pictureBox2.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }

            if (arrayPumps[2].PumpStatus == "Busy" && pictureBox3.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox3.Visible = true;
                        pictureBox3.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox3.Visible = true;
                        pictureBox3.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox3.Visible = true;
                        pictureBox3.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }

            if (arrayPumps[3].PumpStatus == "Busy" && pictureBox4.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox4.Visible = true;
                        pictureBox4.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox4.Visible = true;
                        pictureBox4.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox4.Visible = true;
                        pictureBox4.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }
            if (arrayPumps[4].PumpStatus == "Busy" && pictureBox5.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox5.Visible = true;
                        pictureBox5.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox5.Visible = true;
                        pictureBox5.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox5.Visible = true;
                        pictureBox5.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }

            if (arrayPumps[5].PumpStatus == "Busy" && pictureBox6.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox6.Visible = true;
                        pictureBox6.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox6.Visible = true;
                        pictureBox6.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox6.Visible = true;
                        pictureBox6.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }
            if (arrayPumps[6].PumpStatus == "Busy" && pictureBox7.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox7.Visible = true;
                        pictureBox7.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox7.Visible = true;
                        pictureBox7.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox7.Visible = true;
                        pictureBox7.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }
            if (arrayPumps[7].PumpStatus == "Busy" && pictureBox8.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox8.Visible = true;
                        pictureBox8.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox8.Visible = true;
                        pictureBox8.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox8.Visible = true;
                        pictureBox8.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }

            if (arrayPumps[8].PumpStatus == "Busy" && pictureBox9.Visible == false)
            {
                switch (vehicleType)
                {
                    case "Car":
                        pictureBox9.Visible = true;
                        pictureBox9.BackgroundImage = Properties.Resources.car_xxl;
                        break;

                    case "Van":
                        pictureBox9.Visible = true;
                        pictureBox9.BackgroundImage = Properties.Resources.van;
                        break;

                    case "HGV":
                        pictureBox9.Visible = true;
                        pictureBox9.BackgroundImage = Properties.Resources.hgv;
                        break;
                }
            }
        }

        /// <summary>
        /// Method that calculates how much time the pump will take to fuel the vehicle
        /// </summary>
        /// <returns>returns the timer interval</returns>
        public float GetPumpTimer()
        {
            float timerInterval = 0;
            switch (vehicleType)
            {
                case "Car":
                    timerInterval = 40 - currentFuel;
                    //1.5 is the litres dispensed per second
                    timerInterval = timerInterval / 1.5f;
                    //times 1000 for miliseconds
                    timerInterval = timerInterval * 1000;
                    return timerInterval;

                case "Van":
                    timerInterval = 80 - currentFuel;
                    //1.5 is the litres dispensed per second
                    timerInterval = timerInterval / 1.5f;
                    //times 1000 for miliseconds
                    timerInterval = timerInterval * 1000;
                    return timerInterval;

                case "HGV":
                    timerInterval = 150 - currentFuel;
                    //1.5 is the litres dispensed per second
                    timerInterval = timerInterval / 1.5f;
                    //times 1000 for miliseconds
                    timerInterval = timerInterval * 1000;
                    return timerInterval;
            }
            return timerInterval;
        }

        /// <summary>
        /// Method that checks which Pump just got busy and starts the pump timer
        /// </summary>
        private void StartPumpTimers()
        {
            if (arrayPumps[0].PumpStatus == "Busy" && pumpIndex1 < 1)
            {
                pump1Timer.Interval = Convert.ToInt32(GetPumpTimer());
                pump1Timer.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex1++;
            }

            if (arrayPumps[1].PumpStatus == "Busy" && pumpIndex2 < 1)
            {
                pump2Timer.Interval = Convert.ToInt32(GetPumpTimer());
                pump2Timer.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex2++;
            }

            if (arrayPumps[2].PumpStatus == "Busy" && pumpIndex3 < 1)
            {
                pumpTimer3.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer3.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex3++;
            }

            if (arrayPumps[3].PumpStatus == "Busy" && pumpIndex4 < 1)
            {
                pumpTimer4.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer4.Enabled = true;
                pumpIndex4++;
            }
            if (arrayPumps[4].PumpStatus == "Busy" && pumpIndex5 < 1)
            {
                pumpTimer5.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer5.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex5++;
            }
            if (arrayPumps[5].PumpStatus == "Busy" && pumpIndex6 < 1)
            {
                pumpTimer6.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer6.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex6++;
            }
            if (arrayPumps[6].PumpStatus == "Busy" && pumpIndex7 < 1)
            {
                pumpTimer7.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer7.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex7++;
            }
            if (arrayPumps[7].PumpStatus == "Busy" && pumpIndex8 < 1)
            {
                pumpTimer8.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer8.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex8++;
            }
            if (arrayPumps[8].PumpStatus == "Busy" && pumpIndex9 < 1)
            {
                pumpTimer9.Interval = Convert.ToInt32(GetPumpTimer());
                pumpTimer9.Enabled = true;
                //index to keep track if the pump has really a car in it or is just obstructed
                pumpIndex9++;
            }
        }

        /// <summary>
        /// Method that updated the pumps text and pictures for the user to see in realtime 
        /// </summary>
        public void UpdatePumpDisplay()
        {
            ChangePictureBox();

            pump1.Text = arrayPumps[0].PumpStatus;
            pump2.Text = arrayPumps[1].PumpStatus;
            pump3.Text = arrayPumps[2].PumpStatus;
            pump4.Text = arrayPumps[3].PumpStatus;
            pump5.Text = arrayPumps[4].PumpStatus;
            pump6.Text = arrayPumps[5].PumpStatus;
            pump7.Text = arrayPumps[6].PumpStatus;
            pump8.Text = arrayPumps[7].PumpStatus;
            pump9.Text = arrayPumps[8].PumpStatus;
        }

        //All the Pump timers
        #region
        private void pump1Timer_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");

            //update the user display counter
            UpdateCounter(1);

            //change the pump status to free
            arrayPumps[0].PumpStatus = "Free";
            //update the display
            pump1.Text = arrayPumps[0].PumpStatus;
            //remove the vehicle picture
            pictureBox1.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex1 = 0;
        }

        private void pump2Timer_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");

            //update the user display counter
            UpdateCounter(2);

            //change the pump status to free
            arrayPumps[1].PumpStatus = "Free";
            //update the display
            pump2.Text = arrayPumps[1].PumpStatus;
            //remove the vehicle picture
            pictureBox2.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex2 = 0;
        }

        private void pumpTimer3_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");

            //update the user display counter
            UpdateCounter(3);

            //change the pump status to free
            arrayPumps[2].PumpStatus = "Free";
            //update the display
            pump3.Text = arrayPumps[2].PumpStatus;
            //remove the vehicle picture
            pictureBox3.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex3 = 0;
        }

        private void pumpTimer4_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");

            //update the user display counter
            UpdateCounter(4);

            //change the pump status to free
            arrayPumps[3].PumpStatus = "Free";
            //update the display
            pump4.Text = arrayPumps[3].PumpStatus;
            //remove the vehicle picture
            pictureBox4.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex4 = 0;
        }

        private void pumpTimer5_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");
            //update the user display counter
            UpdateCounter(5);
            //change the pump status to free
            arrayPumps[4].PumpStatus = "Free";
            //update the display
            pump5.Text = arrayPumps[4].PumpStatus;
            //remove the vehicle picture
            pictureBox5.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex5 = 0;
        }

        private void pumpTimer6_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");
            //update the user display counter
            UpdateCounter(6);
            //change the pump status to free
            arrayPumps[5].PumpStatus = "Free";
            //update the display
            pump6.Text = arrayPumps[5].PumpStatus;
            //remove the vehicle picture
            pictureBox6.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex6 = 0;

        }

        private void pumpTimer7_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");
            //update the user display counter
            UpdateCounter(7);
            //change the pump status to free
            arrayPumps[6].PumpStatus = "Free";
            //update the display
            pump7.Text = arrayPumps[6].PumpStatus;
            //remove the vehicle picture
            pictureBox7.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex7 = 0;

        }

        private void pumpTimer8_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");
            //update the user display counter
            UpdateCounter(8);
            //change the pump status to free
            arrayPumps[7].PumpStatus = "Free";
            //update the display
            pump8.Text = arrayPumps[7].PumpStatus;
            //remove the vehicle picture
            pictureBox8.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex8 = 0;
        }

        private void pumpTimer9_Tick(object sender, EventArgs e)
        {
            //debug purposes
            Console.WriteLine("Vehicle left");

            //update the user display counter
            UpdateCounter(9);

            //change the pump status to free
            arrayPumps[8].PumpStatus = "Free";
            //update the display
            pump9.Text = arrayPumps[8].PumpStatus;
            //remove the vehicle picture
            pictureBox9.Visible = false;
            //index goes back to 0 because there is no car present
            pumpIndex9 = 0;
        }
        #endregion

        /// <summary>
        /// Method that adds the transaction to the counter in the form in order to display to the user
        /// </summary>
        /// <param name="pumpNumber">takes in the pump number</param>
        public void UpdateCounter(int pumpNumber)
        {
            for (int i = 0; i < transactionList.Count; i++)
            {
                if (transactionList[i].PumpNumber == pumpNumber && transactionList[i].LoopFlag == false)
                {
                    //update the flag so the loop wont add this transaction again to the counter
                    transactionList[i].LoopFlag = true;

                    //increment values and add them to the counter
                    myCounter.Comission += transactionList[i].Comission;
                    myCounter.TotalGains += transactionList[i].TotalGains;
                    myCounter.LitresDispensed += transactionList[i].LitresDispensed;
                    myCounter.DieselDispensed += transactionList[i].DieselDispensed;
                    myCounter.UnleadedDispensed += transactionList[i].UnleadedDispensed;
                    myCounter.LPGDispensed1 += transactionList[i].LPGDispensed1;

                    counterLitres.Text = myCounter.LitresDispensed.ToString();
                    counterDiesel.Text = myCounter.DieselDispensed.ToString();
                    counterUnleaded.Text = myCounter.UnleadedDispensed.ToString();
                    counterLPG.Text = myCounter.LPGDispensed1.ToString();

                    counterGains.Text = "£" + myCounter.TotalGains.ToString("0.00");
                    counterComission.Text = "£" + myCounter.Comission.ToString("0.00");
                    myCounter.VehiclesServiced = myCounter.VehiclesServiced + 1;

                    vehiclesServiced.Text = myCounter.VehiclesServiced.ToString();
                    vehicleLeft.Text = myCounter.VehiclesLeft.ToString();
                    vehiclesWaiting.Text = myCounter.VehiclesWaiting.ToString();
                }
            }
        }

        /// <summary>
        /// This Timer starts when all the pumps are busy and the vehicle start forming a queue
        /// It then ticks everytime a vehicle leaves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vehicleWaitTimer_Tick(object sender, EventArgs e)
        {
            //Creating a random number to change the timer interval everytime it runs
            Random timerRandom = new Random();
            vehicleWaitTimer.Interval = timerRandom.Next(1000, 2000);

            //debug purposes
            Console.WriteLine("Tired of waiting a vehicle just left");

            //remove a vehicle from the counter
            if (myCounter.VehiclesWaiting > 0)
            {
                myCounter.VehiclesWaiting = myCounter.VehiclesWaiting - 1;
            }

            //update the user display counter
            vehiclesWaiting.Text = myCounter.VehiclesWaiting.ToString();
            myCounter.VehiclesLeft = myCounter.VehiclesLeft + 1;
            vehicleLeft.Text = myCounter.VehiclesLeft.ToString();

            //check if the timer 1 was disabled (Happens when the queue is greater than 5)
            //turn it on if that happened
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }

            //disable the timer 
            vehicleWaitTimer.Enabled = false;

        }

        // This will run everytime the user clicks in order to open the transaction window
        public void transactionButton_Click(object sender, EventArgs e)
        {

            TransactionForm TransactionForm = new TransactionForm();

            TransactionForm.Show();

        }

        /// <summary>
        /// This Method gets the data from the transactions and adds it to a List box data to print it to the user
        /// </summary>
        public static void GetListBoxData()
        {
            //loops the transaction list and adds its data to the list box data
            for (int i = 0; i < PetrolStation.transactionList.Count; i++)
            {
                if (PetrolStation.transactionList[i].LoopFlag == true && PetrolStation.transactionList[i].TransactionLoopFlag == false)
                {
                    //this flags prevents the loop from going through the same index again
                    PetrolStation.transactionList[i].TransactionLoopFlag = true;

                    //convert the data to a string for display purposes
                    listBoxData.Add(Convert.ToString("         " + PetrolStation.transactionList[i].PumpNumber +
                        "                " + PetrolStation.transactionList[i].VehicleType +
                        "                 " + PetrolStation.transactionList[i].LitresDispensed +
                        "                    " + PetrolStation.transactionList[i].VehicleFuelType));
                }
            }


        }

        /// <summary>
        /// Method that decrements the vehicle waiting queue
        /// </summary>
        public void VehicleLeftDecrement()
        {
            //if there is any vehicle waiting
            // then decrement 1 value because a vehicle just got served                   
            if (myCounter.VehiclesWaiting > 0)
            {
                myCounter.VehiclesWaiting = myCounter.VehiclesWaiting - 1;
            }
        }
    }
}

