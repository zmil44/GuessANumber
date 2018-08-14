/*Zachary Miller
 * 01/10/2018
 * assignment 8.2
 * The purpose of this program is play a guessing game with radio buttons. You must guess which button is the correct one
 * GuessANumber.cs
 * Bellevue University
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

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        int winningButton; // holds randomly chosen winning button
        int guessedButton; // holds button guessed by user
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            guessedButton = 1;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            check();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guessedButton = 2;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            check();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            guessedButton = 3;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            check();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            guessedButton = 4;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton5.Enabled = false;
            check();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            guessedButton = 5;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton1.Enabled = false;
            check();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Generate a random number between 1-5
            int hintNumber = rand.Next(1, 6);

            // Check if generated number is equal to winning button
            // If yes, generate another number
            // Repeat the process until generated number represents a button which is incorrect
            while (hintNumber == winningButton)
            {
                hintNumber = rand.Next(1, 6);
            }
            MessageBox.Show(hintNumber + "- This button is incorrect");

            if (hintNumber == 1)
                radioButton1.Enabled = false;
            if(hintNumber == 2)
                radioButton2.Enabled = false;
            if(hintNumber == 3)
                radioButton3.Enabled = false;
            if(hintNumber == 4)
                radioButton4.Enabled = false;
            if(hintNumber == 5)
                radioButton5.Enabled = false;
            // Disbale the label after showing hint
            // so that, user can see hint only one time
            label1.Enabled = false;
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.TabStop = false;
            radioButton2.TabStop = false;
            radioButton3.TabStop = false;
            radioButton4.TabStop = false;
            radioButton5.TabStop = false;

            Random rand = new Random();
            winningButton = rand.Next(1, 6);
        }

        private void check()
        {
            // if both buttons have same value, then user is correct else not
            if (winningButton == guessedButton)
            {
                MessageBox.Show("Correct guess");
            }
            else
            {
                MessageBox.Show("Incorrect guess");
            }
        }
    }
}
