using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AMS.PL
{
    public partial class Adduser_Form : Form
    {
        public string state = "add";
        public Adduser_Form()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
            

        }

        private void btnadduser_Click(object sender, EventArgs e)
        {

            if (btnadduser.Text == "Save User" || btnadduser.Text == "ADD NEW USER")
            {
                if (txtuserid.Text != string.Empty && txtusername.Text != string.Empty && txtuserpass.Text != string.Empty && comboxusertype.Text != string.Empty)
                {

                    if (txtuserpass.Text == txtuserpassconfirm.Text)
                    {
                        if (!Regex.IsMatch(txtuserid.Text, "^[a-zA-Z ]+$"))
                        {
                            MessageBox.Show("User ID is wrong", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else if (!Regex.IsMatch(txtusername.Text, "^[a-zA-Z ]+$"))
                        {
                            MessageBox.Show("Name is wrong", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        BL.Login useradd = new BL.Login();
                        useradd.ADD_User(txtuserid.Text, txtuserpass.Text, comboxusertype.Text, txtusername.Text);
                        MessageBox.Show("User Added successfully", "Add Another one", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtuserid.Clear();
                        txtuserpass.Clear();
                        txtuserpassconfirm.Clear();
                        txtusername.Clear();
                        txtuserid.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all data");
                    return;
                }
            }
            else if (btnadduser.Text == "Modify User")
            {
                if (txtuserid.Text != string.Empty && txtusername.Text != string.Empty && txtuserpass.Text != string.Empty && comboxusertype.Text != string.Empty)
                {
                    if (txtuserpass.Text == txtuserpassconfirm.Text)
                    {
                        if (!Regex.IsMatch(txtuserid.Text, "^[a-zA-Z ]+$"))
                        {
                            MessageBox.Show("User ID is wrong", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        else if (!Regex.IsMatch(txtusername.Text, "^[a-zA-Z ]+$"))
                        {
                            MessageBox.Show("Name is wrong", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        BL.Login useradd = new BL.Login();
                        useradd.Edit_user(txtuserid.Text, txtuserpass.Text, comboxusertype.Text, txtusername.Text);
                        MessageBox.Show("User Edit Successfully", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtuserid.Clear();
                        txtuserpass.Clear();
                        txtuserpassconfirm.Clear();
                        txtusername.Clear();
                        txtuserid.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Please fill all data");
                    return;
                }
            }

        }
        
        private void CheckPassword(object sender, EventArgs e)
        {
            if(txtuserpass.Text != txtuserpassconfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
        }

        private void txtuserid_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                BL.Login obj = new BL.Login();
                DataTable dt = new DataTable();
                dt = obj.Verifyuser_id(txtuserid.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This is name Already Exist", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtuserid.Focus();
                     txtuserid.SelectionStart = 0;
                     txtuserid.SelectionLength = txtuserid.TextLength;
                    return;
                }
            }
        }
    }
        }
    

