using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            if (txtCity.Text == "" || txtCountry.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "" || txtState.Text == "" || txtZipCode.Text == "")
            {
                errorString += "All fields must be filled in order to create an account!";
                showMessage = true;
            }
            if (showMessage)
                MessageBox.Show(errorString);
            else
            {
                //coloca no banco!
                DBSteamDataSet db = new DBSteamDataSet();
                DBSteamDataSetTableAdapters.UserTableAdapter userTableAdapter =
                            new DBSteamDataSetTableAdapters.UserTableAdapter();
                
                DBSteamDataSetTableAdapters.AddressTableAdapter addressTableAdapter =
                            new DBSteamDataSetTableAdapters.AddressTableAdapter();

                DBSteamDataSet.UserRow newUserRow = db.User.NewUserRow();
                //newUserRow.email = txtEmail.Text;
                //newUserRow.phoneNumber = txtPhoneNumber.Text;
                //newUserRow.userName = typedUsername;
                //newUserRow.numberOfGames = 0;
                //newUserRow.password = typedPassword;
                //newUserRow.EndEdit();
                //// Add the row to the Region table 
                //db.User.Rows.Add(newUserRow);
                //// Save the new row to the database
                //userTableAdapter.Update(db);
                userTableAdapter.Insert(txtEmail.Text, 0, typedPassword, txtPhoneNumber.Text, 0, typedUsername);

                 SqlDataReader MineReader = DatabaseAccess.getDataFromDB("SELECT ID FROM [User] WHERE userName LIKE '" + typedUsername + "'");
                 int id = 0;
                 if (MineReader.Read())
                 {
                     id = Convert.ToInt32(MineReader["ID"].ToString());
                     DBSteamDataSet.AddressRow newAddressRow = db.Address.NewAddressRow();
                     //newAddressRow.userID = id;
                     //newAddressRow.zipCode = txtZipCode.Text;
                     //newAddressRow.city = txtCity.Text;
                     //newAddressRow.state = txtState.Text;
                     //newAddressRow.country = txtCountry.Text;
                     //newAddressRow.Address = "default";
                     //db.Address.Rows.Add(newAddressRow);
                     addressTableAdapter.Insert(id,txtCity.Text,txtCountry.Text,txtState.Text,txtZipCode.Text,"default");
                 }
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
