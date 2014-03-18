﻿using System;
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

        public static List<string> getColumnByName(string tableName, string colName)
        {
            con.Open();
            List<string> cols = new List<string>();
            using (SqlCommand com = new SqlCommand("SELECT "+colName +" FROM ["+ tableName+"]", con))
            {
                SqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string col;
                    col = reader.GetValue(0).ToString();
                    cols.Add(col);
                }
            }
            con.Close();
            return cols;
        }

        public static bool insertProfessor(Professor p)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Professor] VALUES ('" + p.Id + "','" + p.email + "', '" + p.fName + "', '" + p.lName + "', '" +p.deptManager +"')", con);
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
        public static bool insertEvaluator(Evaluator e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Evaluator] VALUES ('" + e.Id + "','" + e.email + "', '" + e.fName + "', '" + e.lName + "')", con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
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

        public static List<Professor> getAllProfessors() {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT * FROM [Professor]", con))
            {
                SqlDataReader reader = com.ExecuteReader();
                List<Professor> profs = new List<Professor>();
                while (reader.Read())
                {
                    Professor p = new Professor();
                    p.Id = reader["Id"].ToString();
                    p.fName = reader["fName"].ToString();
                    p.lName = reader["lName"].ToString();
                    p.email = reader["email"].ToString();
                    p.deptManager = reader["deptManager"].ToString();

                    System.Diagnostics.Debug.WriteLine("P : " + p.Id + " " + p.fName + " " + p.lName + " " + p.email + " " + p.deptManager);
                    profs.Add(p);
                }
                con.Close();
                return profs;
            }

        }
        public static List<Evaluator> getAllEvaluators()
        {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT * FROM [Evaluator]", con))
            {
                SqlDataReader reader = com.ExecuteReader();
                List<Evaluator> evals = new List<Evaluator>();
                while (reader.Read())
                {
                    Evaluator p = new Evaluator();
                    p.Id = reader["Id"].ToString();
                    p.fName = reader["fName"].ToString();
                    p.lName = reader["lName"].ToString();
                    p.email = reader["email"].ToString();

                    System.Diagnostics.Debug.WriteLine("P : " + p.Id + " " + p.fName + " " + p.lName + " " + p.email );
                    evals.Add(p);
                }
                con.Close();
                return evals;
            }

        }
        public static List<Evaluator> getNotSubmitedEvaluators()
        {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT * FROM [Evaluator] WHERE hasSubmited = 0", con))
            {
                SqlDataReader reader = com.ExecuteReader();
                List<Evaluator> evals = new List<Evaluator>();
                while (reader.Read())
                {
                    Evaluator p = new Evaluator();
                    p.Id = reader["Id"].ToString();
                    p.fName = reader["fName"].ToString();
                    p.lName = reader["lName"].ToString();
                    p.email = reader["email"].ToString();

                    System.Diagnostics.Debug.WriteLine("P : " + p.Id + " " + p.fName + " " + p.lName + " " + p.email);
                    evals.Add(p);
                }
                con.Close();
                return evals;
            }

        }
        public static List<Professor> getAllDeptManagers()
        {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT * FROM [Professor] WHERE deptManager != NULL", con))
            {
                SqlDataReader reader = com.ExecuteReader();
                List<Professor> profs = new List<Professor>();
                while (reader.Read())
                {
                    Professor p = new Professor();
                    p.Id = reader["Id"].ToString();
                    p.fName = reader["fName"].ToString();
                    p.lName = reader["lName"].ToString();
                    p.email = reader["email"].ToString();
                    p.deptManager = reader["deptManager"].ToString();

                    System.Diagnostics.Debug.WriteLine("P : " + p.Id + " " + p.fName + " " + p.lName + " " + p.email + " " + p.deptManager);
                    profs.Add(p);
                }
                con.Close();
                return profs;
            }
        }
            public static List<Professor> getAllSeminarProfessors() {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT * FROM [SeminarCourseProfs] s, [Professor] p WHERE s.Id = p.Id", con))
            {
                SqlDataReader reader = com.ExecuteReader();
                List<Professor> profs = new List<Professor>();
                while (reader.Read())
                {
                    Professor p = new Professor();
                    p.Id = reader["Id"].ToString();
                    p.fName = reader["fName"].ToString();
                    p.lName = reader["lName"].ToString();
                    p.email = reader["email"].ToString();


                    System.Diagnostics.Debug.WriteLine("P : " + p.Id + " " + p.fName + " " + p.lName + " " + p.email + " " + p.deptManager);
                    profs.Add(p);
                }
                con.Close();
                return profs;
            }

        }

        }
    }

