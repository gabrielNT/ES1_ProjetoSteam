﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SteamLibrary
{
    public class GameOfLibrary : Game
    {
        private int ID
        {
            get;
            set;
        }

        private float HoursPlayed
        {
            get;
            set;
        }

        private string installedVersion
        {
            get;
            set;
        }

        private bool isInstalled
        {
            get;
            set;
        }

        public bool[] AchievementsUnlocked;

        //public virtual bool CheckInstallation()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool StartGame()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool InstallGame()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool InstallAdditionalSoftware()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual int CheckAdditionalSoftware()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool UninstallGame()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool StopGame()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool IsUpToDate()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool UpdateGame()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool SaveGOFToDB()
        //{
        //    throw new System.NotImplementedException();
        //}

        public float GetHoursPlayed()
        {
            return this.HoursPlayed;
        }

        private int userID;

        //public virtual string RetrieveSavedGame()
        //{
        //    throw new System.NotImplementedException();
        //}

        public GameOfLibrary(int GameID, float hours, int GLID, int userID)
        {
            this.gameID = GameID;
            this.HoursPlayed = hours;
            this.ID = GLID;
            this.userID = userID;
            GetGameInformationFromDB();
            checkAchievements();
        }

        private void checkAchievements()
        {
            SqlDataReader MyReader2 = DatabaseAccess.getDataFromDB("SELECT * FROM [AchievementOfLibrary] WHERE gameOfLibraryID = '" + this.ID + "'");
            int i = 0;
            AchievementsUnlocked = new bool[30];
            while (MyReader2.Read())
            {
                this.AchievementsUnlocked[i] = Convert.ToBoolean(Convert.ToInt32(MyReader2["isCompleted"].ToString()));
                i++;
            }
            DatabaseAccess.CloseConnection();
        }

    }

}