using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SteamLibrary
{
    public static class ExternalDefinitions
    {
        public static string connectionString = Properties.Settings.Default.DBSteamConnectionString3;
        public static int x = 10;
    }
}
