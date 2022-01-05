//Dillon Waisner
//11/9/2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void checkButton_Click(object sender, EventArgs e)
        {
            //clear result label
            popularityLabel.Text = "";

            //try catch for file not found exception
            try
            {
                //Empty input test
                if (nameTextBox.Text == "")
                {
                    popularityLabel.Text = "No input provided";
                }
                else
                {
                    //Getting the names folder 
                    string[] names = new string[400];
                    int i = 0;
                    string path = @"E:\ITSE 1330 C#\Homework Assignments\Lesson 7\Name Search\Name Search\bin\Debug\Names.txt";

                    {
                        string n = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            names[i] = n;
                            i++;
                        }
                    }
                    bool check = false;
                    //name and display result
                    for (i = 0; i < names.Length; i++)
                    {
                        if (names[i] == nameTextBox.Text)
                        {
                            popularityLabel.Text = "This IS a popular name!";
                            check = true;
                            break;
                        }
                    }
                    //If name isnt in list then text saying sorrt not pop name
                    if (!check)
                    {
                        popularityLabel.Text = "Sorry, this IS NOT a popular name!";
                    }
                }
                nameTextBox.Select();
                }
            //handling filenotfoundexceptions 
                   catch (FileNotFoundException e)
                {
                popularityLabel.Text = ex.FileName + " " + "Sorry, NOT found!";
            }
        }
    
                

                
        



        private void Form1_Load(object sender, EventArgs e)
        {
  
            nameTextBox.Select();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
