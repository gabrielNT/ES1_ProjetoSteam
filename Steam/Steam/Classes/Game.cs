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
    public abstract class Game
    {

        protected int gameID
        {
            get;
            set;
        }

        protected string name
        {
            get;
            set;
        }

        private string description
        {
            get;
            set;
        }

        private string version
        {
            get;
            set;
        }

        private float fileSize
        {
            get;
            set;
        }

        public struct Achievements
        {
            public int ID;
            public string name;
            public string description;
        }

        public Achievements[] achievementsvector;

        public virtual IEnumerable<CompatibleSystem> CompatibleSystem
        {
            get;
            set;
        }

        public virtual IEnumerable<AdditionalSoftware> AdditionalSoftware
        {
            get;
            set;
        }

        public string GetVersion()
        {
            return this.version;
        }

        public virtual int GetAdditionalSoftwareRequired()
        {
            throw new System.NotImplementedException();
        }

        protected bool GetGameInformationFromDB()
        {
            
            SqlDataReader MyReader = DatabaseAccess.getDataFromDB("SELECT * FROM [Game] WHERE ID = '" + this.gameID.ToString() + "'");
            if (MyReader == null)
                return false;

            MyReader.Read();
            this.gameID = Convert.ToInt32(MyReader["ID"].ToString());
            this.description = MyReader["description"].ToString();
            this.version = MyReader["version"].ToString();
            this.fileSize = (float)Convert.ToDouble(MyReader["fileSize"].ToString());
            this.name = MyReader["name"].ToString();
            DatabaseAccess.CloseConnection();

            // ACHIEVEMENTS DO JOGO
            SqlDataReader MyReader2 = DatabaseAccess.getDataFromDB("SELECT * FROM [Achievement] WHERE gameID = '" + this.gameID.ToString() + "' ORDER BY ID");
            int i = 0;
            this.achievementsvector = new Achievements[30];
            while (MyReader2.Read())
            {
                this.achievementsvector[i].ID = Convert.ToInt32(MyReader2["ID"].ToString());
                this.achievementsvector[i].name = MyReader2["name"].ToString();
                this.achievementsvector[i].description = MyReader2["description"].ToString();
                i++;             
            }
            DatabaseAccess.CloseConnection();

            return true;
        }

        public string GetName()
        {
            return this.name;
        }

        public float getFileSize()
        {
            return this.fileSize;
        }

        public string getDescription()
        {
            return description;
        }

        public Achievements getAchievement(int which)
        {
            Achievements aux;
            int tamanho = this.achievementsvector.GetLength(0);

            aux.ID = this.achievementsvector[which].ID;
            aux.name = this.achievementsvector[which].name;
            aux.description = this.achievementsvector[which].description;
            return aux;
        }
    }
}

