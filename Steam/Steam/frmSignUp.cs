using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamLibrary
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        bool[] isFilled;

        public string typedUsername;
        public string typedPassword;

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            txtRptPassword.Clear();
            txtRptPassword.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string errorString = "";
            bool showMessage = false;
            isFilled = new bool[7];
            if (txtRptPassword.Text != typedPassword)
            {
                errorString += "The given password doesn't match with the previous one.\n";
                isFilled[0] = false;
                showMessage = true;
            }
            if (txtCity.Text == "" || txtCountry.Text == "" || txtEmail.Text == "" || txtNickName.Text == "" || txtPhoneNumber.Text == "" || txtState.Text == "" || txtZipCode.Text == "")
            {
                errorString += "All fields must be filled in order to create an account!";
                showMessage = true;
            }
            if (showMessage)
                MessageBox.Show(errorString);
            else
            {
                //coloca no banco!
                MessageBox.Show("Account successfully created!");
                this.Close();
            }                
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
