namespace AMS.PL
{
    partial class CarListForm
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
            this.dgvshowcars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowcars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvshowcars
            // 
            this.dgvshowcars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvshowcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshowcars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvshowcars.Location = new System.Drawing.Point(0, 0);
            this.dgvshowcars.MultiSelect = false;
            this.dgvshowcars.Name = "dgvshowcars";
            this.dgvshowcars.ReadOnly = true;
            this.dgvshowcars.Size = new System.Drawing.Size(746, 336);
            this.dgvshowcars.TabIndex = 0;
            this.dgvshowcars.DoubleClick += new System.EventHandler(this.dgvshowcars_DoubleClick);
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(746, 336);
            this.Controls.Add(this.dgvshowcars);
            this.Name = "CarListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cars List ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvshowcars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvshowcars;

    }
}