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
            btnSignIn.ForeColor = Color.Black;
            btnSignUp.ForeColor = Color.Black;
            if (DatabaseAccess.isConnected())
            { 
                //faz a query
            }
        }

        private void btnSignInClick(object sender, EventArgs e)
        {
            try
            {
                frm_steamLibrary libraryForm = new frm_steamLibrary();
                libraryForm.usuario = new User(txtUsername.Text, txtPassword.Text);
                this.Hide();
                libraryForm.ShowDialog();
                this.Show();
                frmLogin_Load(new object(), new EventArgs());
            }
            catch 
            {
                MessageBox.Show("Usuário Inexistente!");
            }

        }
    }
}
