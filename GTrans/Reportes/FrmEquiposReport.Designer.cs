namespace GTrans.Reportes
{
    partial class FrmEquiposReport
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
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridLookUpEdit3 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.fKTAreaTUEBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTUEBTEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.gridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_ueb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_EmpresaTableAdapter = new GTrans.DSDatosTableAdapters.T_EmpresaTableAdapter();
            this.t_UEBTableAdapter = new GTrans.DSDatosTableAdapters.T_UEBTableAdapter();
            this.t_AreaTableAdapter = new GTrans.DSDatosTableAdapters.T_AreaTableAdapter();
            this.tableAdapterManager1 = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTAreaTUEBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTUEBTEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 133);
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(329, 30);
            this.CodifcadorPieFormulario.StringCancelar = "Cancelar";
            this.CodifcadorPieFormulario.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.CodifcadorPieFormulario_Aceptar);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(273, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(329, 40);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridLookUpEdit3);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit2);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(329, 93);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridLookUpEdit3
            // 
            this.gridLookUpEdit3.Location = new System.Drawing.Point(60, 60);
            this.gridLookUpEdit3.Name = "gridLookUpEdit3";
            this.gridLookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit3.Properties.DataSource = this.fKTAreaTUEBBindingSource;
            this.gridLookUpEdit3.Properties.DisplayMember = "nombre_area";
            this.gridLookUpEdit3.Properties.ValueMember = "id_area";
            this.gridLookUpEdit3.Properties.View = this.gridLookUpEdit3View;
            this.gridLookUpEdit3.Size = new System.Drawing.Size(257, 20);
            this.gridLookUpEdit3.StyleController = this.layoutControl1;
            this.gridLookUpEdit3.TabIndex = 6;
            // 
            // fKTAreaTUEBBindingSource
            // 
            this.fKTAreaTUEBBindingSource.DataMember = "FK_T_Area_T_UEB";
            this.fKTAreaTUEBBindingSource.DataSource = this.fKTUEBTEmpresaBindingSource;
            // 
            // fKTUEBTEmpresaBindingSource
            // 
            this.fKTUEBTEmpresaBindingSource.DataMember = "FK_T_UEB_T_Empresa";
            this.fKTUEBTEmpresaBindingSource.DataSource = this.tEmpresaBindingSource;
            // 
            // tEmpresaBindingSource
            // 
            this.tEmpresaBindingSource.DataMember = "T_Empresa";
            this.tEmpresaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit3View
            // 
            this.gridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_area});
            this.gridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit3View.Name = "gridLookUpEdit3View";
            this.gridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_area
            // 
            this.colnombre_area.Caption = "Area";
            this.colnombre_area.FieldName = "nombre_area";
            this.colnombre_area.Name = "colnombre_area";
            this.colnombre_area.Visible = true;
            this.colnombre_area.VisibleIndex = 0;
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.Location = new System.Drawing.Point(60, 36);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.fKTUEBTEmpresaBindingSource;
            this.gridLookUpEdit2.Properties.DisplayMember = "nombre_ueb";
            this.gridLookUpEdit2.Properties.ValueMember = "id_ueb";
            this.gridLookUpEdit2.Properties.View = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Size = new System.Drawing.Size(257, 20);
            this.gridLookUpEdit2.StyleController = this.layoutControl1;
            this.gridLookUpEdit2.TabIndex = 5;
            this.gridLookUpEdit2.EditValueChanged += new System.EventHandler(this.gridLookUpEdit2_EditValueChanged);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_ueb});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_ueb
            // 
            this.colnombre_ueb.Caption = "UEB";
            this.colnombre_ueb.FieldName = "nombre_ueb";
            this.colnombre_ueb.Name = "colnombre_ueb";
            this.colnombre_ueb.Visible = true;
            this.colnombre_ueb.VisibleIndex = 0;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(60, 12);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tEmpresaBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nombre_empresa";
            this.gridLookUpEdit1.Properties.ValueMember = "id_empresa";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(257, 20);
            this.gridLookUpEdit1.StyleController = this.layoutControl1;
            this.gridLookUpEdit1.TabIndex = 4;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_empresa});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_empresa
            // 
            this.colnombre_empresa.Caption = "Empresa";
            this.colnombre_empresa.FieldName = "nombre_empresa";
            this.colnombre_empresa.Name = "colnombre_empresa";
            this.colnombre_empresa.Visible = true;
            this.colnombre_empresa.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(329, 93);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridLookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Empresa:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(309, 24);
            this.layoutControlItem1.Text = "Empresa:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridLookUpEdit2;
            this.layoutControlItem2.CustomizationFormText = "UEB:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(309, 24);
            this.layoutControlItem2.Text = "UEB:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridLookUpEdit3;
            this.layoutControlItem3.CustomizationFormText = "Area:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(309, 25);
            this.layoutControlItem3.Text = "Area:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // t_EmpresaTableAdapter
            // 
            this.t_EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // t_UEBTableAdapter
            // 
            this.t_UEBTableAdapter.ClearBeforeFill = true;
            // 
            // t_AreaTableAdapter
            // 
            this.t_AreaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.T_AlmacenExistenciaTableAdapter = null;
            this.tableAdapterManager1.T_AlmacenTableAdapter = null;
            this.tableAdapterManager1.T_AreaTableAdapter = this.t_AreaTableAdapter;
            this.tableAdapterManager1.T_CategoriaTableAdapter = null;
            this.tableAdapterManager1.T_ClasificacionTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoEquipoTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoTableAdapter = null;
            this.tableAdapterManager1.T_Empleado_FormaTableAdapter = null;
            this.tableAdapterManager1.T_EmpleadoTableAdapter = null;
            this.tableAdapterManager1.T_EmpresaTableAdapter = this.t_EmpresaTableAdapter;
            this.tableAdapterManager1.T_EquipoTableAdapter = null;
            this.tableAdapterManager1.T_Estado_TecnicoTableAdapter = null;
            this.tableAdapterManager1.T_EstadoOrdenTableAdapter = null;
            this.tableAdapterManager1.T_EstadoTableAdapter = null;
            this.tableAdapterManager1.T_FormaPagoTableAdapter = null;
            this.tableAdapterManager1.T_GrupoAccionTableAdapter = null;
            this.tableAdapterManager1.T_MarcaTableAdapter = null;
            this.tableAdapterManager1.T_ModeloTableAdapter = null;
            this.tableAdapterManager1.T_MonedaTableAdapter = null;
            this.tableAdapterManager1.T_NivelEscolaridadTableAdapter = null;
            this.tableAdapterManager1.T_OrdenSalarioTableAdapter = null;
            this.tableAdapterManager1.T_OrdenSurtidoMonedaTableAdapter = null;
            this.tableAdapterManager1.T_OrdenSurtidoTableAdapter = null;
            this.tableAdapterManager1.T_OrdenTrabajoTableAdapter = null;
            this.tableAdapterManager1.T_PaisTableAdapter = null;
            this.tableAdapterManager1.T_ParalizadoTableAdapter = null;
            this.tableAdapterManager1.T_PlanificacionTableAdapter = null;
            this.tableAdapterManager1.T_ProductoGenericoTableAdapter = null;
            this.tableAdapterManager1.T_ProductoTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_EquipoTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_MarcaTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_MatriculaTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_ParalizadoTableAdapter = null;
            this.tableAdapterManager1.T_TipoCombustibleTableAdapter = null;
            this.tableAdapterManager1.T_TipoMantenimientoTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloAccionTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloMantSurtidoTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloMantTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloMantTrabTableAdapter = null;
            this.tableAdapterManager1.T_TipoTrabajoTableAdapter = null;
            this.tableAdapterManager1.T_TipoValeTableAdapter = null;
            this.tableAdapterManager1.T_UEBTableAdapter = this.t_UEBTableAdapter;
            this.tableAdapterManager1.T_UMTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaMonedaTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmEquiposReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 163);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmEquiposReport";
            this.Text = "FrmEquiposReport";
            this.Load += new System.EventHandler(this.FrmEquiposReport_Load);
            this.Shown += new System.EventHandler(this.FrmEquiposReport_Shown);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTAreaTUEBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTUEBTEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit3View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tEmpresaBindingSource;
        private DSDatosTableAdapters.T_EmpresaTableAdapter t_EmpresaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_empresa;
        private System.Windows.Forms.BindingSource fKTUEBTEmpresaBindingSource;
        private DSDatosTableAdapters.T_UEBTableAdapter t_UEBTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_ueb;
        private System.Windows.Forms.BindingSource fKTAreaTUEBBindingSource;
        private DSDatosTableAdapters.T_AreaTableAdapter t_AreaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_area;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}