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

        private string[] achievementsVector
        {
            get;
            set;
        }

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

        public string getAchievement(int which)
        {
            throw new System.NotImplementedException(); //IMPLEMENTAR ISSO AQUI
        }

    }
}

