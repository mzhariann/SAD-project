using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace SAD
{
    public static class dbConnection
    {
        static SqlConnection con;
        public static void initializeConnection() {
            string conString = Properties.Settings.Default.dbConnectionString;
            con = new SqlConnection(conString); 
        }
        public static bool userPassMatches(string user, string pass) {
            con.Open();
            
            using (SqlCommand com = new SqlCommand("SELECT userID FROM [User] WHERE userName='"+ user+ "' AND password='" + pass +"'" , con))
            {
                SqlDataReader reader = com.ExecuteReader();
                
                if (reader.Read())
                {
                    con.Close();
                    return true;
                }
            }
            con.Close();
            return false;
        }
    }
}
