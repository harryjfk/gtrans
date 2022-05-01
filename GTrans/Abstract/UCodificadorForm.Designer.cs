namespace GTrans.Abstract
{
    partial class CodificadorForm
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
            this.CodifcadorPieFormulario = new ACINOX.Components.UCPieFormulario();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(374, 36);
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Cerrar = true;
            this.CodifcadorPieFormulario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 340);
            this.CodifcadorPieFormulario.Name = "CodifcadorPieFormulario";
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfClose;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(430, 30);
            this.CodifcadorPieFormulario.StringAceptar = "Aceptar";
            this.CodifcadorPieFormulario.StringCancelar = "Cerrar";
            this.CodifcadorPieFormulario.TabIndex = 1;
            // 
            // CodificadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.CodifcadorPieFormulario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodificadorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XtraForm1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodificadorForm_KeyDown);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected ACINOX.Components.UCPieFormulario CodifcadorPieFormulario;
    }
}