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
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();

            //create the categories the data will go into
            listBox1.Items.Add("Pump Number    " + "Vehicle    " + "Litres Dispensed    " + "Fuel Type");


        }

        //Runs when the user clicks to refresh the list box
        private void callUpdate_Click(object sender, EventArgs e)
        {
            //runt the method to get the data
            PetrolStation.GetListBoxData();

            //clear the listbox to prevent repeat entries
            listBox1.Items.Clear();
            listBox1.Items.Add("Pump Number    " + "Vehicle    " + "Litres Dispensed    " + "Fuel Type");


            //loop that adds the data to the list box
            for (int i = 0; i < PetrolStation.listBoxData.Count; i++)
            {
                listBox1.Items.Add(PetrolStation.listBoxData[i]);
            }
        }
    }
}
