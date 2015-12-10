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
        public static string connectionString = @"Data Source=(LocalDB)\v11.0;" +
                                                  @"AttachDbFilename=C:\olar\DBSteam.mdf;
                                                  Integrated Security=True;Connect Timeout=30";
    }
}
