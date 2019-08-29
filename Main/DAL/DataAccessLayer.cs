using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AMS.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlcon;

        public DataAccessLayer()
        {
          sqlcon = new SqlConnection("Data Source=.;Initial Catalog=Agency_DB;Integrated Security=True");
        }

        public void Open()
        {
             if(sqlcon.State!=ConnectionState.Open)
             {
                 sqlcon.Open();
             }
        }

        public void Close()
        {
            if (sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }

        public DataTable SelectData(string storedprocedurename, SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedprocedurename;
            sqlcmd.Connection = sqlcon;
            if(param != null)
            {
                for (int i = 0; i <param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
           da.SelectCommand = sqlcmd;
            da.Fill(dt);
            return dt;
        }

       /* internal void ExcuteCommand(string v, SqlParameter[] param)
        {
            throw new NotImplementedException();
        }
        */

        public void ExecuteDml(string storedprocedurename,SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = storedprocedurename;
            sqlcmd.Connection = sqlcon;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            sqlcmd.ExecuteNonQuery();
        }

    }
}
