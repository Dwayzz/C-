﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addSubtractButton_Click(object sender, EventArgs e)
        {
            AddSubtractForm addsub = new AddSubtractForm();
            addsub.Show();
        }

        private void multiplyDivideButton_Click(object sender, EventArgs e)
        {
            MultiplyDivideForm multiplyDivide = new MultiplyDivideForm();
            multiplyDivide.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
