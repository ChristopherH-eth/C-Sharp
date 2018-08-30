// Input Validation Program
// Version 1.0
//
// Christopher Hardy
// POS/409
// February 22nd, 2016
// Lynn Thackeray
//
// Description:
// The Input Validation Program is designed to test user input to ensure only good data is entered into a program.  The core
// element this program focuses on is using Regular Expressions from within the Regex class.  The user is asked to enter
// his/her first and last name and their phone number.  The program ensures that something is entered for both the first
// and last name before finally checking to see if what was entered for the phone number is in the correct format to ensure
// uniform data is being entered into the program.  If any of the information is deemed invalid, the user is prompted to
// reenter the information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input_Validation
{
    public partial class frmInputValidation : Form
    {
        // Input Validation Form initialization
        public frmInputValidation()
        {
            InitializeComponent();
        }

        // Input Validation Form load event handler
        private void frmInputValidation_Load(object sender, EventArgs e)
        {

        }

        // handler for Submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool RUNNING = true;
            bool valid = false;

            string firstName;
            string lastName;
            string phoneNumber;

            const string pattern = @"^\d{3}-\d{3}-\d{4}$";

            // loop to ensure all values are checked one at a time
            while (RUNNING)
            {
                firstName = txtFirstName.Text;
                lastName = txtLastName.Text;
                phoneNumber = txtPhone.Text;

                // test first name for existance
                if (firstName.Length == 0)
                {
                    MessageBox.Show("First Name must contain a value.");
                    txtFirstName.Clear();
                    txtFirstName.Focus();
                    break;
                }

                // test last name for existance
                if (lastName.Length == 0)
                {
                    MessageBox.Show("Last Name must contain a value.");
                    txtLastName.Clear();
                    txtLastName.Focus();
                    break;
                }

                // test phone number for existance and format
                if (Regex.IsMatch(phoneNumber, pattern))
                    valid = true;
                else
                {
                    MessageBox.Show("Invalid Phone Number.  Make sure you are using the correct format.");
                    txtPhone.Clear();
                    txtPhone.Focus();
                    break;
                }
                
                if (valid)
                {
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhone.Clear();

                    MessageBox.Show("The information you have entered is valid");
                    txtFirstName.Focus();

                    valid = false;
                    break;
                }
            }
        }

        // handler for Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the Input Validation Program!");
            this.Close();
        }
    }
}
