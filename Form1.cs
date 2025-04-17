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
        static int numbOfDataValues = 20;

        // This is where we declare our array of astrometric data
        int[] dataArray = new int[numbOfDataValues];



        private void ButtonRandomData_Click(object sender, EventArgs e)
        {
            // Here we will create a random number to add to our array of data values,
            // and we will do this until the array has the max number of entries.


        }



    }
}
