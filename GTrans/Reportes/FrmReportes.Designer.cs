namespace GTrans.Reportes
{
    partial class FrmReportes
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
            this.ucReport1 = new MaxMin.UCReport();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(692, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(748, 40);
            // 
            // ucReport1
            // 
            this.ucReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReport1.Location = new System.Drawing.Point(0, 40);
            this.ucReport1.Name = "ucReport1";
            this.ucReport1.Size = new System.Drawing.Size(748, 414);
            this.ucReport1.TabIndex = 0;
            this.ucReport1.ViewNormal = true;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 454);
            this.Controls.Add(this.ucReport1);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.ucReport1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MaxMin.UCReport ucReport1;

    }
}