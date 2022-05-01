namespace GTrans.Opciones
{
    partial class FrmReportManager
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
            this.ucRepManager1 = new ACINOX.Components.UCRepManager();
            this.dsDatos1 = new DSDatos();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucRepManager1
            // 
            this.ucRepManager1.ConnectionString = "";
            this.ucRepManager1.dataset = null;
            this.ucRepManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRepManager1.ImageIndex = 0;
            this.ucRepManager1.Location = new System.Drawing.Point(0, 0);
            this.ucRepManager1.Name = "ucRepManager1";
            this.ucRepManager1.PageGroup = null;
            this.ucRepManager1.Size = new System.Drawing.Size(608, 459);
            this.ucRepManager1.TabIndex = 3;
            this.ucRepManager1.User = -1;
            // 
            // dsDatos1
            // 
            this.dsDatos1.DataSetName = "DSDatos";
            this.dsDatos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 459);
            this.Controls.Add(this.ucRepManager1);
            this.Name = "FrmReportManager";
            this.Text = "Administrador de reportes";
            this.Load += new System.EventHandler(this.FrmReportManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDatos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ACINOX.Components.UCRepManager ucRepManager1;
        private DSDatos dsDatos1;
    }
}