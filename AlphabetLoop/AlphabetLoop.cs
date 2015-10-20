/*
 * Created by: Alex Mathias
 * Created on: 20-Oct-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-13
 * This program displays A-Z and a-z
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetLoop
{
    public partial class frmAlphabetLoop : Form
    {
        public frmAlphabetLoop()
        {
            InitializeComponent();
        }

        private void btnAlphabet_Click(object sender, EventArgs e)
        {
            // variables
            int firstNumber;
            int secondNumber;
            // clear listbox
            this.lstAlphabet.Items.Clear();

            for (firstNumber = 65; firstNumber <= 90; firstNumber++)
            {
                for (secondNumber = 97; secondNumber <= 122; secondNumber++)
                { 
                    this.lstAlphabet.Items.Add(char.ConvertFromUtf32(firstNumber) + " -> " + char.ConvertFromUtf32(secondNumber));
                }
            }
        }
    }
}
