namespace AMS.PL
{
    partial class Orders_Frm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtselname = new System.Windows.Forms.TextBox();
            this.dateoforder = new System.Windows.Forms.DateTimePicker();
            this.txtOrderDES = new System.Windows.Forms.TextBox();
            this.txtorderNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.btncusshow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcusAdd = new System.Windows.Forms.TextBox();
            this.txtcusphone = new System.Windows.Forms.TextBox();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txttotamount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcarquantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcarprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcarname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcarid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvshoworderdetail = new System.Windows.Forms.DataGridView();
            this.conmenstripfordgvorderdetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updatedgvItems = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentRowindgv = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllRowsindgv = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfinalsalary = new System.Windows.Forms.TextBox();
            this.btnshowcars = new System.Windows.Forms.Button();
            this.btnneworder = new System.Windows.Forms.Button();
            this.btnsaveorder = new System.Windows.Forms.Button();
            this.btnprintinvoice = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshoworderdetail)).BeginInit();
            this.conmenstripfordgvorderdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtselname);
            this.groupBox1.Controls.Add(this.dateoforder);
            this.groupBox1.Controls.Add(this.txtOrderDES);
            this.groupBox1.Controls.Add(this.txtorderNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seller Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Order Desciption";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order Num";
            // 
            // txtselname
            // 
            this.txtselname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtselname.Location = new System.Drawing.Point(155, 186);
            this.txtselname.Name = "txtselname";
            this.txtselname.ReadOnly = true;
            this.txtselname.Size = new System.Drawing.Size(134, 20);
            this.txtselname.TabIndex = 6;
            // 
            // dateoforder
            // 
            this.dateoforder.Location = new System.Drawing.Point(155, 143);
            this.dateoforder.Name = "dateoforder";
            this.dateoforder.Size = new System.Drawing.Size(200, 20);
            this.dateoforder.TabIndex = 5;
            // 
            // txtOrderDES
            // 
            this.txtOrderDES.Location = new System.Drawing.Point(155, 73);
            this.txtOrderDES.Multiline = true;
            this.txtOrderDES.Name = "txtOrderDES";
            this.txtOrderDES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderDES.Size = new System.Drawing.Size(262, 51);
            this.txtOrderDES.TabIndex = 4;
            // 
            // txtorderNum
            // 
            this.txtorderNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtorderNum.Location = new System.Drawing.Point(155, 35);
            this.txtorderNum.Name = "txtorderNum";
            this.txtorderNum.ReadOnly = true;
            this.txtorderNum.Size = new System.Drawing.Size(100, 20);
            this.txtorderNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtcusid);
            this.groupBox2.Controls.Add(this.btncusshow);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcusAdd);
            this.groupBox2.Controls.Add(this.txtcusphone);
            this.groupBox2.Controls.Add(this.txtcusname);
            this.groupBox2.Location = new System.Drawing.Point(464, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "Customer ID";
            // 
            // txtcusid
            // 
            this.txtcusid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcusid.Location = new System.Drawing.Point(129, 22);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.ReadOnly = true;
            this.txtcusid.Size = new System.Drawing.Size(100, 20);
            this.txtcusid.TabIndex = 12;
            // 
            // btncusshow
            // 
            this.btncusshow.Location = new System.Drawing.Point(235, 19);
            this.btncusshow.Name = "btncusshow";
            this.btncusshow.Size = new System.Drawing.Size(75, 23);
            this.btncusshow.TabIndex = 11;
            this.btncusshow.Text = "Show";
            this.btncusshow.UseVisualStyleBackColor = true;
            this.btncusshow.Click += new System.EventHandler(this.btncusshow_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Customer Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Customer Name";
            // 
            // txtcusAdd
            // 
            this.txtcusAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcusAdd.Location = new System.Drawing.Point(129, 166);
            this.txtcusAdd.Name = "txtcusAdd";
            this.txtcusAdd.ReadOnly = true;
            this.txtcusAdd.Size = new System.Drawing.Size(100, 20);
            this.txtcusAdd.TabIndex = 3;
            // 
            // txtcusphone
            // 
            this.txtcusphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcusphone.Location = new System.Drawing.Point(129, 104);
            this.txtcusphone.Name = "txtcusphone";
            this.txtcusphone.ReadOnly = true;
            this.txtcusphone.Size = new System.Drawing.Size(100, 20);
            this.txtcusphone.TabIndex = 2;
            // 
            // txtcusname
            // 
            this.txtcusname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcusname.Location = new System.Drawing.Point(129, 60);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.ReadOnly = true;
            this.txtcusname.Size = new System.Drawing.Size(100, 20);
            this.txtcusname.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txttotamount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtamount);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtcarquantity);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtcarprice);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtcarname);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtcarid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dgvshoworderdetail);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtfinalsalary);
            this.groupBox3.Controls.Add(this.btnshowcars);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cars";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(7, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "Choose";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttotamount
            // 
            this.txttotamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotamount.Location = new System.Drawing.Point(669, 38);
            this.txttotamount.Name = "txttotamount";
            this.txttotamount.ReadOnly = true;
            this.txttotamount.Size = new System.Drawing.Size(93, 20);
            this.txttotamount.TabIndex = 29;
            this.txttotamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(669, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total Amount";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiscount.Location = new System.Drawing.Point(545, 38);
            this.txtdiscount.MaxLength = 3;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(125, 20);
            this.txtdiscount.TabIndex = 27;
            this.txtdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(545, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "Discount Percentage(%)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtamount
            // 
            this.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamount.Location = new System.Drawing.Point(461, 38);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(93, 20);
            this.txtamount.TabIndex = 25;
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(461, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Amount";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcarquantity
            // 
            this.txtcarquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcarquantity.Location = new System.Drawing.Point(371, 38);
            this.txtcarquantity.MaxLength = 8;
            this.txtcarquantity.Name = "txtcarquantity";
            this.txtcarquantity.Size = new System.Drawing.Size(93, 20);
            this.txtcarquantity.TabIndex = 23;
            this.txtcarquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcarquantity.TextChanged += new System.EventHandler(this.txtcarquantity_TextChanged);
            this.txtcarquantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcarquantity_KeyDown);
            this.txtcarquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarquantity_KeyPress);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(371, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quantity";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcarprice
            // 
            this.txtcarprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcarprice.Location = new System.Drawing.Point(281, 38);
            this.txtcarprice.MaxLength = 8;
            this.txtcarprice.Name = "txtcarprice";
            this.txtcarprice.Size = new System.Drawing.Size(93, 20);
            this.txtcarprice.TabIndex = 21;
            this.txtcarprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcarprice.TextChanged += new System.EventHandler(this.txtcarprice_TextChanged);
            this.txtcarprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcarprice_KeyDown);
            this.txtcarprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarprice_KeyPress);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(281, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Price";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcarname
            // 
            this.txtcarname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcarname.Location = new System.Drawing.Point(191, 38);
            this.txtcarname.Name = "txtcarname";
            this.txtcarname.ReadOnly = true;
            this.txtcarname.Size = new System.Drawing.Size(93, 20);
            this.txtcarname.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(191, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Car Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcarid
            // 
            this.txtcarid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcarid.Location = new System.Drawing.Point(97, 38);
            this.txtcarid.Name = "txtcarid";
            this.txtcarid.ReadOnly = true;
            this.txtcarid.Size = new System.Drawing.Size(93, 20);
            this.txtcarid.TabIndex = 17;
            this.txtcarid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(97, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Car ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvshoworderdetail
            // 
            this.dgvshoworderdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvshoworderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshoworderdetail.ColumnHeadersVisible = false;
            this.dgvshoworderdetail.ContextMenuStrip = this.conmenstripfordgvorderdetails;
            this.dgvshoworderdetail.Location = new System.Drawing.Point(9, 64);
            this.dgvshoworderdetail.MultiSelect = false;
            this.dgvshoworderdetail.Name = "dgvshoworderdetail";
            this.dgvshoworderdetail.ReadOnly = true;
            this.dgvshoworderdetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvshoworderdetail.Size = new System.Drawing.Size(753, 161);
            this.dgvshoworderdetail.TabIndex = 15;
            this.dgvshoworderdetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvshoworderdetail_RowsRemoved);
            this.dgvshoworderdetail.DoubleClick += new System.EventHandler(this.dgvshoworderdetail_DoubleClick);
            // 
            // conmenstripfordgvorderdetails
            // 
            this.conmenstripfordgvorderdetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatedgvItems,
            this.deleteCurrentRowindgv,
            this.deleteAllRowsindgv});
            this.conmenstripfordgvorderdetails.Name = "conmenstripfordgvorderdetails";
            this.conmenstripfordgvorderdetails.Size = new System.Drawing.Size(177, 70);
            // 
            // updatedgvItems
            // 
            this.updatedgvItems.Name = "updatedgvItems";
            this.updatedgvItems.Size = new System.Drawing.Size(176, 22);
            this.updatedgvItems.Text = "Update";
            this.updatedgvItems.Click += new System.EventHandler(this.updatedgvItems_Click);
            // 
            // deleteCurrentRowindgv
            // 
            this.deleteCurrentRowindgv.Name = "deleteCurrentRowindgv";
            this.deleteCurrentRowindgv.Size = new System.Drawing.Size(176, 22);
            this.deleteCurrentRowindgv.Text = "Delete Current Row";
            this.deleteCurrentRowindgv.Click += new System.EventHandler(this.deleteCurrentRowindgv_Click);
            // 
            // deleteAllRowsindgv
            // 
            this.deleteAllRowsindgv.Name = "deleteAllRowsindgv";
            this.deleteAllRowsindgv.Size = new System.Drawing.Size(176, 22);
            this.deleteAllRowsindgv.Text = "Delete All Rows";
            this.deleteAllRowsindgv.Click += new System.EventHandler(this.deleteAllRowsindgv_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(581, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Final Salary";
            // 
            // txtfinalsalary
            // 
            this.txtfinalsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfinalsalary.Location = new System.Drawing.Point(662, 236);
            this.txtfinalsalary.Name = "txtfinalsalary";
            this.txtfinalsalary.ReadOnly = true;
            this.txtfinalsalary.Size = new System.Drawing.Size(100, 20);
            this.txtfinalsalary.TabIndex = 13;
            // 
            // btnshowcars
            // 
            this.btnshowcars.Location = new System.Drawing.Point(6, 38);
            this.btnshowcars.Name = "btnshowcars";
            this.btnshowcars.Size = new System.Drawing.Size(89, 20);
            this.btnshowcars.TabIndex = 31;
            this.btnshowcars.Text = "...";
            this.btnshowcars.UseVisualStyleBackColor = true;
            this.btnshowcars.Click += new System.EventHandler(this.btnshowcars_Click);
            // 
            // btnneworder
            // 
            this.btnneworder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnneworder.Location = new System.Drawing.Point(62, 517);
            this.btnneworder.Name = "btnneworder";
            this.btnneworder.Size = new System.Drawing.Size(123, 23);
            this.btnneworder.TabIndex = 13;
            this.btnneworder.Text = "New Order";
            this.btnneworder.UseVisualStyleBackColor = true;
            this.btnneworder.Click += new System.EventHandler(this.btnneworder_Click);
            // 
            // btnsaveorder
            // 
            this.btnsaveorder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveorder.Location = new System.Drawing.Point(269, 517);
            this.btnsaveorder.Name = "btnsaveorder";
            this.btnsaveorder.Size = new System.Drawing.Size(117, 23);
            this.btnsaveorder.TabIndex = 14;
            this.btnsaveorder.Text = "Save Order";
            this.btnsaveorder.UseVisualStyleBackColor = true;
            this.btnsaveorder.Click += new System.EventHandler(this.btnsaveorder_Click);
            // 
            // btnprintinvoice
            // 
            this.btnprintinvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintinvoice.Location = new System.Drawing.Point(449, 517);
            this.btnprintinvoice.Name = "btnprintinvoice";
            this.btnprintinvoice.Size = new System.Drawing.Size(110, 23);
            this.btnprintinvoice.TabIndex = 15;
            this.btnprintinvoice.Text = "Print Invoice";
            this.btnprintinvoice.UseVisualStyleBackColor = true;
            this.btnprintinvoice.Click += new System.EventHandler(this.btnprintinvoice_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(630, 517);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(108, 23);
            this.btncancel.TabIndex = 16;
            this.btncancel.Text = "Exit";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Orders_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(818, 552);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnprintinvoice);
            this.Controls.Add(this.btnsaveorder);
            this.Controls.Add(this.btnneworder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Orders_Frm";
            this.Text = "Orders Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshoworderdetail)).EndInit();
            this.conmenstripfordgvorderdetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtorderNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtselname;
        private System.Windows.Forms.DateTimePicker dateoforder;
        private System.Windows.Forms.TextBox txtOrderDES;
        private System.Windows.Forms.Button btncusshow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcusAdd;
        private System.Windows.Forms.TextBox txtcusphone;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfinalsalary;
        private System.Windows.Forms.Button btnneworder;
        private System.Windows.Forms.Button btnsaveorder;
        private System.Windows.Forms.Button btnprintinvoice;
        private System.Windows.Forms.Button btncancel;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvshoworderdetail;
        private System.Windows.Forms.TextBox txttotamount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcarquantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcarprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcarname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcarid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnshowcars;
        private System.Windows.Forms.ContextMenuStrip conmenstripfordgvorderdetails;
        private System.Windows.Forms.ToolStripMenuItem updatedgvItems;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentRowindgv;
        private System.Windows.Forms.ToolStripMenuItem deleteAllRowsindgv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcusid;
    }
}