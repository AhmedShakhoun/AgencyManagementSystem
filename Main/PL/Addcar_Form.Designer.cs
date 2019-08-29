namespace AMS.PL
{
    partial class Addcar_Form
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbbox = new System.Windows.Forms.GroupBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.Btncancle = new System.Windows.Forms.Button();
            this.btnaccept = new System.Windows.Forms.Button();
            this.btnimage = new System.Windows.Forms.Button();
            this.cmbboxcarcategory = new System.Windows.Forms.ComboBox();
            this.picboxcarimage = new System.Windows.Forms.PictureBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtcarprice = new System.Windows.Forms.TextBox();
            this.txtcarname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grbbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcarimage)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grbbox
            // 
            this.grbbox.BackColor = System.Drawing.Color.LightSlateGray;
            this.grbbox.Controls.Add(this.btnnew);
            this.grbbox.Controls.Add(this.Btncancle);
            this.grbbox.Controls.Add(this.btnaccept);
            this.grbbox.Controls.Add(this.btnimage);
            this.grbbox.Controls.Add(this.cmbboxcarcategory);
            this.grbbox.Controls.Add(this.picboxcarimage);
            this.grbbox.Controls.Add(this.txtquantity);
            this.grbbox.Controls.Add(this.txtcarprice);
            this.grbbox.Controls.Add(this.txtcarname);
            this.grbbox.Controls.Add(this.label6);
            this.grbbox.Controls.Add(this.label5);
            this.grbbox.Controls.Add(this.label4);
            this.grbbox.Controls.Add(this.label3);
            this.grbbox.Controls.Add(this.label2);
            this.grbbox.Controls.Add(this.label1);
            this.grbbox.Location = new System.Drawing.Point(14, 14);
            this.grbbox.Name = "grbbox";
            this.grbbox.Size = new System.Drawing.Size(735, 494);
            this.grbbox.TabIndex = 0;
            this.grbbox.TabStop = false;
            this.grbbox.Text = "Adding cars";
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(250, 444);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(121, 43);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Btncancle
            // 
            this.Btncancle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncancle.Location = new System.Drawing.Point(397, 444);
            this.Btncancle.Name = "Btncancle";
            this.Btncancle.Size = new System.Drawing.Size(135, 43);
            this.Btncancle.TabIndex = 13;
            this.Btncancle.Text = "Cancle";
            this.Btncancle.UseVisualStyleBackColor = true;
            this.Btncancle.Click += new System.EventHandler(this.Btncancle_Click);
            // 
            // btnaccept
            // 
            this.btnaccept.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccept.Location = new System.Drawing.Point(94, 444);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(127, 43);
            this.btnaccept.TabIndex = 12;
            this.btnaccept.Text = "Accept";
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // btnimage
            // 
            this.btnimage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimage.Location = new System.Drawing.Point(176, 388);
            this.btnimage.Name = "btnimage";
            this.btnimage.Size = new System.Drawing.Size(139, 27);
            this.btnimage.TabIndex = 11;
            this.btnimage.Text = "Select Car";
            this.btnimage.UseVisualStyleBackColor = true;
            this.btnimage.Click += new System.EventHandler(this.btnimage_Click);
            // 
            // cmbboxcarcategory
            // 
            this.cmbboxcarcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxcarcategory.FormattingEnabled = true;
            this.cmbboxcarcategory.Location = new System.Drawing.Point(162, 59);
            this.cmbboxcarcategory.Name = "cmbboxcarcategory";
            this.cmbboxcarcategory.Size = new System.Drawing.Size(140, 23);
            this.cmbboxcarcategory.TabIndex = 10;
            // 
            // picboxcarimage
            // 
            this.picboxcarimage.Image = global::AMS.Properties.Resources.no_image2;
            this.picboxcarimage.Location = new System.Drawing.Point(145, 242);
            this.picboxcarimage.Name = "picboxcarimage";
            this.picboxcarimage.Size = new System.Drawing.Size(194, 138);
            this.picboxcarimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxcarimage.TabIndex = 9;
            this.picboxcarimage.TabStop = false;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(486, 137);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(116, 22);
            this.txtquantity.TabIndex = 8;
            // 
            // txtcarprice
            // 
            this.txtcarprice.Location = new System.Drawing.Point(486, 60);
            this.txtcarprice.Name = "txtcarprice";
            this.txtcarprice.Size = new System.Drawing.Size(116, 22);
            this.txtcarprice.TabIndex = 7;
            // 
            // txtcarname
            // 
            this.txtcarname.Location = new System.Drawing.Point(162, 137);
            this.txtcarname.Name = "txtcarname";
            this.txtcarname.Size = new System.Drawing.Size(140, 22);
            this.txtcarname.TabIndex = 6;
            this.txtcarname.Validated += new System.EventHandler(this.txtcarname_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Car Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Car Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Car Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car category ";
            // 
            // Addcar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 522);
            this.Controls.Add(this.grbbox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Addcar_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Car";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grbbox.ResumeLayout(false);
            this.grbbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcarimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grbbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btncancle;
        private System.Windows.Forms.Button btnimage;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnaccept;
        public System.Windows.Forms.ComboBox cmbboxcarcategory;
        public System.Windows.Forms.PictureBox picboxcarimage;
        public System.Windows.Forms.TextBox txtquantity;
        public System.Windows.Forms.TextBox txtcarprice;
        public System.Windows.Forms.TextBox txtcarname;
        private System.Windows.Forms.Button btnnew;
    }
}