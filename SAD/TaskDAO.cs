using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.Data;

namespace SAD
{
    public static class TaskDAO
    {
        public static bool insert(Task t)
        {
            try
            {
                string query = "INSERT INTO [Task] VALUES (@Subject , @CreationDate, @Content, @Confirmation, @SendingDate, @StartDate, @EndDate, @PeriodicSend, @Pkey, @PVal) ; SELECT CAST(scope_identity() AS int)";
                using (SqlCommand cmd = new SqlCommand(query, dbConnection.con))
                {
                    cmd.Parameters.AddWithValue("@Subject", t.subject);
                    cmd.Parameters.Add("@CreationDate", SqlDbType.DateTime2).Value =t.creationDate;
                    cmd.Parameters.AddWithValue("@Content", t.content);
                    cmd.Parameters.AddWithValue("@Confirmation", t.confirmation);
                    cmd.Parameters.Add("@SendingDate", SqlDbType.DateTime2).Value = t.sendingDate;
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime2).Value = t.prdSend.startDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime2).Value = t.prdSend.endDate;
                    cmd.Parameters.AddWithValue("@PeriodicSend", t.periodicSend);
                    cmd.Parameters.AddWithValue("@PKey", t.prdSend.period.Key);
                    cmd.Parameters.AddWithValue("@PVal", t.prdSend.period.Value);
                    dbConnection.con.Open();
                    t.id = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception e)
            {
                dbConnection.con.Close();
                return false;
            }
            finally
            {
                dbConnection.con.Close();
            }
            return true;
        }

        public static bool delete(Task t)
        {
            try
            {
                dbConnection.con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Task] WHERE Id='" + t.id + "'", dbConnection.con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dbConnection.con.Close();
                return false;
            }
            finally
            {
                dbConnection.con.Close();
            }
            return true;
        }

        public static bool update(Task t)
        {
            return false;
        }
        public static bool insertReceivers(Task t)
        {
            try
            {
                dbConnection.con.Open();

                for (int i = 0; i < t.receivers.Count; i++)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO [TaskRec] VALUES ('" + t.id + "','" + t.receivers[i] + "')", dbConnection.con);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                    }
                }

            }
            catch (Exception ex)
            {
                dbConnection.con.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                dbConnection.con.Close();
            }
            return true;
        }

        public static DataTable getSubjectTable()
        {
            dbConnection.con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT subject , Id FROM [Task]", dbConnection.con))
            {
                // Use DataAdapter to fill DataTable

                a.Fill(t);

                // Render data onto the screen

            }
            dbConnection.con.Close();
            return t;
        }

        public static Task getById(int id)
        {
            Task t = new Task();
            dbConnection.con.Open();

            using (SqlCommand com = new SqlCommand("SELECT * FROM [Task] WHERE Id = '"+ id+"'", dbConnection.con))
            {
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    t.id = Convert.ToInt32(reader["Id"]);
                    t.subject = reader["subject"].ToString();
                    t.creationDate = Convert.ToDateTime(reader["creationDate"]);
                    t.content = reader["content"].ToString();
                    t.confirmation = Convert.ToBoolean(reader["confirmation"]);
                    t.periodicSend = Convert.ToBoolean(reader["periodicSend"]);
                    if (t.periodicSend)
                    {
                        t.prdSend.startDate = Convert.ToDateTime(reader["startDate"]);
                        t.prdSend.endDate = Convert.ToDateTime(reader["endDate"]);
                        t.prdSend.period = new KeyValuePair<int, int>((int)reader["pKey"], (int)reader["pVal"]);
                    }
                    else
                    {
                        t.sendingDate = Convert.ToDateTime(reader["sendingDate"]);
                    }
                }
                reader.Close();
            }

            using (SqlCommand com = new SqlCommand("SELECT r.Pid FROM [Task] t , [TaskRec] r  WHERE t.Id = '"+id+ "' AND r.Tid = t.Id" , dbConnection.con))
            {
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    t.receivers.Add((int)reader["Pid"]);
                }
                reader.Close();
            }
            dbConnection.con.Close();
            return t;
        }

    }
}
