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
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }
        public int librarySize;
        public int userID;
        public string userName;
        GameOfStore[] storeGames;
        public string[] gameArray;

        private void frmStore_Load(object sender, EventArgs e)
        {
            this.lbGames.Items.Clear();
            storeGames = new GameOfStore[30];
            int numberofGames = RetrieveGamesFromBD();
            
            for (int i = 0; i < numberofGames; i++)
            {
                string gameName = storeGames[i].GetName();
                lbGames.Items.Add(gameName);
            }
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(ClientSize.Width / 30, 0);

            lblUserName.Text = userName;
            if (numberofGames > 0)
            {

                lblDescription.MaximumSize = new Size(780, 4 * lblDescription.Height);

                lblOwned.Text = "Not Owned";
                for (int j = 0; j < librarySize; j++)
                    if (gameArray[j] == storeGames[0].GetName())
                        lblOwned.Text = "Owned";

                lblPrice.Text = "R$ "+ Convert.ToString(storeGames[0].getPrice());
                lblGameName.Text = storeGames[0].GetName();
                lblDescription.Text = storeGames[0].getDescription();
            }
            else
            {
                lblGameName.Text = "0 Games";
                lblDescription.Text = "No description";
            }

        }

        public int RetrieveGamesFromBD()
        {
            int gameID;
            float price;
            int unitsSold;
            int counter = 0;
            SqlDataReader MyReader = DatabaseAccess.getDataFromDB("SELECT * FROM [GameOfStore]");
            if (MyReader.HasRows == false)
                return 0;
            while (MyReader.Read())
            {
                gameID = Convert.ToInt32(MyReader["gameID"].ToString());
                price = (float)Convert.ToDouble(MyReader["price"].ToString());
                unitsSold = Convert.ToInt32(MyReader["unitSold"].ToString());
                storeGames[counter] = new GameOfStore(gameID, price, unitsSold);
                counter++;
            }
            MyReader.Close();
            return counter;
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm Payment?", "ATTENTION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //compra
                if (lblOwned.Text != "Owned")
                {
                    int i = lbGames.SelectedIndex;
                    string gameName = storeGames[i].GetName();

                    DBSteamDataSet db = new DBSteamDataSet();
                    DBSteamDataSetTableAdapters.GameOfLibraryTableAdapter GameOfLibraryTableAdapter = new DBSteamDataSetTableAdapters.GameOfLibraryTableAdapter();

                    DBSteamDataSet.GameOfLibraryRow newGameOfLibraryRow = db.GameOfLibrary.NewGameOfLibraryRow();


                    DBSteamDataSetTableAdapters.AchievementOfLibraryTableAdapter AchievementOfLibraryTableAdapter = new DBSteamDataSetTableAdapters.AchievementOfLibraryTableAdapter();

                    DBSteamDataSet.GameOfLibraryRow newAchievementOfLibraryRow = db.GameOfLibrary.NewGameOfLibraryRow();
                    GameOfLibraryTableAdapter.Insert(0, userID, storeGames[i].getGameID());

                    int achID;
                    int gameOfLibraryID = 0;
                    int j = 0;

                    SqlDataReader MineReader = DatabaseAccess.getDataFromDB("SELECT ID FROM [GameOfLibrary] WHERE userID ='" + Convert.ToString(userID) + "' AND gameID = '" + storeGames[i].getGameID() + "'");
                    if (MineReader.Read())
                    {
                        gameOfLibraryID = Convert.ToInt32(MineReader["ID"].ToString());
                    }

                    while (true)
                        try
                        {
                            achID = storeGames[i].achievementsvector[j].ID;
                            AchievementOfLibraryTableAdapter.Insert(gameOfLibraryID, achID, 0);
                            j++;
                        }
                        catch
                        {
                            break;
                        }

                    MessageBox.Show("Sale succeeded");
                    this.Close();
                }
                else
                    MessageBox.Show("You already have the selected game");
                
            }
            else
            {
                MessageBox.Show("Sale cancelled");
            }
        }

        private void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbGames.SelectedIndex;
            lblGameName.Text = storeGames[i].GetName();
            lblDescription.Text = storeGames[i].getDescription();

            lblOwned.Text = "Not Owned";
            for (int j = 0; j < librarySize; j++)
                if (gameArray[j] == storeGames[i].GetName())
                    lblOwned.Text = "Owned";

            lblPrice.Text = "R$ " + Convert.ToString(storeGames[i].getPrice());           
         }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
