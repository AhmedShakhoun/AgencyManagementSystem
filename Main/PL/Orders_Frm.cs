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
    public partial class Orders_Frm : Form
    {
        BL.Orders orders = new BL.Orders();
        DataTable datatab = new DataTable();
        void calculateAmount()
        {
            if (txtcarprice.Text != string.Empty && txtcarquantity.Text != string.Empty)
            {

            int amount = Convert.ToInt32(this.txtcarprice.Text) * Convert.ToInt32(this.txtcarquantity.Text);
            txtamount.Text = amount.ToString();

            }
        }
        void calculateTotalAmount()
        {
            if(txtdiscount.Text != string.Empty && txtamount.Text != string.Empty)
            { 
            double discount=Convert.ToDouble(txtdiscount.Text);
            double amount = Convert.ToDouble(txtamount.Text);
            double totamount=amount-(amount*(discount/100));
            txttotamount.Text = totamount.ToString();
            }
        }
        void CreateDataTable()
        {
            datatab.Columns.Add("Car id");
            datatab.Columns.Add("Car Name");
            datatab.Columns.Add("Price");
            datatab.Columns.Add("Quantity");
            datatab.Columns.Add("Amount");
            datatab.Columns.Add("Discount Percentage(%)");
            datatab.Columns.Add("Total Amount");
            dgvshoworderdetail.DataSource = datatab;
           
        }
        void ClearInputs()
        {
            txtcarid.Clear();
            txtcarname.Clear();
            txtcarprice.Clear();
            txtcarquantity.Clear();
            txtamount.Clear();
            txtdiscount.Clear();
            txttotamount.Clear();
            btnshowcars.Focus();
        }
        void ClearData()
        {
            txtorderNum.Clear();
            txtOrderDES.Clear();
            dateoforder.ResetText();
            txtselname.Clear();
            txtcusid.Clear();
            txtcusname.Clear();
            txtcusphone.Clear();
            txtcusAdd.Clear();
            ClearInputs();
            datatab.Clear();
            dgvshoworderdetail.DataSource = null;
            txtfinalsalary.Clear();
            btnsaveorder.Enabled = false;
            btnneworder.Enabled = true;
        }
        void CalculateFinalSalary()
        {
            txtfinalsalary.Text = (from DataGridViewRow r in dgvshoworderdetail.Rows
                                   where r.Cells[6].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(r.Cells[6].FormattedValue)).Sum().ToString();
        }
       //void ResizeDgv()
       // {

        //     this.dgvshoworderdetail.RowHeadersWidth = 89;
        //     this.dgvshoworderdetail.Columns[0].Width = 93;
        //     this.dgvshoworderdetail.Columns[1].Width = 93;
        //     this.dgvshoworderdetail.Columns[2].Width = 93;
        //     this.dgvshoworderdetail.Columns[3].Width = 93;
        //     this.dgvshoworderdetail.Columns[4].Width = 93;
        //     this.dgvshoworderdetail.Columns[5].Width = 125;
        //     this.dgvshoworderdetail.Columns[6].Width = 93;      
       // }
       
        public Orders_Frm()
        {
           
            InitializeComponent();
            CreateDataTable();
            txtselname.Text = Program.SalesMan;
          //  ResizeDgv();
        }
  
        private void btnneworder_Click(object sender, EventArgs e)
        {
            this.txtorderNum.Text = orders.get_last_order_id().Rows[0][0].ToString();
            btnneworder.Enabled = false;
            btnprintinvoice.Enabled = false;
            btnsaveorder.Enabled = true;
        }

        private void btncusshow_Click(object sender, EventArgs e)
        {
            CustomerList_Frm cuslist = new CustomerList_Frm();
            cuslist.ShowDialog();
            this.txtcusid.Text = cuslist.dgvcuslist.CurrentRow.Cells[0].Value.ToString();
            this.txtcusname.Text = cuslist.dgvcuslist.CurrentRow.Cells[1].Value.ToString();
            this.txtcusphone.Text = cuslist.dgvcuslist.CurrentRow.Cells[2].Value.ToString();
            this.txtcusAdd.Text = cuslist.dgvcuslist.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnprintinvoice_Click(object sender, EventArgs e)
        {
            //get  the last order

           

            int order_id = Convert.ToInt32(orders.get_last_order_forprint().Rows[0][0]);
            RPT.rpt_orders report = new RPT.rpt_orders();
            RPT.FRM_RPT_CAR frm = new RPT.FRM_RPT_CAR();
            report.SetParameterValue("@order_id", order_id);
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();


        }

        private void btnshowcars_Click(object sender, EventArgs e)
        {
            ClearInputs();
            CarListForm carlisform = new CarListForm();
            carlisform.ShowDialog();
            txtcarid.Text = carlisform.dgvshowcars.CurrentRow.Cells[0].Value.ToString();
            txtcarname.Text = carlisform.dgvshowcars.CurrentRow.Cells[1].Value.ToString();
            txtcarprice.Text = carlisform.dgvshowcars.CurrentRow.Cells[2].Value.ToString();
            txtcarquantity.Focus();
            

        }

        private void txtcarquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void txtcarprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtcarprice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtcarprice.Text != string.Empty)
            {
                txtcarquantity.Focus();
            }
        }

        private void txtcarquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtcarquantity.Text != string.Empty)
            {
                txtdiscount.Focus();
            }
        }

        private void txtcarprice_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void txtcarquantity_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            calculateTotalAmount();
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if(orders.verifyQuantity(Convert.ToInt32(txtcarid.Text),Convert.ToInt32(txtcarquantity.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("This quantity not availabel for this car");
                    return;
                }

                for (int i = 0; i < dgvshoworderdetail.Rows.Count-1; i++)
                {
                   if(dgvshoworderdetail.Rows[i].Cells[0].Value.ToString() == txtcarid.Text)
                   {
                       MessageBox.Show("This Record Already Exists");
                       return;
                   }
                }

                DataRow row = datatab.NewRow();
                row[0] = txtcarid.Text;
                row[1] = txtcarname.Text;
                row[2] = txtcarprice.Text;
                row[3] = txtcarquantity.Text;
                row[4] = txtamount.Text;
                row[5] = txtdiscount.Text;
                row[6] = txttotamount.Text;
                datatab.Rows.Add(row);
                dgvshoworderdetail.DataSource = datatab;
                ClearInputs();
                //txtfinalsalary.Text=(from DataGridViewRow r in dgvshoworderdetail.Rows
                //                   where r.Cells[6].FormattedValue.ToString() != string.Empty 
                //                   select Convert.ToDouble(r.Cells[6].FormattedValue)).Sum().ToString();
                CalculateFinalSalary();
            }
        }

        private void dgvshoworderdetail_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtcarid.Text = this.dgvshoworderdetail.CurrentRow.Cells[0].Value.ToString();
                txtcarname.Text = this.dgvshoworderdetail.CurrentRow.Cells[1].Value.ToString();
                txtcarprice.Text = this.dgvshoworderdetail.CurrentRow.Cells[2].Value.ToString();
                txtcarquantity.Text = this.dgvshoworderdetail.CurrentRow.Cells[3].Value.ToString();
                txtamount.Text = this.dgvshoworderdetail.CurrentRow.Cells[4].Value.ToString();
                txtdiscount.Text = this.dgvshoworderdetail.CurrentRow.Cells[5].Value.ToString();
                txttotamount.Text = this.dgvshoworderdetail.CurrentRow.Cells[6].Value.ToString();
                this.dgvshoworderdetail.Rows.RemoveAt(dgvshoworderdetail.CurrentRow.Index);
                txtcarquantity.Focus();
            }
            catch
            {
                return;
            }
        }

        private void dgvshoworderdetail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateFinalSalary();
        }

        private void updatedgvItems_Click(object sender, EventArgs e)
        {
            dgvshoworderdetail_DoubleClick(sender, e);
        }

        private void deleteCurrentRowindgv_Click(object sender, EventArgs e)
        {
            this.dgvshoworderdetail.Rows.RemoveAt(dgvshoworderdetail.CurrentRow.Index);
        }

        private void deleteAllRowsindgv_Click(object sender, EventArgs e)
        {
            datatab.Clear();
            dgvshoworderdetail.Refresh();
        }

        private void btnsaveorder_Click(object sender, EventArgs e)
        {   
            
            if(txtorderNum.Text == string.Empty || txtcusid.Text == string.Empty || dgvshoworderdetail.Rows.Count < 1 || txtOrderDES.Text == string.Empty)
            {
                MessageBox.Show("You must enter all data to make order and print invoice");
                return;
            }
            // Add order
            orders.Add_Order(dateoforder.Value, Convert.ToInt32(txtcusid.Text), txtOrderDES.Text, txtselname.Text);
            // Add order details first add in dgv and after this add values in db
            for (int i = 0; i < dgvshoworderdetail.Rows.Count-1; i++)
            {
                orders.Add_Order_details(Convert.ToInt32(dgvshoworderdetail.Rows[i].Cells[0].Value), Convert.ToInt32(txtorderNum.Text),
                Convert.ToInt32(dgvshoworderdetail.Rows[i].Cells[3].Value), Convert.ToInt32(dgvshoworderdetail.Rows[i].Cells[2].Value),
                float.Parse(dgvshoworderdetail.Rows[i].Cells[5].Value.ToString()), dgvshoworderdetail.Rows[i].Cells[4].Value.ToString(), dgvshoworderdetail.Rows[i].Cells[6].Value.ToString());
            }
            MessageBox.Show("Data Saved successfully", "Saved Process", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
            btnprintinvoice.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
