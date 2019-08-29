namespace AMS.PL
{
    partial class AddCust_Form
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
            this.grpBoxaddcust = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcustphone = new System.Windows.Forms.TextBox();
            this.txtcustadress = new System.Windows.Forms.TextBox();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbbxsearch = new System.Windows.Forms.GroupBox();
            this.dgvcustomer = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpBoxaddcust.SuspendLayout();
            this.grbbxsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxaddcust
            // 
            this.grpBoxaddcust.Controls.Add(this.btnexit);
            this.grpBoxaddcust.Controls.Add(this.btnremove);
            this.grpBoxaddcust.Controls.Add(this.btnedit);
            this.grpBoxaddcust.Controls.Add(this.btnnew);
            this.grpBoxaddcust.Controls.Add(this.btnadd);
            this.grpBoxaddcust.Controls.Add(this.txtcustphone);
            this.grpBoxaddcust.Controls.Add(this.txtcustadress);
            this.grpBoxaddcust.Controls.Add(this.txtcustname);
            this.grpBoxaddcust.Controls.Add(this.label3);
            this.grpBoxaddcust.Controls.Add(this.label2);
            this.grpBoxaddcust.Controls.Add(this.label1);
            this.grpBoxaddcust.Location = new System.Drawing.Point(14, 14);
            this.grpBoxaddcust.Name = "grpBoxaddcust";
            this.grpBoxaddcust.Size = new System.Drawing.Size(451, 471);
            this.grpBoxaddcust.TabIndex = 0;
            this.grpBoxaddcust.TabStop = false;
            this.grpBoxaddcust.Text = "Adding  Customer";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(341, 414);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(90, 32);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(217, 353);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(104, 36);
            this.btnremove.TabIndex = 9;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(328, 353);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(103, 36);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(8, 353);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(103, 36);
            this.btnnew.TabIndex = 7;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(118, 353);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 36);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcustphone
            // 
            this.txtcustphone.Location = new System.Drawing.Point(206, 129);
            this.txtcustphone.Name = "txtcustphone";
            this.txtcustphone.Size = new System.Drawing.Size(207, 22);
            this.txtcustphone.TabIndex = 5;
            this.txtcustphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustphone_KeyDown);
            // 
            // txtcustadress
            // 
            this.txtcustadress.Location = new System.Drawing.Point(206, 208);
            this.txtcustadress.Name = "txtcustadress";
            this.txtcustadress.Size = new System.Drawing.Size(207, 22);
            this.txtcustadress.TabIndex = 4;
            this.txtcustadress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustadress_KeyDown);
            // 
            // txtcustname
            // 
            this.txtcustname.Location = new System.Drawing.Point(206, 61);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(207, 22);
            this.txtcustname.TabIndex = 3;
            this.txtcustname.TextChanged += new System.EventHandler(this.txtcustname_TextChanged);
            this.txtcustname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustname_KeyDown);
            this.txtcustname.Validated += new System.EventHandler(this.txtcustname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // grbbxsearch
            // 
            this.grbbxsearch.Controls.Add(this.dgvcustomer);
            this.grbbxsearch.Controls.Add(this.txtsearch);
            this.grbbxsearch.Controls.Add(this.btnAccept);
            this.grbbxsearch.Controls.Add(this.lblSearch);
            this.grbbxsearch.Location = new System.Drawing.Point(472, 14);
            this.grbbxsearch.Name = "grbbxsearch";
            this.grbbxsearch.Size = new System.Drawing.Size(304, 471);
            this.grbbxsearch.TabIndex = 1;
            this.grbbxsearch.TabStop = false;
            this.grbbxsearch.Text = "Customer Search";
            // 
            // dgvcustomer
            // 
            this.dgvcustomer.AllowUserToAddRows = false;
            this.dgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomer.Location = new System.Drawing.Point(7, 148);
            this.dgvcustomer.MultiSelect = false;
            this.dgvcustomer.Name = "dgvcustomer";
            this.dgvcustomer.ReadOnly = true;
            this.dgvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcustomer.Size = new System.Drawing.Size(266, 218);
            this.dgvcustomer.TabIndex = 4;
            this.dgvcustomer.DoubleClick += new System.EventHandler(this.dglist_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(78, 74);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(139, 22);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(225, 72);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(72, 27);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(10, 77);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "search";
            // 
            // AddCust_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(791, 498);
            this.Controls.Add(this.grbbxsearch);
            this.Controls.Add(this.grpBoxaddcust);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "AddCust_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.grpBoxaddcust.ResumeLayout(false);
            this.grpBoxaddcust.PerformLayout();
            this.grbbxsearch.ResumeLayout(false);
            this.grbbxsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxaddcust;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcustphone;
        private System.Windows.Forms.TextBox txtcustadress;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbbxsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dgvcustomer;
    }
}