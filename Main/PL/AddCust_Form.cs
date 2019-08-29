using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace AMS.PL
{
    public partial class AddCust_Form : Form
    {
       // public string state = "add";
        BL.Customer_Add cust = new BL.Customer_Add();
        int cus_id;
        public AddCust_Form()
        {
            InitializeComponent();
            this.dgvcustomer.DataSource = cust.Get_All_Customers();
            dgvcustomer.Columns[0].Visible = false;
        }



        private void btnadd_Click(object sender, EventArgs e)

        {
            
            try
            {

               
                Regex r = new Regex(@"^[0-9]{11}$");
                if (txtcustname.Text == "" || txtcustphone.Text == "" || txtcustadress.Text == "")
                {
                    MessageBox.Show("There's some information should be added", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (r.IsMatch(txtcustphone.Text) == false)
                {
                    MessageBox.Show("Phone is Wrong", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!Regex.IsMatch(txtcustname.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Name is wrong", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcustname.Text.Remove(txtcustname.Text.Length - 1);
                }

                else
                {
                    BL.Customer_Add obj = new BL.Customer_Add();
                    DataTable dt = new DataTable();
                    dt = obj.Verifycus_name(txtcustname.Text);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("This's Customer Already Founded", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtcustname.Focus();
                        return;
                    }
                    cust.Add_Customer(txtcustname.Text, txtcustphone.Text, txtcustadress.Text);
                    MessageBox.Show("Adding Done Successfully", "adding ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvcustomer.DataSource = cust.Get_All_Customers();
                    btnadd.Enabled = false;
                    btnnew.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("There's some information should be added", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtcustname.Clear();
            txtcustphone.Clear();
            txtcustadress.Clear();
            txtcustname.Focus();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcustname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcustphone.Focus();
            }
        }

        private void txtcustphone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcustadress.Focus();
            }
        }

        private void txtcustadress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd.Focus();
            }
        }

        private void dglist_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                cus_id = Convert.ToInt32(dgvcustomer.CurrentRow.Cells[0].Value);
                this.txtcustname.Text = dgvcustomer.CurrentRow.Cells[1].Value.ToString();
                this.txtcustphone.Text = dgvcustomer.CurrentRow.Cells[2].Value.ToString();
                this.txtcustadress.Text = dgvcustomer.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                Regex r = new Regex(@"^[0-9]{11}$");             

                if (txtcustname.Text == "" || txtcustphone.Text == "" || txtcustadress.Text == "")
                {
                    MessageBox.Show("There's some information should be Edited", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (r.IsMatch(txtcustphone.Text) == false)
                {
                    MessageBox.Show("Phone is Wrong", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!Regex.IsMatch(txtcustname.Text, "^[a-zA-Z ]+$"))
                {
                    MessageBox.Show("Name is wrong", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }

                else
                {
                    cust.Edit_Customer(txtcustname.Text, txtcustphone.Text, txtcustadress.Text, cus_id);
                    MessageBox.Show("Editing Done Successfully  ", "Editing ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvcustomer.DataSource = cust.Get_All_Customers();
                }
                
            }
            catch
            {
                return;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete the selected customers",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cust.Del_Customer(Convert.ToInt32(this.dgvcustomer.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Successfully deleted",
                "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvcustomer.DataSource = cust.Get_All_Customers();
            }

            else
            {
                MessageBox.Show("Deletion canceled",
              "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            dgvcustomer.DataSource = cust.Search_Customer(txtsearch.Text);
        }

        private void txtcustname_TextChanged(object sender, EventArgs e)
        {
            //if (state == "add")
            //{

            //    BL.Customer_Add obj = new BL.Customer_Add();
            //    DataTable dt = new DataTable();
            //    dt = obj.Verifycus_name(txtcustname.Text);
            //    if (dt.Rows.Count > 0)
            //    {
            //        MessageBox.Show("This 's Customer Already Founded", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtcustname.Focus();
            //        txtcustname.SelectionStart = 0;
            //        txtcustname.SelectionLength = txtcustname.TextLength;
            //    }
            //}
        }
    }
}
