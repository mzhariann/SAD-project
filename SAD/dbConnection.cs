﻿using System;
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
    public static class dbConnection
    {
        public static SqlConnection con;
        public static void initializeConnection()
        {
            string conString = Properties.Settings.Default.dbConnectionString;
            con = new SqlConnection(conString);
        }
        public static bool userPassMatches(string user, string pass)
        {
            con.Open();
            
            using (SqlCommand com = new SqlCommand("SELECT Id FROM [User] WHERE userName='" + user + "' AND password='" + pass + "'", con))
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
        public static bool delete(string tableName, int Id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [" + tableName + "] WHERE Id='" + Id + "'", con);
                cmd.ExecuteNonQuery();
                //System.Diagnostics.Debug.WriteLine("DELETE : " +Id );
                MessageBox.Show("DELETE FUNC : " + Id);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO [Student] VALUES ('" + s.degree + "', '" + s.entranceYear + "', '" + s.majorId + "', '" + s.supervisor + "')", con);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO [Person] VALUES ('" + s.fname + "', '" + s.lname + "', '" + s.email + "')", con);
                cmd2.ExecuteNonQuery();
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
        public static string[] getTableColumns(string tableName)
        {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT c.name 'Column Name' FROM sys.columns c WHERE c.object_id = OBJECT_ID('" + tableName + "')", con))
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
        public static string getField(string table, int id, string col)
        {
            con.Open();

            using (SqlCommand com = new SqlCommand("SELECT " + col + " FROM [" + table + "] WHERE Id='" + id + "'", con))
            {
                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    string res = (string)reader.GetValue(0);
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
            using (SqlCommand com = new SqlCommand("SELECT " + colName + " FROM [" + tableName + "]", con))
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
                SqlCommand cmd = new SqlCommand("INSERT INTO [Professor] VALUES ('" + p.deptManager + "')", con);
                cmd.ExecuteNonQuery();
                //SqlCommand cmd2 = new SqlCommand("INSERT INTO [Person] VALUES ('" + s.fname + "', '" + s.lname + "', '" + s.email + "')", con);
                //cmd2.ExecuteNonQuery(); 
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
                SqlCommand cmd = new SqlCommand("INSERT INTO [Evaluator] VALUES ('" + e.email + "', '" + e.fName + "', '" + e.lName + "')", con);
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

        public static List<Professor> getAllProfessors()
        {
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

                    System.Diagnostics.Debug.WriteLine("P : " + p.Id + " " + p.fName + " " + p.lName + " " + p.email);
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
        public static List<Professor> getAllSeminarProfessors()
        {
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
        public static DataTable getGroupsTable()
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT * FROM [Group]", con))
            {
                // Use DataAdapter to fill DataTable

                a.Fill(t);

                // Render data onto the screen

            }
            con.Close();
            return t;
        }


        public static bool addGroupMember(int gId, int mId)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [GroupMembers] VALUES ('" + gId + "','" + mId + "')", con);

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

        public static bool deleteGroupMember(int gId, int mId)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [GroupMembers] WHERE GroupId = '" + gId + "' AND MemberId = '" + mId + "'", con);

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
        public static int addGroup(string name)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [Group] VALUES ('" + name + "') ; SELECT CAST(scope_identity() AS int)", con);
                Int32 gid = (Int32)cmd.ExecuteScalar();
                return gid;


            }
            catch (Exception ex)
            {
                con.Close();
                return -1;
            }
            finally
            {
                con.Close();
            }
            return -1;
        }
        public static DataTable getTable(string name)
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT * FROM [" + name + "]", con))
            {
                // Use DataAdapter to fill DataTable

                a.Fill(t);

                // Render data onto the screen

        }
            con.Close();
            return t;
        }

        public static DataTable getAllStudentsTable()
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT P.Id , P.fName , P.lName , P.email FROM [Student] as S , [Person] as P WHERE S.Id = P.Id ", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }
        public static DataTable getAllProfsTable()
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT P.Id , P.fName , P.lName , P.email FROM [Professor] as S , [Person] as P WHERE S.Id = P.Id ", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }
        public static DataTable getAllEvalsTable()
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT P.Id , P.fName , P.lName , P.email FROM [Evaluator] as S , [Person] as P WHERE S.Id = P.Id ", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }

        public static DataTable getStudentsInGroup(int id)
        {
            con.Open();
            DataTable t = new DataTable();
            //using (SqlDataAdapter a = new SqlDataAdapter(
            //"SELECT Id FROM [Student] as S WHERE Id IN (SELECT MemberId FROM [GroupMembers] WHERE GroupId = '" + id + "') ", con))
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT (CASE WHEN S.Id IN (SELECT MemberId FROM [GroupMembers] WHERE GroupId = '" + id + "') THEN 1 ELSE 0 END) AS bool, P.Id , P.fName , P.lName , P.email FROM [Student] as S , [Person] as P WHERE S.Id = P.Id ", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }

        public static DataTable getMembersInGroup(int id)
        {
            con.Open();
            DataTable t = new DataTable();
            //using (SqlDataAdapter a = new SqlDataAdapter(
            //"SELECT Id FROM [Student] as S WHERE Id IN (SELECT MemberId FROM [GroupMembers] WHERE GroupId = '" + id + "') ", con))
            using (SqlDataAdapter a = new SqlDataAdapter(
                "SELECT  P.Id , P.fName , P.lName , P.email FROM [Person] as P WHERE (P.Id IN (SELECT MemberId FROM [GroupMembers] WHERE GroupId = '" + id + "'))", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }


        public static DataTable getProfsInGroup(int id)
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT (CASE WHEN S.Id IN (SELECT MemberId FROM [GroupMembers] WHERE GroupId = '" + id + "') THEN 1 ELSE 0 END) AS bool, P.Id , P.fName , P.lName , P.email FROM [Professor] as S , [Person] as P WHERE S.Id = P.Id ", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }


        public static DataTable getEvalsInGroup(int id)
        {
            con.Open();
            DataTable t = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(
            "SELECT (CASE WHEN S.Id IN (SELECT MemberId FROM [GroupMembers] WHERE GroupId = '" + id + "') THEN 1 ELSE 0 END) AS bool, P.Id , P.fName , P.lName , P.email FROM [Evaluator] as S , [Person] as P WHERE S.Id = P.Id ", con))
            {
                // Use DataAdapter to fill DataTable
                a.Fill(t);
                // Render data onto the screen
            }
            con.Close();
            return t;
        }


        public static bool updateGroup(string name, int id)
        {

            con.Open();
            try
            {
                SqlCommand com = new SqlCommand("UPDATE [Group] SET Name='" + name + "' Where Id = '" + id + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                return true;
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
        }
    }
    
    }

