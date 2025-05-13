// Program:     AstroData
//
// Description: A Forms application that will receive data input and display
//              the data in a list box, with options to sort the data, and search
//              for a specific value based on user input. There will also be buttons
//              for a sequential search, and four mathematical operations that will
//              show the user the mid-extreme, mode, average, and range of the data.
//
// Author:      Robert Sewell
//
// Team Name:   AstroData Team
//
// Sprint #:    2
//
// Date:        08 / 05 / 2025
//
// Version:     0.2



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
using System.Diagnostics.Eventing.Reader;
using System.Xml.Schema;



namespace AstroData
{



    public partial class AstroDataForm : Form
    {



        public AstroDataForm()
        {
            InitializeComponent();
        }



        // Start of Global variables area

        // This is where we declare the global variable that will control the max number of values
        // that can be in our array of astrometric data
        static int dataValueQty = 20;

        // This is where we declare our array of astrometric data
        int[] dataArray = new int[dataValueQty];

        // This array tracks the filled positions of dataArray
        bool[] isFilledArray = new bool[dataValueQty]; 

        // This is the variable that will be used to delete things from our array
        int delVal = 0;

        // End of Global variables area



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
                dataArray[i] = randValue.Next(1, 101);
                isFilledArray[i] = true;
            }

            // Then the array will be displayed in the listbox named "ListBoxData" via a 
            // for loop
            DisplayDataArray();

        } // End of Random Data button method



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
            ListBoxData.Items.Clear();
            // This for loop iterates through and prints each line of the array to the listbox
            for (int i = 0; i < dataValueQty; i++)
            {
                ListBoxData.Items.Add($"{i + 1}.            {dataArray[i]}");
            }

        } // End of DisplayDataArray method



        // Binary search method
        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {
            int mid;
            int lowBound = 0;
            int highBound = dataValueQty - 1;
            int target = 0;

            if (!Int32.TryParse(TextBoxSearch.Text, out target)) {
                MessageBox.Show("You must enter an Integer.", "Error message (Binary search method)");
                return;
            }

            // This if statement checks to make sure that the value being searched is in the
            // range of the data and returns an error message if it isn't
            if (target < dataArray[0] || target > dataArray[highBound])
            {
                DisplayDataArray();
                MessageBox.Show("Target is outside the range of the data.", "Error message (Binary search method)");
                TextBoxSearch.Clear();
                return;
            }

            while ((lowBound <= highBound))
            {
                // Display data
                DisplayDataArray();

                // Find mid point
                mid = (lowBound + highBound) / 2;

                if (dataArray[mid] == target)
                {
                    // Target found
                    ListBoxData.Items.Add("Found at index " + (mid + 1));
                    ListBoxData.SetSelected(mid, true);
                    return;
                }
                else if (dataArray[mid] >= target)
                {
                    highBound = mid - 1;
                }
                else
                {
                    lowBound = mid + 1;
                }

                // Clear the search box once data is found
                TextBoxSearch.Clear();
            }
            MessageBox.Show("Target value not found.", "Error message (Binary search method)");

        } // End of binary search method



        // Method to prevent non numeric inputs in the TextBoxDataInput
        private void TextBoxDataInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && !char.IsControl(ch))
            {
                e.Handled = true;
            }

        } // End of method to prevent non numeric inputs in TextBoxDataInput



        // Data input method
        private void ButtonInputData_Click(object sender, EventArgs e)
        {
            int inputVal;
            if (!int.TryParse(TextBoxInputData.Text, out inputVal))
            {
                MessageBox.Show("You must enter a valid integer.", "Error message (Input error)");
                TextBoxInputData.Clear();
                TextBoxInputData.Focus();
                return;
            }

            if (ListBoxData.SelectedIndex != -1 && ListBoxData.SelectedItem != null)
            {
                string currIndexInput = ListBoxData.SelectedItem.ToString();
                int indxInput = ListBoxData.FindString(currIndexInput);

                    dataArray[indxInput] = inputVal;
                    isFilledArray[indxInput] = true;
                    Array.Sort(dataArray, 0, indxInput);
                    DisplayDataArray();

                    // Clear the text box
                    TextBoxInputData.Clear();
            }

        } // End of Data input method



        // Data delete method
        private void ButtonDeleteData_Click(object sender, EventArgs e)
        {
            if (!(ListBoxData.SelectedIndex == -1))
            {
                string currIndexDel = ListBoxData.SelectedItem.ToString();
                int indxDel = ListBoxData.FindString(currIndexDel);
                dataArray[indxDel] = dataArray[delVal];
                dataArray[delVal] = 0;
                isFilledArray[delVal] = false;
                Array.Sort(dataArray, 0, delVal);
                DisplayDataArray();
            }
            else
            {
                MessageBox.Show("Select an item for deletion from the data", "Error message (Delete method)");
            }

        } // End of data delete method



        // Mid-extreme method
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            // These two variables determine and store the smallest and largest value
            float minValMidEx = dataArray.Min();
            float maxValMidEx = dataArray.Max();

            // This variable gets the sum of the smallest and largest value, adds them together,
            // and then divides them by two to get the Mid-extreme
            float resMidEx = (minValMidEx + maxValMidEx) / 2;

            // This is where we display our result in a text box that is formatted to two
            // decimal places
            TextBoxMidExtreme.Text = resMidEx.ToString("N2");

        } // End of Mid-extreme method



        // Mode method
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            // Here we declare a variable that searches the array for each occurence of each
            // value and groups them together, then sorting the groups so that the group with the
            // greatest value is the first in the order, and returning that value as the mode.
            int mode = dataArray.GroupBy(arrayVal => arrayVal)
                                .OrderByDescending(valGroup => valGroup.Count())
                                .First()
                                .Key;

            // This is where we display the mode in a text box
            TextBoxMode.Text = mode.ToString();

        }// End of Mode method



        // Average method
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            float arraySizeFlt = 20;
            float averageSum = (dataArray.Sum() / arraySizeFlt);

            TextBoxAverage.Text = averageSum.ToString("N2");

        } // End of Average method



        // Range method
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            // These variable will determine the smallest and largest values in the data array
            float rangeSmall = dataArray.Min();
            float rangeLarge = dataArray.Max();

            float rangeFinal = rangeLarge - rangeSmall;

            TextBoxRange.Text = rangeFinal.ToString("N2");

        } // End of Range method



        // Sequential search method
        private void buttonSequentialSearch_Click(object sender, EventArgs e)
        {
            int sqsTarget;
            bool sqsFound = false;

            DisplayDataArray();

            if (!(Int32.TryParse(TextBoxSearch.Text, out sqsTarget)))
            {
                MessageBox.Show("You must enter an Integer.", "Error message (Sequential search method)");
                return;
            }

            for (int arryVal = 0; arryVal < dataValueQty; arryVal++)
            {
                if (dataArray[arryVal] == sqsTarget)
                {
                    ListBoxData.Items.Add("Found at index " + (arryVal + 1));
                    sqsFound = true;
                    ListBoxData.SetSelected(arryVal, true);
                    TextBoxSearch.Clear();
                    return;
                }
            }

            if (!sqsFound)
            {
                MessageBox.Show("Value was not found in the data.");
                TextBoxSearch.Clear();
            }



        } // End of Sequential search method



    } // End of partial public class AstroDataForm : Form



} // End of namespace AstroData
