using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AMS.BL
{
    class Login
    {
        public DataTable LoginFunc(string u_ID, string u_Pass)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param =new SqlParameter[2];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[1] = new SqlParameter("@user_password", SqlDbType.VarChar, 50);
            param[0].Value = u_ID;
            param[1].Value = u_Pass;
            Dal.Open();
            DataTable dt = new DataTable();
            dt = Dal.SelectData("Login_Proc", param);
            Dal.Close();
            return dt;
        }
        public void ADD_User(string id,string pass,string usertype,string userfullname)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@user_password ", SqlDbType.VarChar, 50);
            param[1].Value = pass;
            param[2] = new SqlParameter("@user_type ", SqlDbType.VarChar, 20);
            param[2].Value = usertype;
            param[3] = new SqlParameter("@user_fullname", SqlDbType.VarChar, 50);
            param[3].Value = userfullname;
            Dal.ExecuteDml("Add_user", param);
            Dal.Close();
        }
        public void Edit_user(string id, string pass, string usertype, string userfullname)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@user_password ", SqlDbType.VarChar, 50);
            param[1].Value = pass;
            param[2] = new SqlParameter("@user_type ", SqlDbType.VarChar, 20);
            param[2].Value = usertype;
            param[3] = new SqlParameter("@user_fullname", SqlDbType.VarChar, 50);
            param[3].Value = userfullname;
            Dal.ExecuteDml("Edit_user", param);
            Dal.Close();
        }
        public void Delete_user(string id)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            Dal.ExecuteDml("Delete_user", param);
            Dal.Close();
        }
        public DataTable SearchUsers(string user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@key", SqlDbType.VarChar, 50);
            param[0].Value = user_id;
            Dt = DAL.SelectData("SearchUsers", param);
            DAL.Close();
            return Dt;
        }

        public DataTable Verifyuser_id(string user_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.VarChar, 50);
            param[0].Value = user_id;
            Dt = DAL.SelectData("Verifyuser_id", param);
            DAL.Close();
            return Dt;
        }

    }
}
