using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AMS.BL
{
    class Management_car_categories
    {
        public DataTable get_All_Mgcat()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt= new DataTable();
            Dt = DAL.SelectData("get_All_Mgcat", null);
            DAL.Close();
            return Dt;
        }
        public DataTable getAlldealers()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.Open();
            DataTable dt = new DataTable();
            dt = Dal.SelectData("getAlldealers", null);
            Dal.Close();
            return dt;
        }

        public void DELETE_CATEGORY(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteDml("DELETE_CATEGORY", param);
            DAL.Close();
        }

        public void ADD_CATEGORY(string cat_name,int deal_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[0].Value = cat_name;

            param[1] = new SqlParameter("@deal_id", SqlDbType.Int);
            param[1].Value = deal_id;

            DAL.ExecuteDml("ADD_CATEGORY", param);
            DAL.Close();
        }


        public void UPDATE_CATEGORY(string cat_name, int deal_id,int cat_id )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
  

            param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[0].Value = cat_name;

            param[1] = new SqlParameter("@deal_id", SqlDbType.Int);
            param[1].Value = deal_id;

            param[2] = new SqlParameter("@cat_id ", SqlDbType.Int);
            param[2].Value = cat_id;

            DAL.ExecuteDml("UPDATE_CATEGORY", param);
            DAL.Close();
        }

        public DataTable VerifyCatID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            dt = DAL.SelectData("VerifyCatID", param);
            DAL.Close();
            return dt;
        }


    }
}
