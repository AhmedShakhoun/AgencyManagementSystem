using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace AMS.BL
{
    class Orders
    {
        public DataTable get_last_order_id()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("get_last_order_id", null);
            DAL.Close();
            return Dt;
        }

        public DataTable get_last_order_forprint()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("get_last_order_forprint", null);
            DAL.Close();
            return Dt;
        }

        public void Add_Order(DateTime order_date,int cus_id,string order_descrip,string salesman)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@order_date", SqlDbType.DateTime);
            param[0].Value = order_date;
            param[1] = new SqlParameter("@cus_id", SqlDbType.Int);
            param[1].Value = cus_id;
            param[2] = new SqlParameter("@order_desciption", SqlDbType.VarChar, 200);
            param[2].Value = order_descrip;
            param[3] = new SqlParameter("@salesman", SqlDbType.VarChar, 75);
            param[3].Value = salesman;
            DAL.ExecuteDml("Add_Order", param);
            DAL.Close();
        }
        public void Add_Order_details(int car_id, int order_id, int quantity, int price,float discount,string amount,string totamount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@car_id", SqlDbType.Int);
            param[0].Value = car_id;
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;
            param[2] = new SqlParameter("@quantity", SqlDbType.Int);
            param[2].Value = quantity;
            param[3] = new SqlParameter("@price", SqlDbType.Int);
            param[3].Value = price;
            param[4] = new SqlParameter("@discount", SqlDbType.Float);
            param[4].Value = discount;
            param[5] = new SqlParameter("@amount", SqlDbType.NVarChar, 50);
            param[5].Value = amount;
            param[6] = new SqlParameter("@total_amount", SqlDbType.NVarChar, 50);
            param[6].Value = totamount;
            DAL.ExecuteDml("Add_Order_details", param);
            DAL.Close();
        }
        public DataTable verifyQuantity(int car_id,int quanentered)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@car_id",SqlDbType.Int);
            param[0].Value=car_id;
            param[1] = new SqlParameter("@quantity_entered", SqlDbType.Int);
            param[1].Value = quanentered;
            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("verifyQuantity", param);
            DAL.Close();
            return Dt;
        }

        //public DataTable generate_invoice(int order_id)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@order_id", SqlDbType.Int);
        //    param[0].Value = order_id;         
        //    DAL.Open();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.SelectData("generate_invoice", param);
        //    DAL.Close();
        //    return Dt;
        //}
    }
}
