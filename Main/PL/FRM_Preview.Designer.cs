namespace AMS.PL
{
    partial class FRM_Preview
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
            this.picpreviewcar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picpreviewcar)).BeginInit();
            this.SuspendLayout();
            // 
            // picpreviewcar
            // 
            this.picpreviewcar.Location = new System.Drawing.Point(12, 12);
            this.picpreviewcar.Name = "picpreviewcar";
            this.picpreviewcar.Size = new System.Drawing.Size(340, 301);
            this.picpreviewcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpreviewcar.TabIndex = 0;
            this.picpreviewcar.TabStop = false;
            // 
            // FRM_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 325);
            this.Controls.Add(this.picpreviewcar);
            this.Name = "FRM_Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Form";
            ((System.ComponentModel.ISupportInitialize)(this.picpreviewcar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picpreviewcar;
    }
}