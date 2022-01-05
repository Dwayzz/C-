//Dillon Waisner
//12/6/21

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform_Calculator
{
    public partial class MultiplyDivideForm : Form
    {


        public MultiplyDivideForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Converting Textboxes into a double value
            double TextBox1 = Convert.ToDouble(firstNumberTextBox.Text);
            double TextBox2 = Convert.ToDouble(secondNumberTextBox.Text);

            //The math 
            double sum = TextBox1 * TextBox2;

            //The sum of the math put into the resultLabel displayed as text
            resultLabel.Text = sum.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            //Converting Textboxes into a double value
            double TextBox1 = Convert.ToDouble(firstNumberTextBox.Text);
            double TextBox2 = Convert.ToDouble(secondNumberTextBox.Text);

            //The math 
            double sum = TextBox1 / TextBox2;

            //The sum of the math put into the resultLabel displayed as text
            resultLabel.Text = sum.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
