namespace GTrans.Codificadores
{
    partial class FrmParalizado
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParalizado));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_tipo_paralizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipotrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_TipoTrabajoGridControl = new DevExpress.XtraGrid.GridControl();
            this.tTipoParalizadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_tipo_paralizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.t_Tipo_ParalizadoTableAdapter = new GTrans.DSDatosTableAdapters.T_Tipo_ParalizadoTableAdapter();
            this.t_ParalizadoTableAdapter1 = new GTrans.DSDatosTableAdapters.T_ParalizadoTableAdapter();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tParalizadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_tipo_paralizado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_tipo_paralizado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservaciones1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoParalizadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tParalizadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 332);
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(419, 30);
            this.CodifcadorPieFormulario.StringCancelar = "Cancelar";
            this.CodifcadorPieFormulario.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.CodifcadorPieFormulario_Aceptar);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(363, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(419, 40);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tipo_paralizado,
            this.colobservaciones});
            this.gridView1.GridControl = this.t_TipoTrabajoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colid_tipo_paralizado
            // 
            this.colid_tipo_paralizado.Caption = "Tipo de causas";
            this.colid_tipo_paralizado.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colid_tipo_paralizado.FieldName = "id_tipo_paralizado";
            this.colid_tipo_paralizado.Name = "colid_tipo_paralizado";
            this.colid_tipo_paralizado.Visible = true;
            this.colid_tipo_paralizado.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nametipotrabajo";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idtipotrabajo";
            this.repositoryItemGridLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipotrabajo});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipotrabajo
            // 
            this.colnametipotrabajo.Caption = "Tipo Trabajo";
            this.colnametipotrabajo.FieldName = "nametipotrabajo";
            this.colnametipotrabajo.Name = "colnametipotrabajo";
            this.colnametipotrabajo.Visible = true;
            this.colnametipotrabajo.VisibleIndex = 0;
            // 
            // colobservaciones
            // 
            this.colobservaciones.Caption = "Causas";
            this.colobservaciones.FieldName = "observaciones";
            this.colobservaciones.Name = "colobservaciones";
            this.colobservaciones.Visible = true;
            this.colobservaciones.VisibleIndex = 1;
            // 
            // t_TipoTrabajoGridControl
            // 
            this.t_TipoTrabajoGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_TipoTrabajoGridControl.DataSource = this.tTipoParalizadoBindingSource;
            this.t_TipoTrabajoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "FK_T_Paralizado_T_Tipo_Paralizado";
            this.t_TipoTrabajoGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.t_TipoTrabajoGridControl.Location = new System.Drawing.Point(0, 0);
            this.t_TipoTrabajoGridControl.MainView = this.gridView3;
            this.t_TipoTrabajoGridControl.Name = "t_TipoTrabajoGridControl";
            this.t_TipoTrabajoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.t_TipoTrabajoGridControl.Size = new System.Drawing.Size(413, 264);
            this.t_TipoTrabajoGridControl.TabIndex = 1;
            this.t_TipoTrabajoGridControl.UseEmbeddedNavigator = true;
            this.t_TipoTrabajoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView1});
            // 
            // tTipoParalizadoBindingSource
            // 
            this.tTipoParalizadoBindingSource.DataMember = "T_Tipo_Paralizado";
            this.tTipoParalizadoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_tipo_paralizado});
            this.gridView3.GridControl = this.t_TipoTrabajoGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.EnableMasterViewMode = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // colnombre_tipo_paralizado
            // 
            this.colnombre_tipo_paralizado.Caption = "Tipo de causas";
            this.colnombre_tipo_paralizado.FieldName = "nombre_tipo_paralizado";
            this.colnombre_tipo_paralizado.Name = "colnombre_tipo_paralizado";
            this.colnombre_tipo_paralizado.Visible = true;
            this.colnombre_tipo_paralizado.VisibleIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.T_AlmacenExistenciaTableAdapter = null;
            this.tableAdapterManager.T_AlmacenTableAdapter = null;
            this.tableAdapterManager.T_AreaTableAdapter = null;
            this.tableAdapterManager.T_CategoriaTableAdapter = null;
            this.tableAdapterManager.T_ClasificacionTableAdapter = null;
            this.tableAdapterManager.T_ConsumoEquipoTableAdapter = null;
            this.tableAdapterManager.T_ConsumoTableAdapter = null;
            this.tableAdapterManager.T_Empleado_FormaTableAdapter = null;
            this.tableAdapterManager.T_EmpleadoTableAdapter = null;
            this.tableAdapterManager.T_EmpresaTableAdapter = null;
            this.tableAdapterManager.T_EquipoTableAdapter = null;
            this.tableAdapterManager.T_Estado_TecnicoTableAdapter = null;
            this.tableAdapterManager.T_EstadoOrdenTableAdapter = null;
            this.tableAdapterManager.T_EstadoTableAdapter = null;
            this.tableAdapterManager.T_FormaPagoTableAdapter = null;
            this.tableAdapterManager.T_GrupoAccionTableAdapter = null;
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MonedaTableAdapter = null;
            this.tableAdapterManager.T_NivelEscolaridadTableAdapter = null;
            this.tableAdapterManager.T_OrdenSalarioTableAdapter = null;
            this.tableAdapterManager.T_OrdenSurtidoMonedaTableAdapter = null;
            this.tableAdapterManager.T_OrdenSurtidoTableAdapter = null;
            this.tableAdapterManager.T_OrdenTrabajoTableAdapter = null;
            this.tableAdapterManager.T_PaisTableAdapter = null;
            this.tableAdapterManager.T_ParalizadoTableAdapter = null;
            this.tableAdapterManager.T_PlanificacionTableAdapter = null;
            this.tableAdapterManager.T_ProductoGenericoTableAdapter = null;
            this.tableAdapterManager.T_ProductoTableAdapter = null;
            this.tableAdapterManager.T_Tipo_EquipoTableAdapter = null;
            this.tableAdapterManager.T_Tipo_MarcaTableAdapter = null;
            this.tableAdapterManager.T_Tipo_MatriculaTableAdapter = null;
            this.tableAdapterManager.T_Tipo_ParalizadoTableAdapter = null;
            this.tableAdapterManager.T_TipoCombustibleTableAdapter = null;
            this.tableAdapterManager.T_TipoMantenimientoTableAdapter = null;
            this.tableAdapterManager.T_TipoModeloAccionTableAdapter = null;
            this.tableAdapterManager.T_TipoModeloMantSurtidoTableAdapter = null;
            this.tableAdapterManager.T_TipoModeloMantTableAdapter = null;
            this.tableAdapterManager.T_TipoModeloMantTrabTableAdapter = null;
            this.tableAdapterManager.T_TipoTrabajoTableAdapter = null;
            this.tableAdapterManager.T_TipoValeTableAdapter = null;
            this.tableAdapterManager.T_UEBTableAdapter = null;
            this.tableAdapterManager.T_UMTableAdapter = null;
            this.tableAdapterManager.T_ValeExistenciaMonedaTableAdapter = null;
            this.tableAdapterManager.T_ValeExistenciaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // t_Tipo_ParalizadoTableAdapter
            // 
            this.t_Tipo_ParalizadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ParalizadoTableAdapter1
            // 
            this.t_ParalizadoTableAdapter1.ClearBeforeFill = true;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 40);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(419, 292);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(413, 264);
            this.xtraTabPage1.Text = "Causas";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.tParalizadoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView4;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(413, 264);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // tParalizadoBindingSource
            // 
            this.tParalizadoBindingSource.DataMember = "T_Paralizado";
            this.tParalizadoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_tipo_paralizado1,
            this.colobservaciones1});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView4.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView4_RowUpdated);
            // 
            // colid_tipo_paralizado1
            // 
            this.colid_tipo_paralizado1.Caption = "Tipo de causas";
            this.colid_tipo_paralizado1.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colid_tipo_paralizado1.FieldName = "id_tipo_paralizado";
            this.colid_tipo_paralizado1.Name = "colid_tipo_paralizado1";
            this.colid_tipo_paralizado1.Visible = true;
            this.colid_tipo_paralizado1.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tTipoParalizadoBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "nombre_tipo_paralizado";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "id_tipo_paralizado";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_tipo_paralizado1});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_tipo_paralizado1
            // 
            this.colnombre_tipo_paralizado1.Caption = "Tipo";
            this.colnombre_tipo_paralizado1.FieldName = "nombre_tipo_paralizado";
            this.colnombre_tipo_paralizado1.Name = "colnombre_tipo_paralizado1";
            this.colnombre_tipo_paralizado1.Visible = true;
            this.colnombre_tipo_paralizado1.VisibleIndex = 0;
            // 
            // colobservaciones1
            // 
            this.colobservaciones1.Caption = "Observaciones";
            this.colobservaciones1.FieldName = "observaciones";
            this.colobservaciones1.Name = "colobservaciones1";
            this.colobservaciones1.Visible = true;
            this.colobservaciones1.VisibleIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.t_TipoTrabajoGridControl);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(413, 264);
            this.xtraTabPage2.Text = "Tipos";
            // 
            // FrmParalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 362);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmParalizado";
            this.Text = "FrmTipoOrden";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTipoOrden_FormClosed);
            this.Load += new System.EventHandler(this.FrmTipoOrden_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoParalizadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tParalizadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.BindingSource tTipoParalizadoBindingSource;
        private DSDatosTableAdapters.T_Tipo_ParalizadoTableAdapter t_Tipo_ParalizadoTableAdapter;
        private DSDatosTableAdapters.T_ParalizadoTableAdapter t_ParalizadoTableAdapter1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tParalizadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_paralizado1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_tipo_paralizado1;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl t_TipoTrabajoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_paralizado;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipotrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colobservaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_tipo_paralizado;
    }
}