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
    public partial class Addcar_Form : Form
    {
        public string state = "add";
        BL.Car_category cct = new BL.Car_category();
        BL.Car_Management cmg= new BL.Car_Management();

        public object MessageBoxicon
        {
            get; private set;
        }
        public Addcar_Form()
        {
            InitializeComponent();
            cmbboxcarcategory.DataSource = cct.Get_all_categories();
            cmbboxcarcategory.DisplayMember = "cat_name";
            cmbboxcarcategory.ValueMember = "cat_id";
        }



        private void btnimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File |*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picboxcarimage.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            if (state == "add")

            {
                try
                {


                    if (txtcarname.Text == "" || txtcarprice.Text == "" || txtquantity.Text == "")
                    {

                        MessageBox.Show("There's some information should be Added", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!System.Text.RegularExpressions.Regex.IsMatch(txtcarname.Text, @"^[a-zA-Z0-9]+"))
                    {
                        MessageBox.Show("carname is Wrong... please enter valied character  and number!");

                    }



                    else if (!Regex.IsMatch(txtquantity.Text, "[+-]?([0-9]*[.])?[0-9]+"))
                    {
                        MessageBox.Show("Please Enter Valid quantity", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (!Regex.IsMatch(txtcarprice.Text, "^[0-9]"))
                    {
                        MessageBox.Show("Please Enter Valid car Price", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        picboxcarimage.Image.Save(ms, picboxcarimage.Image.RawFormat);
                        byte[] byteImage = ms.ToArray();
                        cct.add_car(txtcarname.Text, Convert.ToInt32(txtcarprice.Text),
                                    byteImage, Convert.ToInt32(txtquantity.Text),
                                    Convert.ToInt32(cmbboxcarcategory.SelectedValue));
                        MessageBox.Show("Adding Done Successfully  ", "adding ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnaccept.Enabled = false;
                        btnnew.Enabled = true;
                    }

                }

                catch
                {
                    MessageBox.Show("Please check your data carefully", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                picboxcarimage.Image.Save(ms, picboxcarimage.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                if (!Regex.IsMatch(txtcarprice.Text, "^[0-9]"))
                {
                    MessageBox.Show("Please Enter Valid car Price", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
          else { 
                cct.update_car(txtcarname.Text, Convert.ToInt32(txtcarprice.Text),
                byteImage, Convert.ToInt32(txtquantity.Text),
                Convert.ToInt32(cmbboxcarcategory.SelectedValue));
                MessageBox.Show("Editing Done Successfully  ", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_Car_Management.getMainForm.dgGetAllCar.DataSource = cmg.GET_ALL_CARS();
                }
            }

        }


        private void Btncancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtquantity.Clear();
            txtcarname.Clear();
            txtcarprice.Clear();
            btnnew.Enabled = false;
            btnaccept.Enabled = true;
        }

        private void txtcarname_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                BL.Car_category obj = new BL.Car_category();
                DataTable dt = new DataTable();
                dt = obj.VerifyCarID(txtcarname.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This is Car Already Exist", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcarname.Focus();
                    txtcarname.SelectionStart = 0;
                    txtcarname.SelectionLength = txtcarname.TextLength;
                    return;
                }
            }
        }
    }
}

