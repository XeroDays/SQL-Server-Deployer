 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SQL_Installer
{
    class dbServer
    {
        public delegate void sender(bool isValid);
        public event sender connectionResponse;
        // ExecuteScalar ExecuteReader ExecuteNOnQuery
        private string _connectionString;

        public dbServer(string connectionString)
        {
            _connectionString = connectionString;

        }

        public  Task<bool>  checkConnection()
        {
            TaskCompletionSource<bool> response = new TaskCompletionSource<bool>();

            Task.Run(() =>
            {
                StringBuilder sbSP = new StringBuilder();
                sbSP.AppendLine("exec sp_databases");
                bool check = false;
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(sbSP.ToString(), connection))
                        {
                            connection.Open();
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            check = true;
                        }
                    }

                }
                catch (Exception error)
                {
                    check = false;

                }
                finally
                {
                    response.SetResult(check);
                }


               

            });
            return response.Task;


            
        }

        public bool checkConnectionSync()
	    {
            StringBuilder sbSP = new StringBuilder();
            sbSP.AppendLine("exec sp_databases");
            bool check = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sbSP.ToString(), connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        check = true;
                    }
                } 
            }
            catch (Exception error)
            {
                check = false;

            }  
            return check;
        }

        public void checkConn()
	    {
            StringBuilder sbSP = new StringBuilder();
            sbSP.AppendLine("exec sp_databases");
            bool check = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sbSP.ToString(), connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        check = true;
                    }
                }

            }
            catch (Exception error)
            {
                check = false;

            }
            finally
            {
                if (connectionResponse != null)
                {
                    connectionResponse(check);
                }
            }
             

        }

        public object getScalerValue(string StoreProcedure)
        {

            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoreProcedure, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    value = cmd.ExecuteScalar();
                }
            }

            return value;
        }
         
        public void executeStoreProcedure(string code) // will create store proc in the Server
        {
            StringBuilder sbSP = new StringBuilder();
            sbSP.AppendLine(code);
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(sbSP.ToString(), connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        System.Windows.Forms.MessageBox.Show("Error: "+err.Message + Environment.NewLine + code);
                    }

                    connection.Close();
                }
            }
        }

        public object getQueryScaller(string sqlQuery)
        {
            object value = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }

        public void Save_or_Update_Table(string StoreProcedureName, object obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoreProcedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] prop = type.GetProperties(flags);
                    conn.Open();
                    foreach (var pro in prop)
                    {
                        cmd.Parameters.AddWithValue("@" + pro.Name, pro.GetValue(obj, null));
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void getObjectNamesAndValue(object obj)
        {
            Type type = obj.GetType();
            BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            PropertyInfo[] prop = type.GetProperties(flags);
            foreach (var pro in prop)
            {
                System.Windows.Forms.MessageBox.Show("Name :" + pro.Name + " Value : " + pro.GetValue(obj, null).ToString());
            }
        }

        public DataTable getDateList(string storeProcedure)
        {
            DataTable obj = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(storeProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    obj.Load(reader);
                }
            }

            return obj;
        }
          
        public DataTable getQueryList(string sqlQuery)
        {
            DataTable tbl = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    tbl.Load(reader);
                }
            }
            return tbl;
        }

        public int Insert_Table_ReturnID(string StoreProcedureName, object obj)
        {
            object returnID = 0;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(StoreProcedureName, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Type type = obj.GetType();
                    BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                    PropertyInfo[] prop = type.GetProperties(flags);
                    conn.Open();
                    foreach (var pro in prop)
                    {
                        cmd.Parameters.AddWithValue("@" + pro.Name, pro.GetValue(obj, null));
                    }
                    returnID = cmd.ExecuteScalar();
                }
            }
            return Convert.ToInt32(returnID);
        }

        public void deleteWithID(string tableName, object ID)
        {
            string sql = "DELETE FROM " + tableName + " WHERE ID = " + Convert.ToInt32(ID);
            getQueryScaller(sql);
        }

        public int getID_onInsert(string sqlQuery)
        {
            object value = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                {
                    conn.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return Convert.ToInt32(value);
        }
    }



}
