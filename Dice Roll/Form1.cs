// Dice Roll Program
// Version 2.0
//
// Christopher Hardy
// POS/409
// February 16th, 2016
// Lynn Thackeray
//
// Description:
// This program is designed to allow the user to roll a pair of dice 100 times.  It compares the values of the two dice
// and will notify the user if both dice came up the same.  The program also displays the total, or outcome, of each roll,
// and if the user chooses to click the "roll" button multiple times, the listbox will be cleared to allow for the next
// 100 rolls.
//
// Version 2.0 Updates:
// In version 2.0 a second dice roll box has been added.  The program now compares both dice roll sequences and provides the
// user with the differences between the sequences (dice totals that don't occur in both sequences) using IEnumerable.Except.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll
{
    public partial class MainForm : Form
    {
        // Random number object for dice
        Random rnd = new Random();

        // MainForm initialization
        public MainForm()
        {
            InitializeComponent();
        }

        // MainForm Load event handler
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Roll button event handler
        private void btnRoll_Click(object sender, EventArgs e)
        {
            int[] diceArray = new int[100];
            int[] diceArray1 = new int[100];

            lbDice.Items.Clear();
            lbDice1.Items.Clear();
            lbResults.Items.Clear();

            for (int count = 0; count < 100; count++)
            {
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int outcome = die1 + die2;

                diceArray[count] = outcome;

                if (die1 == die2)
                    lbDice.Items.Add("Roll: " + (count + 1) + "\t\tBoth Die throw " + die1 + "\t\t\tOutcome: " + outcome);

                else
                    lbDice.Items.Add("Roll: " + (count + 1) + "\t\tDie One: " + die1 + "\tDie One: " + die2 + "\tOutcome: " + outcome);
            }

            for (int count = 0; count < 100; count++)
            {
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int outcome = die1 + die2;

                diceArray1[count] = outcome;

                if (die1 == die2)
                    lbDice1.Items.Add("Roll: " + (count + 1) + "\t\tBoth Die throw " + die1 + "\t\t\tOutcome: " + outcome);

                else
                    lbDice1.Items.Add("Roll: " + (count + 1) + "\t\tDie One: " + die1 + "\tDie One: " + die2 + "\tOutcome: " + outcome);
            }

            IEnumerable<int> different = diceArray.Except(diceArray1);

            foreach (int number in different)
            {
                lbResults.Items.Add(number);
            }
        }

        // Exit button event handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the Dice Roll program!");
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
