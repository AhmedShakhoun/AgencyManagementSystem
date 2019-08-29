namespace AMS.PL
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFrm = new System.Windows.Forms.ToolStripMenuItem();
            this.logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.carsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarForm = new System.Windows.Forms.ToolStripMenuItem();
            this.carManagmentfrmcarmanagment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.carBrandManagementcarbrandmanagment = new System.Windows.Forms.ToolStripMenuItem();
            this.customersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementform = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderManagementfrm = new System.Windows.Forms.ToolStripMenuItem();
            this.usersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserfrm = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.carsMenu,
            this.customersMenu,
            this.usersMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFrm,
            this.logOut});
            this.fileMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(49, 25);
            this.fileMenu.Text = "File";
            // 
            // loginFrm
            // 
            this.loginFrm.Name = "loginFrm";
            this.loginFrm.Size = new System.Drawing.Size(115, 22);
            this.loginFrm.Text = "Log in";
            this.loginFrm.Click += new System.EventHandler(this.loginFrm_Click);
            // 
            // logOut
            // 
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(115, 22);
            this.logOut.Text = "Log out";
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // carsMenu
            // 
            this.carsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarForm,
            this.carManagmentfrmcarmanagment,
            this.toolStripSeparator1,
            this.carBrandManagementcarbrandmanagment});
            this.carsMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsMenu.Name = "carsMenu";
            this.carsMenu.Size = new System.Drawing.Size(54, 25);
            this.carsMenu.Text = "Cars";
            // 
            // addNewCarForm
            // 
            this.addNewCarForm.Name = "addNewCarForm";
            this.addNewCarForm.Size = new System.Drawing.Size(200, 22);
            this.addNewCarForm.Text = "Add New Car";
            this.addNewCarForm.Click += new System.EventHandler(this.addNewCarForm_Click);
            // 
            // carManagmentfrmcarmanagment
            // 
            this.carManagmentfrmcarmanagment.Name = "carManagmentfrmcarmanagment";
            this.carManagmentfrmcarmanagment.Size = new System.Drawing.Size(200, 22);
            this.carManagmentfrmcarmanagment.Text = "Car Managment";
            this.carManagmentfrmcarmanagment.Click += new System.EventHandler(this.carManagmentfrmcarmanagment_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // carBrandManagementcarbrandmanagment
            // 
            this.carBrandManagementcarbrandmanagment.Name = "carBrandManagementcarbrandmanagment";
            this.carBrandManagementcarbrandmanagment.Size = new System.Drawing.Size(200, 22);
            this.carBrandManagementcarbrandmanagment.Text = "Car Brand Management";
            this.carBrandManagementcarbrandmanagment.Click += new System.EventHandler(this.carBrandManagementcarbrandmanagment_Click);
            // 
            // customersMenu
            // 
            this.customersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerManagementform,
            this.toolStripSeparator2,
            this.orderManagementfrm});
            this.customersMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersMenu.Name = "customersMenu";
            this.customersMenu.Size = new System.Drawing.Size(102, 25);
            this.customersMenu.Text = "Customers";
            // 
            // customerManagementform
            // 
            this.customerManagementform.Name = "customerManagementform";
            this.customerManagementform.Size = new System.Drawing.Size(200, 22);
            this.customerManagementform.Text = "Customer Management";
            this.customerManagementform.Click += new System.EventHandler(this.customerManagementform_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // orderManagementfrm
            // 
            this.orderManagementfrm.Name = "orderManagementfrm";
            this.orderManagementfrm.Size = new System.Drawing.Size(200, 22);
            this.orderManagementfrm.Text = "Order Management";
            this.orderManagementfrm.Click += new System.EventHandler(this.orderManagementfrm_Click);
            // 
            // usersMenu
            // 
            this.usersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserfrm,
            this.userManagementForm});
            this.usersMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersMenu.Name = "usersMenu";
            this.usersMenu.Size = new System.Drawing.Size(63, 25);
            this.usersMenu.Text = "Users";
            // 
            // addNewUserfrm
            // 
            this.addNewUserfrm.Name = "addNewUserfrm";
            this.addNewUserfrm.Size = new System.Drawing.Size(171, 22);
            this.addNewUserfrm.Text = "Add New User";
            this.addNewUserfrm.Click += new System.EventHandler(this.addNewUserfrm_Click);
            // 
            // userManagementForm
            // 
            this.userManagementForm.Name = "userManagementForm";
            this.userManagementForm.Size = new System.Drawing.Size(171, 22);
            this.userManagementForm.Text = "User Management";
            this.userManagementForm.Click += new System.EventHandler(this.userManagementForm_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMS.Properties.Resources.Banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 254);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agency Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem loginFrm;
        private System.Windows.Forms.ToolStripMenuItem logOut;
        private System.Windows.Forms.ToolStripMenuItem addNewCarForm;
        private System.Windows.Forms.ToolStripMenuItem carManagmentfrmcarmanagment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem carBrandManagementcarbrandmanagment;
        private System.Windows.Forms.ToolStripMenuItem customerManagementform;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem orderManagementfrm;
        private System.Windows.Forms.ToolStripMenuItem addNewUserfrm;
        private System.Windows.Forms.ToolStripMenuItem userManagementForm;
        public System.Windows.Forms.ToolStripMenuItem carsMenu;
        public System.Windows.Forms.ToolStripMenuItem customersMenu;
        public System.Windows.Forms.ToolStripMenuItem usersMenu;
    }
}