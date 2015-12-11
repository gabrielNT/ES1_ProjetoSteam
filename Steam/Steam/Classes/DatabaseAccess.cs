using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SteamLibrary
{
    public static class DatabaseAccess
    {
        private static SqlConnection con;
        private static bool isCon;
        private static SqlDataReader myReader;
        
        private static void databaseConnection()
        {
            con = new SqlConnection(ExternalDefinitions.connectionString);

            try
            {
                con.Open();
                isCon = true;
            }
            catch (Exception e)
            {
                isCon = false;
            }
        }

        public static bool isConnected()
        {
            return isCon;
        }

        public static SqlDataReader getDataFromDB(string command)
        {
            databaseConnection();

            SqlCommand pesquisa = new SqlCommand(command, con);

            myReader = pesquisa.ExecuteReader();

            return myReader;

        }

        public static void CloseConnection()
        {
            myReader.Close();
        }

    }
}
