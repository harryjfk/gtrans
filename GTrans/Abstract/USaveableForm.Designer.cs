namespace GTrans.Abstract
{
    partial class SaveableForm
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
            this.HintPanel = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintPanel)).BeginInit();
            this.HintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(492, 36);
            // 
            // HintPanel
            // 
            this.HintPanel.Controls.Add(this.labelControl2);
            this.HintPanel.Controls.Add(this.pictureBox2);
            this.HintPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HintPanel.Location = new System.Drawing.Point(0, 368);
            this.HintPanel.Name = "HintPanel";
            this.HintPanel.Size = new System.Drawing.Size(548, 40);
            this.HintPanel.TabIndex = 2;
            this.HintPanel.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(54, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelControl2.Size = new System.Drawing.Size(492, 36);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Se han encontrado errores en los datos. Por favor verifíquelos  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::GTrans.Properties.Resources.ERROR;
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // SaveableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 408);
            this.Controls.Add(this.HintPanel);
            this.Name = "SaveableForm";
            this.Text = "USaveableFom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.HintPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintPanel)).EndInit();
            this.HintPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.PanelControl HintPanel;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        protected System.Windows.Forms.PictureBox pictureBox2;

    }
}