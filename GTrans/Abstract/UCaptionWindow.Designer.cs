namespace GTrans.Abstract
{
    partial class CaptionWindow
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
            this.topcaptionpanel = new DevExpress.XtraEditors.PanelControl();
            this.toplabel = new DevExpress.XtraEditors.LabelControl();
            this.toppicture = new System.Windows.Forms.PictureBox();
            this.traceComponent1 = new ACINOX.Components.TraceComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            this.SuspendLayout();
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Controls.Add(this.toplabel);
            this.topcaptionpanel.Controls.Add(this.toppicture);
            this.topcaptionpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topcaptionpanel.Location = new System.Drawing.Point(0, 0);
            this.topcaptionpanel.Name = "topcaptionpanel";
            this.topcaptionpanel.Size = new System.Drawing.Size(290, 40);
            this.topcaptionpanel.TabIndex = 2;
            // 
            // toplabel
            // 
            this.toplabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.toplabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toplabel.Location = new System.Drawing.Point(54, 2);
            this.toplabel.Name = "toplabel";
            this.toplabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.toplabel.Size = new System.Drawing.Size(234, 36);
            this.toplabel.TabIndex = 5;
            this.toplabel.Text = "labelControl1";
            // 
            // toppicture
            // 
            this.toppicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.toppicture.Location = new System.Drawing.Point(2, 2);
            this.toppicture.Name = "toppicture";
            this.toppicture.Size = new System.Drawing.Size(52, 36);
            this.toppicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.toppicture.TabIndex = 3;
            this.toppicture.TabStop = false;
            // 
            // traceComponent1
            // 
            this.traceComponent1.ConnectionString = null;
            this.traceComponent1.DataSet = null;
            this.traceComponent1.User = 0;
            // 
            // CaptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.topcaptionpanel);
            this.Name = "CaptionWindow";
            this.Text = "UCaptionWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptionWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl toplabel;
        protected System.Windows.Forms.PictureBox toppicture;
        private ACINOX.Components.TraceComponent traceComponent1;
        public DevExpress.XtraEditors.PanelControl topcaptionpanel;
    }
}