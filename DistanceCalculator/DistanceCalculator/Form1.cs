//Dillon Waisner
//10/19/2021
//Lesson 5 Distance Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceCalculator
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            //loads form 
            InitializeComponent();
        }

        private void DistanceCalculator_Load(object sender, EventArgs e)
        {

        }

        private void mphTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //function that clears everything in the list box before each run
            totalDistancesListBox.Items.Clear();

            //setting integer values
            int speed,
                hours,
                distance;

            //two TryParse methods for hours and speed
            if (int.TryParse(hoursTextBox.Text, out hours) && int.TryParse(mphTextBox.Text, out speed) && hours >= 1 && speed >= 1)

            {
                for (int count = 1; count <= hours; count++)
                {
                    //formula used for the math
                    distance = speed * count;

                    //adding everything together
                    totalDistancesListBox.Items.Add(" After hour " + count + " the distance is " + distance + " miles ");

                }
            }
            else
            {
                //pop up message for bad speed data and hour data
                MessageBox.Show("Invalid Speed Input.");

                totalDistancesListBox.Items.Clear();
                hoursTextBox.Clear();
                mphTextBox.Clear();
                mphTextBox.Focus();
      

                MessageBox.Show("Invalid Hours Input.");
                totalDistancesListBox.Items.Clear();
                hoursTextBox.Clear();
                mphTextBox.Clear();
                mphTextBox.Focus();

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit button closes program on click
            this.Close();
        }
    }
}
