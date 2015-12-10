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
    public partial class frm_steamLibrary : Form
    {
        public frm_steamLibrary()
        {
            InitializeComponent();
        }
        
        GameOfLibrary[] userGames;

        public User usuario;

        private void frm_steamLibrary_Load(object sender, EventArgs e)
        {

                     
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(ClientSize.Width / 30, 0);
            userGames = new GameOfLibrary[30];
            
            lblDescription.Text = "Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_ Descrição_";
            
            lblDescription.MaximumSize = new Size(780, 4 * lblDescription.Height);
            
            lblAchievementDescription.MaximumSize = new Size(780, 2 * lblDescription.Height);
            
            lblHoursPlayed.Text = "189.8";

            lblNumberOfGames.Text = "80";
            
            //User usuario = new User("email", "lala");
            lblUserName.Text = usuario.getName();
            int numberofGames = RetrieveGamesFromBD(usuario.getID());
            lblNumberOfGames.Text = numberofGames.ToString();
            for (int i = 0; i < numberofGames; i++)
            {
                string gameName = userGames[i].GetName();
                lbGames.Items.Add(gameName);
            }
            lblGameName.Text = userGames[0].GetName();
            lblHoursPlayed.Text = userGames[0].GetHoursPlayed().ToString();
            lblDescription.Text = userGames[0].getDescription();

        }

        public int RetrieveGamesFromBD(int userid)
	    {
            int gameID;
            bool [] ach;
            float hours;
            int ID;
            int counter = 0;
            SqlDataReader MyReader = DatabaseAccess.getDataFromDB("SELECT * FROM [GameOfLibrary] WHERE userID = " + userid);
            if (MyReader == null)
                return 0;
            while (MyReader.Read())
            {
                
                gameID = Convert.ToInt32(MyReader["ID"].ToString());
                hours = (float)Convert.ToDouble(MyReader["hoursPlayed"].ToString());
                userGames[counter] = new GameOfLibrary(gameID,hours,userid );
                counter++;
            }
            MyReader.Close();
            return counter;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbAchievements_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Colocar a descrição no label de baixo e enabled ou disabled se o cara tiver ou não tiver
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbGames.SelectedIndex;
            lblGameName.Text = userGames[i].GetName();
            lblHoursPlayed.Text = userGames[i].GetHoursPlayed().ToString();
            lblDescription.Text = userGames[i].getDescription();
        }

        private void frm_steamLibrary_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Parent.Show();
        }
    }
}