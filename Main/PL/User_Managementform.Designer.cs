namespace AMS.PL
{
    partial class User_Managementform
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
            this.groupBoxoperations = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnmodifyuser = new System.Windows.Forms.Button();
            this.btnDeleteuser = new System.Windows.Forms.Button();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.groupBoxshowusers = new System.Windows.Forms.GroupBox();
            this.dgvGetAllusers = new System.Windows.Forms.DataGridView();
            this.txtSearchuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxoperations.SuspendLayout();
            this.groupBoxshowusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxoperations
            // 
            this.groupBoxoperations.Controls.Add(this.btncancel);
            this.groupBoxoperations.Controls.Add(this.btnmodifyuser);
            this.groupBoxoperations.Controls.Add(this.btnDeleteuser);
            this.groupBoxoperations.Controls.Add(this.btnAdduser);
            this.groupBoxoperations.Location = new System.Drawing.Point(19, 281);
            this.groupBoxoperations.Name = "groupBoxoperations";
            this.groupBoxoperations.Size = new System.Drawing.Size(737, 127);
            this.groupBoxoperations.TabIndex = 7;
            this.groupBoxoperations.TabStop = false;
            this.groupBoxoperations.Text = "Operations available";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(623, 82);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(95, 29);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Exit";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnmodifyuser
            // 
            this.btnmodifyuser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifyuser.Location = new System.Drawing.Point(275, 44);
            this.btnmodifyuser.Name = "btnmodifyuser";
            this.btnmodifyuser.Size = new System.Drawing.Size(93, 32);
            this.btnmodifyuser.TabIndex = 2;
            this.btnmodifyuser.Text = "Modify User";
            this.btnmodifyuser.UseVisualStyleBackColor = true;
            this.btnmodifyuser.Click += new System.EventHandler(this.btnmodifyuser_Click);
            // 
            // btnDeleteuser
            // 
            this.btnDeleteuser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteuser.Location = new System.Drawing.Point(467, 44);
            this.btnDeleteuser.Name = "btnDeleteuser";
            this.btnDeleteuser.Size = new System.Drawing.Size(93, 32);
            this.btnDeleteuser.TabIndex = 1;
            this.btnDeleteuser.Text = "Delete User";
            this.btnDeleteuser.UseVisualStyleBackColor = true;
            this.btnDeleteuser.Click += new System.EventHandler(this.btnDeleteuser_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.Location = new System.Drawing.Point(67, 44);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(93, 32);
            this.btnAdduser.TabIndex = 0;
            this.btnAdduser.Text = "Add User";
            this.btnAdduser.UseVisualStyleBackColor = true;
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // groupBoxshowusers
            // 
            this.groupBoxshowusers.Controls.Add(this.dgvGetAllusers);
            this.groupBoxshowusers.Location = new System.Drawing.Point(19, 86);
            this.groupBoxshowusers.Name = "groupBoxshowusers";
            this.groupBoxshowusers.Size = new System.Drawing.Size(724, 189);
            this.groupBoxshowusers.TabIndex = 6;
            this.groupBoxshowusers.TabStop = false;
            this.groupBoxshowusers.Text = "User List";
            // 
            // dgvGetAllusers
            // 
            this.dgvGetAllusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGetAllusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllusers.Location = new System.Drawing.Point(6, 19);
            this.dgvGetAllusers.Name = "dgvGetAllusers";
            this.dgvGetAllusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGetAllusers.Size = new System.Drawing.Size(712, 164);
            this.dgvGetAllusers.TabIndex = 1;
            // 
            // txtSearchuser
            // 
            this.txtSearchuser.Location = new System.Drawing.Point(309, 38);
            this.txtSearchuser.Name = "txtSearchuser";
            this.txtSearchuser.Size = new System.Drawing.Size(296, 20);
            this.txtSearchuser.TabIndex = 4;
            this.txtSearchuser.TextChanged += new System.EventHandler(this.txtSearchuser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMS.Properties.Resources.Searchsvg;
            this.pictureBox1.Location = new System.Drawing.Point(110, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // User_Managementform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(775, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxoperations);
            this.Controls.Add(this.groupBoxshowusers);
            this.Controls.Add(this.txtSearchuser);
            this.Controls.Add(this.label1);
            this.Name = "User_Managementform";
            this.Text = "User Management";
            this.groupBoxoperations.ResumeLayout(false);
            this.groupBoxshowusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxoperations;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnmodifyuser;
        private System.Windows.Forms.Button btnDeleteuser;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.GroupBox groupBoxshowusers;
        private System.Windows.Forms.TextBox txtSearchuser;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvGetAllusers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}