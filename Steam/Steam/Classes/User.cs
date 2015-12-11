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
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SteamLibrary
{
    public class User
    {
        private int ID
        {
            get;
            set;
        }

        private string email
        {
            get;
            set;
        }

        private string userName
        {
            get;
            set;
        }

        private string password
        {
            get;
            set;
        }

        private int privacySettings
        {
            get;
            set;
        }

        private string phoneNumber
        {
            get;
            set;
        }

        private int numberOfGames
        {
            get;
            set;
        }

        //public virtual IEnumerable<GameOfLibrary> GameOfLibrary
        //{
        //    get;
        //    set;
        //}

        //public virtual IEnumerable<Address> Address
        //{
        //    get;
        //    set;
        //}

        //public virtual ShoppingCart ShoppingCart
        //{
        //    get;
        //    set;
        //}

        //public virtual Order Order
        //{
        //    get;
        //    set;
        //}

        //public virtual Profile Profile
        //{
        //    get;
        //    set;
        //}

        //private bool VerifyUserCredentials(string email, string password)
        //{
        //    throw new System.NotImplementedException();
        //}

        public int getID()
        {
            return this.ID;
        }

        public string getName()
        {
            return this.userName;
        }

        //public virtual int VerifyUserSoftwares()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public User(string name, string password, string phoneNumber, Address address)
        //{
        //}

        public virtual bool SaveToDB()
        {
            throw new System.NotImplementedException();
        }

        public User(string email, string password)
        {
            
            SqlDataReader MyReader = DatabaseAccess.getDataFromDB("SELECT * FROM [User] WHERE userName LIKE '" + email + "' AND password LIKE '" + password + "'");
            if (MyReader != null)
            {
                MyReader.Read();
                this.ID = Convert.ToInt32(MyReader["ID"].ToString());
                this.numberOfGames = Convert.ToInt32(MyReader["numberOfGames"].ToString());
                this.phoneNumber = MyReader["phoneNumber"].ToString();
                try
                {
                    this.privacySettings = Convert.ToInt32(MyReader["privacySettings"]);
                }
                catch { }
                this.userName = MyReader["userName"].ToString();
                this.email = email;
                this.password = password;
                DatabaseAccess.CloseConnection();
            }
        }

        //public virtual bool VerifyConfirmationCode(string code)
        //{
        //    throw new System.NotImplementedException();
        //}

        //private bool VerifyEmailAvailability(string email)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool AddGameToLibrary(Game game)
        //{
        //    throw new System.NotImplementedException();
        //}

        //private bool SendConfirmationCode(int code)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool ChangePassword(string old, string neww)
        //{
        //    throw new System.NotImplementedException();
        //}

        //private bool SendPasswordToken(int token)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool VerifyPasswordToken(int token)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public virtual bool ChangePrivacySettings(int change)
        //{
        //    throw new System.NotImplementedException();
        //}


        //public virtual int GetPrivacySettings()
        //{
        //    throw new System.NotImplementedException();
        //}

        public static bool exists(string email)
        {
            SqlDataReader MyReader = DatabaseAccess.getDataFromDB("SELECT * FROM [User] WHERE email LIKE '" + email + "'");
            if (MyReader.HasRows == false)
                return false;
            return true;
        }
    }
}