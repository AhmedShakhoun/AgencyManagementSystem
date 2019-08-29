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
    public partial class Main_Form : Form
    {
        static Main_Form frm;

        static void formClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Main_Form getMainForm
        {
            get
            {
                if(frm == null)
                {
                    frm = new Main_Form();
                    frm.FormClosed += new FormClosedEventHandler(formClosed);
                }
                return frm;
            } 
        }
        public Main_Form()
        {

            if(frm==null)
            {
                frm = this;
            }

            InitializeComponent();
            this.carsMenu.Enabled = false;
            this.customersMenu.Enabled = false;
            this.usersMenu.Enabled = false;
        }

        private void loginFrm_Click(object sender, EventArgs e)
        {
            Login_Form logform = new Login_Form();
            logform.ShowDialog();
        }

        private void addNewCarForm_Click(object sender, EventArgs e)
        {
            Addcar_Form addform = new Addcar_Form();
            addform.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewUserfrm_Click(object sender, EventArgs e)
        {
            Adduser_Form adduserfrm = new Adduser_Form();
            adduserfrm.ShowDialog();
        }

        private void carManagmentfrmcarmanagment_Click(object sender, EventArgs e)
        {
            FRM_Car_Management formcarman = new FRM_Car_Management();
            formcarman.ShowDialog();
        }

        private void carBrandManagementcarbrandmanagment_Click(object sender, EventArgs e)
        {
            FRM_Categories formcat = new FRM_Categories();
            formcat.ShowDialog();
        }

     
        

        private void customerManagementform_Click(object sender, EventArgs e)
        {
            PL.AddCust_Form cusmanage = new AddCust_Form();
            cusmanage.ShowDialog();

        }

        private void orderManagementfrm_Click(object sender, EventArgs e)
        {
            Orders_Frm ordfrm = new Orders_Frm();
            ordfrm.ShowDialog();
        }

        private void userManagementForm_Click(object sender, EventArgs e)
        {
            User_Managementform usermanfrm = new User_Managementform();
            usermanfrm.ShowDialog();
        } 

    }
}
