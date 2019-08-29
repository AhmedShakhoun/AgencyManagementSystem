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
    public partial class FRM_Car_Management : Form
    {
        BL.Car_Management Cmg = new BL.Car_Management();

        private static FRM_Car_Management frm;
        static void frm_FormClosed(object sender, EventArgs e)
        {
            frm = null;
        }
        public static FRM_Car_Management getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_Car_Management();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_Car_Management()
        {
            InitializeComponent();

            if (frm == null)
            {
                frm = this;
            }
            this.dgGetAllCar.DataSource = Cmg.GET_ALL_CARS();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            
            Dt = Cmg.Searchcar(txtSearch.Text);
            this.dgGetAllCar.DataSource = Dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure delete the selected car",
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Cmg.DeleteCAR(Convert.ToInt32(this.dgGetAllCar.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Successfully deleted",
                "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgGetAllCar.DataSource = Cmg.GET_ALL_CARS();
            }

            else
            {
                MessageBox.Show("Deletion canceled",
              "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Addcar_Form frm = new Addcar_Form();
            frm.ShowDialog();
            this.dgGetAllCar.DataSource = Cmg.GET_ALL_CARS();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Addcar_Form frm = new Addcar_Form();
            frm.cmbboxcarcategory.Text = this.dgGetAllCar.CurrentRow.Cells[0].Value.ToString();
            frm.txtcarname.Text = this.dgGetAllCar.CurrentRow.Cells[1].Value.ToString();
            frm.txtcarprice.Text = this.dgGetAllCar.CurrentRow.Cells[2].Value.ToString();
            frm.txtquantity.Text = this.dgGetAllCar.CurrentRow.Cells[3].Value.ToString();
            frm.Text = "Edit_form";
            frm.btnaccept.Text = "modify";
            frm.state = "update";
            frm.txtcarname.ReadOnly = true;
            byte[] byteImage = (byte[])Cmg.Get_Imagecar(Convert.ToInt32(this.dgGetAllCar.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(byteImage);
            frm.picboxcarimage.Image = Image.FromStream(ms);
            frm.ShowDialog();
            this.dgGetAllCar.DataSource = Cmg.GET_ALL_CARS();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImageCar_Click(object sender, EventArgs e)
        {
            FRM_Preview frm = new FRM_Preview();
            byte[] byteImage = (byte[])Cmg.Get_Imagecar(Convert.ToInt32(this.dgGetAllCar.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(byteImage);
            frm.picpreviewcar.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btnprintCar_Click(object sender, EventArgs e)
        {
            RPT.rpt_All_Car myReport = new RPT.rpt_All_Car();
            RPT.FRM_RPT_CAR myform = new RPT.FRM_RPT_CAR();
            myform.crystalReportViewer1.ReportSource = myReport;
            myform.ShowDialog();
        }
    }
}
