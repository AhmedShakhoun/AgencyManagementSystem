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
    public partial class User_Managementform : Form
    {
        BL.Login log = new BL.Login();
        private static User_Managementform frm;

        static void frm_FormClosed(object sender, EventArgs e)
        {
            frm = null;
        }
        public static User_Managementform getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new User_Managementform();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public User_Managementform()
        {
            InitializeComponent();
            if (frm == null)
            {
                frm = this;
            }
            dgvGetAllusers.DataSource = log.SearchUsers("");

        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            Adduser_Form addnewuser = new Adduser_Form();
            addnewuser.btnadduser.Text = "Save User";
            addnewuser.ShowDialog();
            dgvGetAllusers.DataSource = log.SearchUsers("");
        }

        private void btnmodifyuser_Click(object sender, EventArgs e)
        {
            Adduser_Form addnewuser = new Adduser_Form();
            addnewuser.txtuserid.Text = dgvGetAllusers.CurrentRow.Cells[0].Value.ToString();
            addnewuser.txtuserpass.Text = dgvGetAllusers.CurrentRow.Cells[1].Value.ToString();
            addnewuser.txtuserpassconfirm.Text = dgvGetAllusers.CurrentRow.Cells[1].Value.ToString();
            addnewuser.comboxusertype.Text = dgvGetAllusers.CurrentRow.Cells[2].Value.ToString();
            addnewuser.txtusername.Text = dgvGetAllusers.CurrentRow.Cells[3].Value.ToString();
            addnewuser.btnadduser.Text = "Modify User";
            addnewuser.state = "update";
            addnewuser.ShowDialog();
            dgvGetAllusers.DataSource = log.SearchUsers("");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchuser_TextChanged(object sender, EventArgs e)
        {
            dgvGetAllusers.DataSource = log.SearchUsers(txtSearchuser.Text);
        }

        private void btnDeleteuser_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete this user!","delete user",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                log.Delete_user(dgvGetAllusers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("User Deleted Successfully");
                dgvGetAllusers.DataSource = log.SearchUsers("");

            }
        }
    }
}
