namespace GTrans.Tareas
{
    partial class FrmCancelarConsumo
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.causacancelarTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.tConsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForcausacancelar = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_ConsumoTableAdapter = new GTrans.DSDatosTableAdapters.T_ConsumoTableAdapter();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.causacancelarTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcausacancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(277, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(333, 40);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.causacancelarTextEdit);
            this.dataLayoutControl1.DataSource = this.tConsumoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 40);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(333, 158);
            this.dataLayoutControl1.TabIndex = 3;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // causacancelarTextEdit
            // 
            this.causacancelarTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "causacancelar", true));
            this.causacancelarTextEdit.Location = new System.Drawing.Point(12, 28);
            this.causacancelarTextEdit.Name = "causacancelarTextEdit";
            this.causacancelarTextEdit.Size = new System.Drawing.Size(309, 118);
            this.causacancelarTextEdit.StyleController = this.dataLayoutControl1;
            this.causacancelarTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.causacancelarTextEdit, conditionValidationRule1);
            // 
            // tConsumoBindingSource
            // 
            this.tConsumoBindingSource.DataMember = "T_Consumo";
            this.tConsumoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(333, 158);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForcausacancelar});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(313, 138);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForcausacancelar
            // 
            this.ItemForcausacancelar.Control = this.causacancelarTextEdit;
            this.ItemForcausacancelar.CustomizationFormText = "causacancelar";
            this.ItemForcausacancelar.Location = new System.Drawing.Point(0, 0);
            this.ItemForcausacancelar.Name = "ItemForcausacancelar";
            this.ItemForcausacancelar.Size = new System.Drawing.Size(313, 138);
            this.ItemForcausacancelar.Text = "Causa";
            this.ItemForcausacancelar.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForcausacancelar.TextSize = new System.Drawing.Size(30, 13);
            // 
            // t_ConsumoTableAdapter
            // 
            this.t_ConsumoTableAdapter.ClearBeforeFill = true;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 198);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(333, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 4;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // FrmCancelarConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 228);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCancelarConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cancelar Consumo";
            this.Load += new System.EventHandler(this.FrmCancelarConsumo_Load);
            this.Controls.SetChildIndex(this.ucPieFormulario1, 0);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.causacancelarTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcausacancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tConsumoBindingSource;
        private DSDatosTableAdapters.T_ConsumoTableAdapter t_ConsumoTableAdapter;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcausacancelar;
        private DevExpress.XtraEditors.MemoEdit causacancelarTextEdit;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}