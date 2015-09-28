using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace JBS2.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlcon;

        //this Constructor Inisialize the connection object
        public DataAccessLayer()
        {
            sqlcon = new SqlConnection(@"Server=Jesus-PC; Database=john; Integrated Security= True");
        }
        // method to open the connection
        public void open()
        {
            if (sqlcon.State != ConnectionState.Open)
            {
                sqlcon.Open();
            }
        }

        //Method to close the Connection
        public void close()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
        // Method to read Data from Database

        public DataTable SelectData(string Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = sqlcon;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Method To Insert, update, and delete data from Database
        public void ExecuteCommand(String Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = sqlcon;

            if (param != null)
            {
                // the function AddRange add elmasfofa kolha without need to use the (for loop ) like we do above
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    
    }
}
