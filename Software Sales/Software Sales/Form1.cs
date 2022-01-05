// Dillon Waisner //
// 10-08-2021 //
// Software Sales //



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class discountCalculator : Form
    {
     
        public discountCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int packageAmount; //declaring a variable

            //converting the string into an integer
            if (int.TryParse(totalPackages.Text, out packageAmount) && packageAmount >= 0)
            {

                //$99 is the total cost of the package without a discount
                const double totalPackagePrice = 99.00;

                const double quantity2 = 0.20;
                const double quantity3 = 0.30;
                const double quantity4 = 0.40;
                const double quantity5 = 0.50;

                //if the total amount of software packages purchased is less then 10
                if (packageAmount < 10)
                {

                    int totalDiscount = 0;
                    double totalBeforeDiscount = packageAmount * totalPackagePrice;
                    double finalPrice = totalBeforeDiscount - totalDiscount;

                    ////Converting these text boxes into strings as well as formating someto "C"(currency)
                    discountPercent.Text = totalDiscount.ToString();
                    totalSaved.Text = totalDiscount.ToString("c");
                    finalPricetxt.Text = finalPrice.ToString("c");

                }

                //if the total amount of software packages purchased is more then 10 and less then 19
                else if (packageAmount >= 10 && packageAmount <= 19)

                {
                    //percent total 
                    int discountPercentTotal = 20;

                    double totalBeforeDiscount = packageAmount * totalPackagePrice;
                    double totalDiscount = totalBeforeDiscount *quantity2;
                    double finalPrice = totalBeforeDiscount - totalDiscount;

                    discountPercent.Text = discountPercentTotal.ToString();
                    totalSaved.Text = totalDiscount.ToString("c");
                    finalPricetxt.Text = finalPrice.ToString("c");


                }

                //if the total amount of software packages purchased is more then 20 and less then 49
                else if (packageAmount >= 20 && packageAmount <= 49)

                {
                    int discountPercentTotal = 30;

                    double totalBeforeDiscount = packageAmount * totalPackagePrice;
                    double totalDiscount = totalBeforeDiscount * quantity3;
                    double finalPrice = totalBeforeDiscount - totalDiscount;

                    discountPercent.Text = discountPercentTotal.ToString();
                    totalSaved.Text = totalDiscount.ToString("c");
                    finalPricetxt.Text = finalPrice.ToString("c");


                }

                //if the total amount of software packages purchased is more then 50 and less then 99
                else if (packageAmount >= 50 && packageAmount <= 99)
                    

                {
                    int discountPercentTotal = 40;

                    double totalBeforeDiscount = packageAmount * totalPackagePrice;
                    double totalDiscount = totalBeforeDiscount * quantity4;
                    double finalPrice = totalBeforeDiscount - totalDiscount;

                    discountPercent.Text = discountPercentTotal.ToString();
                    totalSaved.Text = totalDiscount.ToString("c");
                    finalPricetxt.Text = finalPrice.ToString("c");


                }

                //if the total amount of software packages purchased is more then 100 and less then 150
                else if (packageAmount >= 100 && packageAmount <= 150)

                {
                    int discountPercentTotal = 50;
                    double totalBeforeDiscount = packageAmount * totalPackagePrice;
                    double totalDiscount = totalBeforeDiscount * quantity5;
                    double finalPrice = totalBeforeDiscount - totalDiscount;

                    discountPercent.Text = discountPercentTotal.ToString();
                    totalSaved.Text = totalDiscount.ToString("c");
                    finalPricetxt.Text = finalPrice.ToString("c");


                }
            }

            else
            { 
                //message box displaying a string when inputing alphabetic inputs, after pressing ok input fields erase. 
                MessageBox.Show("Invalid Data");
                    totalPackages.Clear();
                    totalPackages.Focus();               
            }
        }









        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void discountCalculator_Load(object sender, EventArgs e)
        {

        }


        private void totalPackages_TextChanged(object sender, EventArgs e)
        {


        }

        private void discountPercent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
