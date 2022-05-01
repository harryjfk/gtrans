namespace GTrans.Reportes
{
    partial class FrmAlmacenReport
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoValeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipovale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_ProductoTableAdapter = new GTrans.DSDatosTableAdapters.T_ProductoTableAdapter();
            this.t_TipoValeTableAdapter = new GTrans.DSDatosTableAdapters.T_TipoValeTableAdapter();
            this.tableAdapterManager1 = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.t_ClasificacionTableAdapter1 = new GTrans.DSDatosTableAdapters.T_ClasificacionTableAdapter();
            this.t_UMTableAdapter1 = new GTrans.DSDatosTableAdapters.T_UMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoValeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 106);
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(405, 30);
            this.CodifcadorPieFormulario.StringCancelar = "Cancelar";
            this.CodifcadorPieFormulario.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.CodifcadorPieFormulario_Aceptar);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(349, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(405, 40);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridLookUpEdit2);
            this.layoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(405, 66);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.Location = new System.Drawing.Point(77, 36);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.tProductoBindingSource;
            this.gridLookUpEdit2.Properties.DisplayMember = "codcomplete";
            this.gridLookUpEdit2.Properties.ValueMember = "idproducto";
            this.gridLookUpEdit2.Properties.View = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Size = new System.Drawing.Size(299, 20);
            this.gridLookUpEdit2.StyleController = this.layoutControl1;
            this.gridLookUpEdit2.TabIndex = 5;
            // 
            // tProductoBindingSource
            // 
            this.tProductoBindingSource.DataMember = "T_Producto";
            this.tProductoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodproducto,
            this.coldescproducto});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colcodproducto
            // 
            this.colcodproducto.Caption = "Código";
            this.colcodproducto.FieldName = "codcomplete";
            this.colcodproducto.Name = "colcodproducto";
            this.colcodproducto.Visible = true;
            this.colcodproducto.VisibleIndex = 0;
            // 
            // coldescproducto
            // 
            this.coldescproducto.Caption = "Descripción";
            this.coldescproducto.FieldName = "descproducto";
            this.coldescproducto.Name = "coldescproducto";
            this.coldescproducto.Visible = true;
            this.coldescproducto.VisibleIndex = 1;
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(77, 12);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tTipoValeBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nametipovale";
            this.gridLookUpEdit1.Properties.ValueMember = "idtipovale";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(299, 20);
            this.gridLookUpEdit1.StyleController = this.layoutControl1;
            this.gridLookUpEdit1.TabIndex = 4;
            // 
            // tTipoValeBindingSource
            // 
            this.tTipoValeBindingSource.DataMember = "T_TipoVale";
            this.tTipoValeBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipovale});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipovale
            // 
            this.colnametipovale.Caption = "Tipo de Vale";
            this.colnametipovale.FieldName = "nametipovale";
            this.colnametipovale.Name = "colnametipovale";
            this.colnametipovale.Visible = true;
            this.colnametipovale.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(388, 68);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridLookUpEdit1;
            this.layoutControlItem1.CustomizationFormText = "Tipo de Vale:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem1.Text = "Tipo de Vale:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridLookUpEdit2;
            this.layoutControlItem2.CustomizationFormText = "Producto:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(368, 24);
            this.layoutControlItem2.Text = "Producto:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
            // 
            // t_ProductoTableAdapter
            // 
            this.t_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoValeTableAdapter
            // 
            this.t_TipoValeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.T_AlmacenExistenciaTableAdapter = null;
            this.tableAdapterManager1.T_AlmacenTableAdapter = null;
            this.tableAdapterManager1.T_AreaTableAdapter = null;
            this.tableAdapterManager1.T_CategoriaTableAdapter = null;
            this.tableAdapterManager1.T_ClasificacionTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoEquipoTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoTableAdapter = null;
            this.tableAdapterManager1.T_Empleado_FormaTableAdapter = null;
            this.tableAdapterManager1.T_EmpleadoTableAdapter = null;
            this.tableAdapterManager1.T_EmpresaTableAdapter = null;
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
            this.tableAdapterManager1.T_UEBTableAdapter = null;
            this.tableAdapterManager1.T_UMTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaMonedaTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_ClasificacionTableAdapter1
            // 
            this.t_ClasificacionTableAdapter1.ClearBeforeFill = true;
            // 
            // t_UMTableAdapter1
            // 
            this.t_UMTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAlmacenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 136);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmAlmacenReport";
            this.Text = "FrmAlmacenReport";
            this.Load += new System.EventHandler(this.FrmAlmacenReport_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoValeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tProductoBindingSource;
        private DSDatosTableAdapters.T_ProductoTableAdapter t_ProductoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colcodproducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescproducto;
        private System.Windows.Forms.BindingSource tTipoValeBindingSource;
        private DSDatosTableAdapters.T_TipoValeTableAdapter t_TipoValeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipovale;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager1;
        private DSDatosTableAdapters.T_ClasificacionTableAdapter t_ClasificacionTableAdapter1;
        private DSDatosTableAdapters.T_UMTableAdapter t_UMTableAdapter1;
    }
}