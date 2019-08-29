using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace AMS.PL
{
    public partial class FRM_Categories : Form
    {
        BL.Management_car_categories carcat = new BL.Management_car_categories();
       BindingManagerBase bm;
       
        public FRM_Categories()
        {
            InitializeComponent();
           
            DataTable dt = carcat.get_All_Mgcat();
           bm = this.BindingContext[dt];

            this.dgList.DataSource = dt;

            comBoxDisDealers.DataSource = carcat.getAlldealers();
            comBoxDisDealers.DisplayMember = "deal_name";
            comBoxDisDealers.ValueMember = "deal_id";

            txtDES.DataBindings.Add("text", dt, "Name");
            txtDES.DataBindings[0].WriteValue();
            dgList.DataSource = dt;


        }
     

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete the selected car",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                carcat.DELETE_CATEGORY(Convert.ToInt32(this.dgList.CurrentRow.Cells[1].Value.ToString()));
                MessageBox.Show("Successfully deleted",
                "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgList.DataSource = carcat.get_All_Mgcat();
            }

            else
            {
                MessageBox.Show("Deletion canceled",
              "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
          
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
           txtDES.Clear() ;         
            txtDES.Focus();
            this.dgList.DataSource = carcat.get_All_Mgcat();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BL.Management_car_categories obj = new BL.Management_car_categories();
            DataTable dt = obj.VerifyCatID(txtDES.Text);
         

           if (txtDES.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Description car!");
                btnNew.Enabled = true;
               
            }

          else  if (!System.Text.RegularExpressions.Regex.IsMatch(txtDES.Text, "^[a-zA-Z ]+$"))
            {
                MessageBox.Show("Description car (name) accepts only alphabetical characters");
                btnNew.Enabled = true;
            }


             else if (dt.Rows.Count > 0)
              {
                  MessageBox.Show("this's category already exist");
                  btnNew.Enabled = true;
              }
            else
            {
                carcat.ADD_CATEGORY(txtDES.Text, Convert.ToInt32(comBoxDisDealers.SelectedValue));
                btnNew.Enabled = true;
                btnAdd.Enabled = false;
                MessageBox.Show("Added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgList.DataSource = carcat.get_All_Mgcat();
                btnNew.Enabled = true;
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtDES.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Description car!");
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtDES.Text, "^[a-zA-Z ]+$"))
            {
                MessageBox.Show("This text Description accepts only alphabetical characters");
            }
            else
            {
                carcat.UPDATE_CATEGORY(txtDES.Text, Convert.ToInt32(comBoxDisDealers.SelectedValue), Convert.ToInt32(this.dgList.CurrentRow.Cells[1].Value.ToString()));
                MessageBox.Show("Edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgList.DataSource = carcat.get_All_Mgcat();
            }
        }

        private void dgList_Click(object sender, EventArgs e)
        {
            txtDES.Text = dgList.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnprintAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_cat_management report = new RPT.rpt_cat_management();
            RPT.FRM_RPT_CAR frm = new RPT.FRM_RPT_CAR();
            frm.crystalReportViewer1.ReportSource = report;
            frm.ShowDialog();
        }
    }
}
