namespace GTrans.Tareas
{
    partial class FrmBajaEquipo
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.fecha_bajaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.causabajaTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForfecha_baja = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcausabaja = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_EquipoTableAdapter = new GTrans.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_bajaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_bajaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.causabajaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfecha_baja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcausabaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.fecha_bajaDateEdit);
            this.dataLayoutControl1.Controls.Add(this.causabajaTextEdit);
            this.dataLayoutControl1.DataSource = this.tEquipoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(392, 143);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // fecha_bajaDateEdit
            // 
            this.fecha_bajaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tEquipoBindingSource, "fecha_baja", true));
            this.fecha_bajaDateEdit.EditValue = null;
            this.fecha_bajaDateEdit.Location = new System.Drawing.Point(49, 12);
            this.fecha_bajaDateEdit.Name = "fecha_bajaDateEdit";
            this.fecha_bajaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha_bajaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha_bajaDateEdit.Size = new System.Drawing.Size(145, 20);
            this.fecha_bajaDateEdit.StyleController = this.dataLayoutControl1;
            this.fecha_bajaDateEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.fecha_bajaDateEdit, conditionValidationRule1);
            // 
            // tEquipoBindingSource
            // 
            this.tEquipoBindingSource.DataMember = "T_Equipo";
            this.tEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // causabajaTextEdit
            // 
            this.causabajaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tEquipoBindingSource, "causabaja", true));
            this.causabajaTextEdit.Location = new System.Drawing.Point(12, 52);
            this.causabajaTextEdit.Name = "causabajaTextEdit";
            this.causabajaTextEdit.Size = new System.Drawing.Size(368, 79);
            this.causabajaTextEdit.StyleController = this.dataLayoutControl1;
            this.causabajaTextEdit.TabIndex = 5;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.causabajaTextEdit, conditionValidationRule2);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(392, 143);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForfecha_baja,
            this.ItemForcausabaja,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(372, 123);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForfecha_baja
            // 
            this.ItemForfecha_baja.Control = this.fecha_bajaDateEdit;
            this.ItemForfecha_baja.CustomizationFormText = "Fecha:";
            this.ItemForfecha_baja.Location = new System.Drawing.Point(0, 0);
            this.ItemForfecha_baja.Name = "ItemForfecha_baja";
            this.ItemForfecha_baja.Size = new System.Drawing.Size(186, 24);
            this.ItemForfecha_baja.Text = "Fecha:";
            this.ItemForfecha_baja.TextSize = new System.Drawing.Size(34, 13);
            // 
            // ItemForcausabaja
            // 
            this.ItemForcausabaja.Control = this.causabajaTextEdit;
            this.ItemForcausabaja.CustomizationFormText = "Causa:";
            this.ItemForcausabaja.Location = new System.Drawing.Point(0, 24);
            this.ItemForcausabaja.Name = "ItemForcausabaja";
            this.ItemForcausabaja.Size = new System.Drawing.Size(372, 99);
            this.ItemForcausabaja.Text = "Causa:";
            this.ItemForcausabaja.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForcausabaja.TextSize = new System.Drawing.Size(34, 13);
            // 
            // t_EquipoTableAdapter
            // 
            this.t_EquipoTableAdapter.ClearBeforeFill = true;
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 143);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(392, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 1;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(186, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(186, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmBajaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 173);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBajaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dar Baja a Equipo";
            this.Load += new System.EventHandler(this.FrmBajaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fecha_bajaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_bajaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.causabajaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfecha_baja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcausabaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tEquipoBindingSource;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter;
        private DevExpress.XtraEditors.DateEdit fecha_bajaDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfecha_baja;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcausabaja;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.MemoEdit causabajaTextEdit;
        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}