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
        string[] gameArray;
        int numberofGames;
        public User usuario;

        private void frm_steamLibrary_Load(object sender, EventArgs e)
        {
            this.lbGames.Items.Clear();
            userGames = new GameOfLibrary[30];
            gameArray = new string[30];

            numberofGames = RetrieveGamesFromBD(usuario.getID());
            for (int i = 0; i < numberofGames; i++)
            {
                string gameName = userGames[i].GetName();
                gameArray[i] = gameName;
                lbGames.Items.Add(gameName);
            }
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(ClientSize.Width / 30, 0);
            
            lblUserName.Text = usuario.getName();
            if (numberofGames > 0)
            {
                
                lblDescription.MaximumSize = new Size(780, 4 * lblDescription.Height);
                
                lblAchievementDescription.MaximumSize = new Size(780, 2 * lblDescription.Height);

                lblNumberOfGames.Text = numberofGames.ToString();               
           
                lblGameName.Text = userGames[0].GetName();
                lblHoursPlayed.Text = userGames[0].GetHoursPlayed().ToString();
                lblDescription.Text = userGames[0].getDescription();
            }
            else
            { 
                lblGameName.Text = "0 Games";
                lblHoursPlayed.Text = "xx.x";
                lblDescription.Text = "No description";
                lblAchievementDescription.Text = "                                                          ";
                lblIsIntalled.Text = "";
            }
        }

        public int RetrieveGamesFromBD(int userid)
	    {
            int gameID;
            int gameofLibraryID;
            float hours;
            int counter = 0;
            SqlDataReader MyReader = DatabaseAccess.getDataFromDB("SELECT * FROM [GameOfLibrary] WHERE userID = " + userid);
            if (MyReader.HasRows == false )
                return 0;
            while (MyReader.Read())
            {
                gameofLibraryID = Convert.ToInt32(MyReader["ID"].ToString());
                gameID = Convert.ToInt32(MyReader["gameID"].ToString());
                hours = (float)Convert.ToDouble(MyReader["hoursPlayed"].ToString());
                userGames[counter] = new GameOfLibrary(gameID,hours,gameofLibraryID , userid);
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
            int i = lbGames.SelectedIndex;
            int j = cmbAchievements.SelectedIndex;
            lblAchievementName.Text = userGames[i].achievementsvector[j].name;
            lblAchievementDescription.Text = userGames[i].achievementsvector[j].description;
            if (userGames[i].AchievementsUnlocked[j])
                lblIsCompleted.Text = "(Completed)";
            else
                lblIsCompleted.Text = "(Not Completed)";
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
            lblAchievementName.Text = userGames[i].achievementsvector[0].name;
            lblAchievementDescription.Text = userGames[i].achievementsvector[0].description;
            
            int j = 0;
            cmbAchievements.Items.Clear();
            while (true)
            {                
                try
                {
                    cmbAchievements.Items.Add(userGames[i].achievementsvector[j].name);
                    j++;

                }
                catch 
                { 
                    break; 
                }
            }
            cmbAchievements.SelectedIndex = 0;
            int auxiliar = 0 ;
            for (int h = 0; h < j; h++)
                if(userGames[i].AchievementsUnlocked[h])
                    auxiliar++;
            lblNM.Text = "( "+auxiliar.ToString()+"/" +j.ToString() +" ) ";
        }

        private void frm_steamLibrary_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Parent.Show();
        }

        private void rb3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            frmStore frmstore = new frmStore();
            this.Hide();
            frmstore.userName = this.usuario.getName();
            int j = numberofGames;
            frmstore.gameArray = new string[j];
            for (int i = 0; i < j; i++)
                frmstore.gameArray[i] = this.gameArray[i];
            frmstore.librarySize =j;
            frmstore.userID = usuario.getID();
            frmstore.ShowDialog();
            this.Show();
            frm_steamLibrary_Load(new object(), new EventArgs());
        }
    }
}