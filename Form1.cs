using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Added threading for timing options
using System.Threading;
using System.Runtime.CompilerServices;



namespace AstroData
{
    public partial class AstroDataForm : Form
    {



        public AstroDataForm()
        {
            InitializeComponent();
        }



        // This is where we declare the global variable that will control the max number of values
        // that can be in our array of astrometric data
        static int dataValueQty = 20;

        // This is where we declare our array of astrometric data
        int[] dataArray = new int[dataValueQty];



        // This is the method that runs when we click the Get Astrometric Data button
        private void ButtonRandomData_Click(object sender, EventArgs e)
        {
            // Clear any previous data that was written to the list box
            ListBoxData.Items.Clear();

            // Here we will create a random number to add to our array of data values,
            // and we will do this until the array has the max number of entries.
            Random randValue = new Random();
            
            // This is the for loop that will add random values to 'dataArray' until it is full
            for (int i = 0; i < dataValueQty; i++)
            {
                dataArray[i] = randValue.Next(100);
            }

            // Then the array will be displayed in the listbox named "ListBoxData" via a 
            // for loop
            DisplayDataArray();

        }// End of Random Data button method



        // This is the method that runs when we click the Bubble Sort button
        private void ButtonBubbleSort_Click(object sender, EventArgs e)
        {
            // Here we declare a variable to store the value of the array that is being reorganised
            int arrayValueStorage = 0;

            // This is the for loop that will organise our array of values
            for (int outer = 0; outer < dataValueQty; outer++)
            {
                for (int inner = 0;  inner < dataValueQty - 1; inner++)
                {
                    if (dataArray[inner] > dataArray[inner + 1])
                    {
                        // This is the routine that moves the values around in the array
                        arrayValueStorage = dataArray[inner + 1];
                        dataArray[inner + 1] = dataArray[inner];
                        dataArray[inner] = arrayValueStorage;
                    }

                    // Clear any previous data that was written to the listbox
                    ListBoxData.Items.Clear();

                    // Call the DisplayDataArray method to show the values on the listbox
                    DisplayDataArray();
                    Application.DoEvents();
                    // Thread.Sleep(50);
                }
            }
        } // End of Bubble Sort button method



        // Method to display the array in the listbox
        private void DisplayDataArray()
        {
            // This for loop iterates through and prints each line of the array to the listbox
            for (int i = 0; i < dataValueQty; i++)
            {
                ListBoxData.Items.Add($"{i + 1}.            {dataArray[i]}");
            }
        } // End of DisplayDataArray method



    }
}
