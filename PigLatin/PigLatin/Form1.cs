//Dillon Waisner
//11/20/21

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class PigLatin : Form
    {
        public PigLatin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string strPigLatinWord = convertToPigLatin(englishWordTextBox.Text);

            englishWordTextBox.Text = strPigLatinWord;
        }

        private string convertToPigLatin(string engWords)
        {
            string extraLetter = string.Empty;
            string pigLatin = string.Empty;
            string FirstLetter = string.Empty;
            string[] engWord = engWords.Split(' ');
            string space = "";

            foreach (string word in engWord)

            {
                FirstLetter = word.Substring(0, 1);//if only 1 letter is typed it only adds ay
                extraLetter = word.Substring(1, word.Length - 1);//if more than 1 letter is type it swaps the first letter to the end and adds ay also
                if (word.Length == 1) 
                {
                pigLatin = pigLatin + space + word + "ay";
                }
                else//replaces the first letter of the word and places it at the end, and adds "ay"
                {
                pigLatin = pigLatin + space + extraLetter + FirstLetter + "ay";
                }
                space = " ";

            }
            return pigLatin.ToString();
            }

        private void PigLatin_Load(object sender, EventArgs e)
        {

        }
    }
}

