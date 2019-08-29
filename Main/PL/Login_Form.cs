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
using System.Text.RegularExpressions;
namespace AMS.PL
{
    public partial class Login_Form : Form
    {
        BL.Login log = new BL.Login();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LoginFunc(txtUserName.Text, txtUserPass.Text);

            if (txtUserName.Text == string.Empty|| txtUserPass.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value !");        
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtUserName.Text,"^[a-zA-Z ]+$"))
            {
                MessageBox.Show("User ID is Wrong... please enter character only!");  
                
            }

            else if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "admin")
                {
                    Main_Form.getMainForm.carsMenu.Enabled = true;
                    Main_Form.getMainForm.customersMenu.Enabled = true;
                    Main_Form.getMainForm.usersMenu.Enabled = true;
                    Main_Form.getMainForm.usersMenu.Visible = true;
                    Program.SalesMan = dt.Rows[0]["user_fullname"].ToString();
                    this.Close();
                }

                else if (dt.Rows[0][2].ToString() == "user")
                {
                    Main_Form.getMainForm.carsMenu.Enabled = false;
                    Main_Form.getMainForm.customersMenu.Enabled = true;
                    Main_Form.getMainForm.usersMenu.Visible= false;
                    Program.SalesMan = dt.Rows[0]["user_fullname"].ToString();
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
