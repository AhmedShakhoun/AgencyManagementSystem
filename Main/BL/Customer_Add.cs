using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AMS.BL
{
    class Customer_Add
    {


        public void Add_Customer(string cus_name, string cus_phone, string cus_address)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@cus_name", SqlDbType.VarChar, 50);
            param[0].Value = cus_name;

            param[1] = new SqlParameter("@cus_phone", SqlDbType.VarChar, 50);
            param[1].Value = cus_phone;

            param[2] = new SqlParameter("@cus_address", SqlDbType.VarChar, 50);
            param[2].Value = cus_address;

            
            DAL.ExecuteDml("Add_Customer", param);
          
            DAL.Close();
        }
        public void Edit_Customer(string cus_name, string cus_phone, string cus_address , int cus_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@cus_name", SqlDbType.VarChar, 50);
            param[0].Value = cus_name;

            param[1] = new SqlParameter("@cus_phone", SqlDbType.VarChar, 50);
            param[1].Value = cus_phone;

            param[2] = new SqlParameter("@cus_address", SqlDbType.VarChar, 50);
            param[2].Value = cus_address;

            param[3] = new SqlParameter("@cus_id", SqlDbType.Int);
            param[3].Value = cus_id;
            
            DAL.ExecuteDml("Edit_Customer", param);
            DAL.Close();
        }
        public void Del_Customer( int cus_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cus_id", SqlDbType.Int);
            param[0].Value = cus_id;

            DAL.ExecuteDml("Del_Customer", param);
            DAL.Close();
        }
        public DataTable Get_All_Customers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Customers", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Search_Customer(string criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.VarChar , 50);
            param[0].Value = criterion;
            Dt = DAL.SelectData("Search_Customer", param);
            DAL.Close();
            return Dt;
        }
        public DataTable Verifycus_name(string Name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param[0].Value = Name;
            Dt = DAL.SelectData("VerifyCust_id", param);
            DAL.Close();
            return Dt;
        }
    }
}
