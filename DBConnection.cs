using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ACT_8_BACKEND
{
    public static class DBConnection
    {
        public static MySqlConnection conn = new MySqlConnection(
            "server=localhost;user=root;password=09264050857;database=jollibee_daraga;");
    }

}
