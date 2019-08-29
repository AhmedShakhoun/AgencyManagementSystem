using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AMS.BL
{
    class Car_category
    {
        public DataTable Get_all_categories()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_all_categories", null);
            DAL.Close();
            return Dt; 
        }
        public DataTable Get_all_dealers()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.Open();
            DataTable dt = new DataTable();
            dt = Dal.SelectData("getAlldealers", null);
            Dal.Close();
            return dt;
        }

        public void add_car(string car_name, int car_price, byte [] car_image, int car_quantity, int cat_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@car_name",SqlDbType.VarChar, 30);
            param[0].Value = car_name;
            param[1] = new SqlParameter("@car_price", SqlDbType.Int);
            param[1].Value = car_price;
            param[2] = new SqlParameter("@car_image", SqlDbType.Image);
            param[2].Value = car_image;
            param[3] = new SqlParameter("@car_quantity", SqlDbType.Int);
            param[3].Value = car_quantity;
            param[4] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[4].Value = cat_id;
            DAL.ExecuteDml("add_car", param);
            DAL.Close();
        }

        public void update_car(string car_name, int car_price, byte[] car_image, int car_quantity, int cat_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@car_name", SqlDbType.VarChar, 30);
            param[0].Value = car_name;
            param[1] = new SqlParameter("@car_price", SqlDbType.Int);
            param[1].Value = car_price;
            param[2] = new SqlParameter("@car_image", SqlDbType.Image);
            param[2].Value = car_image;
            param[3] = new SqlParameter("@car_quantity", SqlDbType.Int);
            param[3].Value = car_quantity;
            param[4] = new SqlParameter("@cat_id", SqlDbType.Int);
            param[4].Value = cat_id;
            DAL.ExecuteDml("update_car", param);
            DAL.Close();
        }
        public DataTable VerifyCarID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerifyCarID", param);
            DAL.Close();
            return Dt;
        }


    }
}

