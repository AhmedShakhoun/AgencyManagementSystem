using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS.PL
{
    public partial class CustomerList_Frm : Form
    {
        BL.Customer_Add cusadd = new BL.Customer_Add();
        public CustomerList_Frm()
        {
            InitializeComponent();
            this.dgvcuslist.DataSource = cusadd.Get_All_Customers();
            this.dgvcuslist.Columns[0].Visible = false;

        }

        private void dgvcuslist_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
