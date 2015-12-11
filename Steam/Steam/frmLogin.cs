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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtPassword.Clear();
            this.txtUsername.Clear();
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            txtUsername.Focus();
            btnSignIn.ForeColor = Color.Black;
            btnSignUp.ForeColor = Color.Black;
            
        }

        private void btnSignInClick(object sender, EventArgs e)
        {
            try
            {
                frm_steamLibrary libraryForm = new frm_steamLibrary();
                if (txtPassword.Text.Length < 3)
                {
                    MessageBox.Show("Password must have at least 3 characters");
                    frmLogin_Load(new object(), new EventArgs());
                    return;
                }
                libraryForm.usuario = new User(txtUsername.Text, txtPassword.Text);
                this.Hide();
                libraryForm.ShowDialog();
                this.Show();
                frmLogin_Load(new object(), new EventArgs());
            }
            catch 
            {
                MessageBox.Show("The specified user does not exist");
                frmLogin_Load(new object(), new EventArgs());
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (User.exists(txtUsername.Text))
            {
                MessageBox.Show("The username is already in use, choose another one");
                frmLogin_Load(new object(), new EventArgs());
            }
            else
            {
                frmSignUp signup = new frmSignUp();
                signup.typedUsername = this.txtUsername.Text;
                signup.typedPassword = this.txtPassword.Text;
                this.Hide();
                signup.ShowDialog();
                this.Show();
                frmLogin_Load(new object(), new EventArgs());
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnSignInClick(new object(), new EventArgs());
            }
        }
    }
}
