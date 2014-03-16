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
            
            using (SqlCommand com = new SqlCommand("SELECT Id FROM [User] WHERE userName='"+ user+ "' AND password='" + pass +"'" , con))
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
        public static bool delete(string tableName, int Id){
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [" + tableName + "] WHERE Id='" + Id + "'", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        public static bool insertStudent(Student s)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Student] VALUES ('" + s.Id + "','" + s.fname + "', '" + s.lname + "', '" + s.email + "', '" + s.degree + "', '" + s.entranceYear + "', '" + s.majorId + "', '" + s.supervisor + "')", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                con.Close();
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
        public static string[] getTableColumns(string tableName) {
            con.Open();

            using (SqlCommand com = new SqlCommand( "SELECT c.name 'Column Name' FROM sys.columns c WHERE c.object_id = OBJECT_ID('" + tableName +"')", con) )
            {
                SqlDataReader reader = com.ExecuteReader();
                
                if (reader.Read())
                {
                    string[] columns = new string[reader.FieldCount];
                    reader.GetValues(columns);
                    con.Close();  
                    return columns;
                }
            }
            con.Close();
            return null;
        }
        public static string getField(string table, int id, string col) {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT '" + col + "' FROM '" + table +"' WHERE Id='" + id + "'", con))
            {
                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    string res = (string) reader.GetValue(0);
                    con.Close();
                    return res;
                }
            }
            con.Close();
            return null;
        }

    }
}
