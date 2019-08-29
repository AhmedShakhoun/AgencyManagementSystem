namespace AMS.PL
{
    partial class CustomerList_Frm
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
            this.dgvcuslist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuslist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcuslist
            // 
            this.dgvcuslist.AllowUserToAddRows = false;
            this.dgvcuslist.AllowUserToDeleteRows = false;
            this.dgvcuslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcuslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcuslist.Location = new System.Drawing.Point(0, 0);
            this.dgvcuslist.Name = "dgvcuslist";
            this.dgvcuslist.ReadOnly = true;
            this.dgvcuslist.Size = new System.Drawing.Size(533, 261);
            this.dgvcuslist.TabIndex = 0;
            this.dgvcuslist.DoubleClick += new System.EventHandler(this.dgvcuslist_DoubleClick);
            // 
            // CustomerList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(533, 261);
            this.Controls.Add(this.dgvcuslist);
            this.Name = "CustomerList_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer List Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuslist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcuslist;

    }
}