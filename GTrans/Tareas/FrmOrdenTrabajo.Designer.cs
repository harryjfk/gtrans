namespace GTrans.Tareas
{
    partial class FrmOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenTrabajo));
            this.dSDatos = new GTrans.DSDatos();
            this.t_OrdenTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_OrdenTrabajoTableAdapter = new GTrans.DSDatosTableAdapters.T_OrdenTrabajoTableAdapter();
            this.tableAdapterManager = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.t_OrdenTrabajoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnoorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidequipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tLocalizacionEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameequipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipoorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colidresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit6View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEstadoOrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit7View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit8View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tIntervencionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameintervencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoIntervecionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipointer1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit5View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipotrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tTipoIntervecionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.idestadoGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.idestadoGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idordentrabajoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.fechasolDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fechainiplanDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.noordenSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.idequipoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idtipotrabajoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idresponsableSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mateypiezaplanSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.salarioplanSpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.actividadesTextEdit = new DevExpress.XtraEditors.MemoExEdit();
            this.idestadoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idtipoordenSpinEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ItemForidordentrabajo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFornoorden = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidequipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidtipoorden = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidtipotrabajo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForfechasol = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForactividades = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForsalarioplan = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormateypiezaplan = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForfechainiplan = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidresponsable = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidestado = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_EquipoTableAdapter = new GTrans.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.t_TipoTrabajoTableAdapter = new GTrans.DSDatosTableAdapters.T_TipoTrabajoTableAdapter();
            this.t_EmpleadoTableAdapter = new GTrans.DSDatosTableAdapters.T_EmpleadoTableAdapter();
            this.t_EstadoOrdenTableAdapter = new GTrans.DSDatosTableAdapters.T_EstadoOrdenTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.t_EstadoTableAdapter = new GTrans.DSDatosTableAdapters.T_EstadoTableAdapter();
            this.t_CategoriaTableAdapter1 = new GTrans.DSDatosTableAdapters.T_CategoriaTableAdapter();
            this.t_TipoModeloAccionTableAdapter1 = new GTrans.DSDatosTableAdapters.T_TipoModeloAccionTableAdapter();
            this.t_TipoModeloMantTableAdapter1 = new GTrans.DSDatosTableAdapters.T_TipoModeloMantTableAdapter();
            this.t_PlanificacionTableAdapter1 = new GTrans.DSDatosTableAdapters.T_PlanificacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_OrdenTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_OrdenTrabajoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLocalizacionEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoOrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIntervencionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoIntervecionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoIntervecionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idordentrabajoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasolDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasolDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechainiplanDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechainiplanDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noordenSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idequipoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipotrabajoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idresponsableSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mateypiezaplanSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarioplanSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipoordenSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidordentrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornoorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidequipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipoorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipotrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfechasol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForactividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsalarioplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormateypiezaplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfechainiplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidresponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidestado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(873, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(929, 40);
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_OrdenTrabajoBindingSource
            // 
            this.t_OrdenTrabajoBindingSource.DataMember = "T_OrdenTrabajo";
            this.t_OrdenTrabajoBindingSource.DataSource = this.dSDatos;
            this.t_OrdenTrabajoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.t_OrdenTrabajoBindingSource_BindingComplete);
            this.t_OrdenTrabajoBindingSource.CurrentChanged += new System.EventHandler(this.t_OrdenTrabajoBindingSource_CurrentChanged);
            // 
            // t_OrdenTrabajoTableAdapter
            // 
            this.t_OrdenTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.T_OrdenTrabajoTableAdapter = this.t_OrdenTrabajoTableAdapter;
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
            // t_OrdenTrabajoGridControl
            // 
            this.t_OrdenTrabajoGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_OrdenTrabajoGridControl.DataSource = this.t_OrdenTrabajoBindingSource;
            this.t_OrdenTrabajoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_OrdenTrabajoGridControl.Location = new System.Drawing.Point(2, 2);
            this.t_OrdenTrabajoGridControl.MainView = this.gridView1;
            this.t_OrdenTrabajoGridControl.Name = "t_OrdenTrabajoGridControl";
            this.t_OrdenTrabajoGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemGridLookUpEdit3,
            this.repositoryItemGridLookUpEdit4,
            this.repositoryItemGridLookUpEdit5,
            this.repositoryItemGridLookUpEdit6,
            this.repositoryItemGridLookUpEdit7,
            this.repositoryItemGridLookUpEdit8,
            this.repositoryItemImageComboBox1});
            this.t_OrdenTrabajoGridControl.Size = new System.Drawing.Size(656, 343);
            this.t_OrdenTrabajoGridControl.TabIndex = 1;
            this.t_OrdenTrabajoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnoorden,
            this.colidequipo,
            this.colidtipoorden,
            this.colidresponsable,
            this.colidestado,
            this.gridColumn1});
            this.gridView1.GridControl = this.t_OrdenTrabajoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colnoorden
            // 
            this.colnoorden.Caption = "No Orden";
            this.colnoorden.FieldName = "noorden";
            this.colnoorden.Name = "colnoorden";
            this.colnoorden.Visible = true;
            this.colnoorden.VisibleIndex = 0;
            // 
            // colidequipo
            // 
            this.colidequipo.Caption = "Equipo";
            this.colidequipo.ColumnEdit = this.repositoryItemGridLookUpEdit3;
            this.colidequipo.FieldName = "idequipo";
            this.colidequipo.Name = "colidequipo";
            this.colidequipo.Visible = true;
            this.colidequipo.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit3
            // 
            this.repositoryItemGridLookUpEdit3.AutoHeight = false;
            this.repositoryItemGridLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit3.DataSource = this.tLocalizacionEquipoBindingSource;
            this.repositoryItemGridLookUpEdit3.DisplayMember = "matricula";
            this.repositoryItemGridLookUpEdit3.Name = "repositoryItemGridLookUpEdit3";
            this.repositoryItemGridLookUpEdit3.ValueMember = "idequipo";
            this.repositoryItemGridLookUpEdit3.View = this.repositoryItemGridLookUpEdit3View;
            // 
            // tLocalizacionEquipoBindingSource
            // 
            this.tLocalizacionEquipoBindingSource.DataMember = "T_Equipo";
            this.tLocalizacionEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameequipo});
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameequipo
            // 
            this.colnameequipo.Caption = "Equipo";
            this.colnameequipo.FieldName = "nameloceq";
            this.colnameequipo.Name = "colnameequipo";
            this.colnameequipo.Visible = true;
            this.colnameequipo.VisibleIndex = 0;
            // 
            // colidtipoorden
            // 
            this.colidtipoorden.Caption = "Tipo de Orden";
            this.colidtipoorden.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colidtipoorden.FieldName = "idtipointervencion";
            this.colidtipoorden.Name = "colidtipoorden";
            this.colidtipoorden.Visible = true;
            this.colidtipoorden.VisibleIndex = 2;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colidresponsable
            // 
            this.colidresponsable.Caption = "Responsable";
            this.colidresponsable.ColumnEdit = this.repositoryItemGridLookUpEdit6;
            this.colidresponsable.FieldName = "idresponsable";
            this.colidresponsable.Name = "colidresponsable";
            this.colidresponsable.Visible = true;
            this.colidresponsable.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEdit6
            // 
            this.repositoryItemGridLookUpEdit6.AutoHeight = false;
            this.repositoryItemGridLookUpEdit6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit6.DataSource = this.tEmpleadoBindingSource;
            this.repositoryItemGridLookUpEdit6.DisplayMember = "nameempleado";
            this.repositoryItemGridLookUpEdit6.Name = "repositoryItemGridLookUpEdit6";
            this.repositoryItemGridLookUpEdit6.ValueMember = "idempleado";
            this.repositoryItemGridLookUpEdit6.View = this.repositoryItemGridLookUpEdit6View;
            // 
            // tEmpleadoBindingSource
            // 
            this.tEmpleadoBindingSource.DataMember = "T_Empleado";
            this.tEmpleadoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit6View
            // 
            this.repositoryItemGridLookUpEdit6View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameempleado});
            this.repositoryItemGridLookUpEdit6View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit6View.Name = "repositoryItemGridLookUpEdit6View";
            this.repositoryItemGridLookUpEdit6View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit6View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameempleado
            // 
            this.colnameempleado.Caption = "Empleado";
            this.colnameempleado.FieldName = "nameempleado";
            this.colnameempleado.Name = "colnameempleado";
            this.colnameempleado.Visible = true;
            this.colnameempleado.VisibleIndex = 0;
            // 
            // colidestado
            // 
            this.colidestado.Caption = "Estado Orden";
            this.colidestado.ColumnEdit = this.repositoryItemGridLookUpEdit7;
            this.colidestado.FieldName = "idestadoorden";
            this.colidestado.Name = "colidestado";
            this.colidestado.Visible = true;
            this.colidestado.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEdit7
            // 
            this.repositoryItemGridLookUpEdit7.AutoHeight = false;
            this.repositoryItemGridLookUpEdit7.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit7.DataSource = this.tEstadoOrdenBindingSource;
            this.repositoryItemGridLookUpEdit7.DisplayMember = "nameestado";
            this.repositoryItemGridLookUpEdit7.Name = "repositoryItemGridLookUpEdit7";
            this.repositoryItemGridLookUpEdit7.ValueMember = "idestado";
            this.repositoryItemGridLookUpEdit7.View = this.repositoryItemGridLookUpEdit7View;
            // 
            // tEstadoOrdenBindingSource
            // 
            this.tEstadoOrdenBindingSource.DataMember = "T_EstadoOrden";
            this.tEstadoOrdenBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit7View
            // 
            this.repositoryItemGridLookUpEdit7View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameestado});
            this.repositoryItemGridLookUpEdit7View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit7View.Name = "repositoryItemGridLookUpEdit7View";
            this.repositoryItemGridLookUpEdit7View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit7View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameestado
            // 
            this.colnameestado.Caption = "Estado";
            this.colnameestado.FieldName = "nameestado";
            this.colnameestado.Name = "colnameestado";
            this.colnameestado.Visible = true;
            this.colnameestado.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estado Confirmacion";
            this.gridColumn1.ColumnEdit = this.repositoryItemGridLookUpEdit8;
            this.gridColumn1.FieldName = "idestado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // repositoryItemGridLookUpEdit8
            // 
            this.repositoryItemGridLookUpEdit8.AutoHeight = false;
            this.repositoryItemGridLookUpEdit8.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit8.DataSource = this.tEstadoBindingSource;
            this.repositoryItemGridLookUpEdit8.DisplayMember = "nameestado";
            this.repositoryItemGridLookUpEdit8.Name = "repositoryItemGridLookUpEdit8";
            this.repositoryItemGridLookUpEdit8.ValueMember = "idestado";
            this.repositoryItemGridLookUpEdit8.View = this.repositoryItemGridLookUpEdit8View;
            // 
            // tEstadoBindingSource
            // 
            this.tEstadoBindingSource.DataMember = "T_Estado";
            this.tEstadoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit8View
            // 
            this.repositoryItemGridLookUpEdit8View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit8View.Name = "repositoryItemGridLookUpEdit8View";
            this.repositoryItemGridLookUpEdit8View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit8View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tIntervencionBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "nameintervencion";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idintervencion";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameintervencion});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameintervencion
            // 
            this.colnameintervencion.Caption = "Intervencion";
            this.colnameintervencion.FieldName = "nameintervencion";
            this.colnameintervencion.Name = "colnameintervencion";
            this.colnameintervencion.Visible = true;
            this.colnameintervencion.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit4
            // 
            this.repositoryItemGridLookUpEdit4.AutoHeight = false;
            this.repositoryItemGridLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit4.DataSource = this.tTipoIntervecionBindingSource1;
            this.repositoryItemGridLookUpEdit4.DisplayMember = "nametipointer";
            this.repositoryItemGridLookUpEdit4.Name = "repositoryItemGridLookUpEdit4";
            this.repositoryItemGridLookUpEdit4.ValueMember = "idtipointerv";
            this.repositoryItemGridLookUpEdit4.View = this.repositoryItemGridLookUpEdit4View;
            // 
            // repositoryItemGridLookUpEdit4View
            // 
            this.repositoryItemGridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipointer1});
            this.repositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit4View.Name = "repositoryItemGridLookUpEdit4View";
            this.repositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipointer1
            // 
            this.colnametipointer1.Caption = "Tipo Intervencion";
            this.colnametipointer1.FieldName = "nametipointer";
            this.colnametipointer1.Name = "colnametipointer1";
            this.colnametipointer1.Visible = true;
            this.colnametipointer1.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit5
            // 
            this.repositoryItemGridLookUpEdit5.AutoHeight = false;
            this.repositoryItemGridLookUpEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit5.DataSource = this.tTipoTrabajoBindingSource;
            this.repositoryItemGridLookUpEdit5.DisplayMember = "nametipotrabajo";
            this.repositoryItemGridLookUpEdit5.Name = "repositoryItemGridLookUpEdit5";
            this.repositoryItemGridLookUpEdit5.ValueMember = "idtipotrabajo";
            this.repositoryItemGridLookUpEdit5.View = this.repositoryItemGridLookUpEdit5View;
            // 
            // tTipoTrabajoBindingSource
            // 
            this.tTipoTrabajoBindingSource.DataMember = "T_TipoTrabajo";
            this.tTipoTrabajoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit5View
            // 
            this.repositoryItemGridLookUpEdit5View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipotrabajo});
            this.repositoryItemGridLookUpEdit5View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit5View.Name = "repositoryItemGridLookUpEdit5View";
            this.repositoryItemGridLookUpEdit5View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit5View.OptionsView.ShowGroupPanel = false;
            // 
            // colnametipotrabajo
            // 
            this.colnametipotrabajo.Caption = "Tipo de Trabajo";
            this.colnametipotrabajo.FieldName = "nametipotrabajo";
            this.colnametipotrabajo.Name = "colnametipotrabajo";
            this.colnametipotrabajo.Visible = true;
            this.colnametipotrabajo.VisibleIndex = 0;
            // 
            // tEquipoBindingSource
            // 
            this.tEquipoBindingSource.DataMember = "T_Equipo";
            this.tEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(663, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 343);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Detalle";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.idestadoGridLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.idordentrabajoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.fechasolDateEdit);
            this.dataLayoutControl1.Controls.Add(this.fechainiplanDateEdit);
            this.dataLayoutControl1.Controls.Add(this.noordenSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idequipoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idtipotrabajoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idresponsableSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.mateypiezaplanSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.salarioplanSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.actividadesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.idestadoSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.idtipoordenSpinEdit);
            this.dataLayoutControl1.DataSource = this.t_OrdenTrabajoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidordentrabajo});
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 21);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(256, 320);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // idestadoGridLookUpEdit
            // 
            this.idestadoGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idestado", true));
            this.idestadoGridLookUpEdit.Location = new System.Drawing.Point(109, 60);
            this.idestadoGridLookUpEdit.MenuManager = this.barManager1;
            this.idestadoGridLookUpEdit.Name = "idestadoGridLookUpEdit";
            this.idestadoGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idestadoGridLookUpEdit.Properties.DataSource = this.tEstadoBindingSource;
            this.idestadoGridLookUpEdit.Properties.DisplayMember = "nameestado";
            this.idestadoGridLookUpEdit.Properties.ValueMember = "idestado";
            this.idestadoGridLookUpEdit.Properties.View = this.idestadoGridLookUpEditView;
            this.idestadoGridLookUpEdit.Size = new System.Drawing.Size(118, 20);
            this.idestadoGridLookUpEdit.StyleController = this.dataLayoutControl1;
            this.idestadoGridLookUpEdit.TabIndex = 20;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Personalizada 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(203, 206);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Personalizada 2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Emitir Nueva";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Seguir";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cancelar";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageIndex = 1;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 40);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(929, 47);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(929, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Size = new System.Drawing.Size(929, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(929, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "ordenadd.png");
            this.imageCollection1.Images.SetKeyName(1, "ordendel.png");
            this.imageCollection1.Images.SetKeyName(2, "ordenedit.png");
            // 
            // idestadoGridLookUpEditView
            // 
            this.idestadoGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.idestadoGridLookUpEditView.Name = "idestadoGridLookUpEditView";
            this.idestadoGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.idestadoGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // idordentrabajoSpinEdit
            // 
            this.idordentrabajoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idordentrabajo", true));
            this.idordentrabajoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idordentrabajoSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.idordentrabajoSpinEdit.MenuManager = this.barManager1;
            this.idordentrabajoSpinEdit.Name = "idordentrabajoSpinEdit";
            this.idordentrabajoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.idordentrabajoSpinEdit.Size = new System.Drawing.Size(0, 20);
            this.idordentrabajoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idordentrabajoSpinEdit.TabIndex = 4;
            // 
            // fechasolDateEdit
            // 
            this.fechasolDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "fechasol", true));
            this.fechasolDateEdit.EditValue = null;
            this.fechasolDateEdit.Location = new System.Drawing.Point(60, 295);
            this.fechasolDateEdit.MenuManager = this.barManager1;
            this.fechasolDateEdit.Name = "fechasolDateEdit";
            this.fechasolDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechasolDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechasolDateEdit.Size = new System.Drawing.Size(167, 20);
            this.fechasolDateEdit.StyleController = this.dataLayoutControl1;
            this.fechasolDateEdit.TabIndex = 15;
            // 
            // fechainiplanDateEdit
            // 
            this.fechainiplanDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "fechainiplan", true));
            this.fechainiplanDateEdit.EditValue = null;
            this.fechainiplanDateEdit.Location = new System.Drawing.Point(90, 259);
            this.fechainiplanDateEdit.MenuManager = this.barManager1;
            this.fechainiplanDateEdit.Name = "fechainiplanDateEdit";
            this.fechainiplanDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechainiplanDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fechainiplanDateEdit.Size = new System.Drawing.Size(125, 20);
            this.fechainiplanDateEdit.StyleController = this.dataLayoutControl1;
            this.fechainiplanDateEdit.TabIndex = 16;
            // 
            // noordenSpinEdit
            // 
            this.noordenSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "noorden", true));
            this.noordenSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.noordenSpinEdit.Location = new System.Drawing.Point(71, 12);
            this.noordenSpinEdit.MenuManager = this.barManager1;
            this.noordenSpinEdit.Name = "noordenSpinEdit";
            this.noordenSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.noordenSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.noordenSpinEdit.Size = new System.Drawing.Size(156, 20);
            this.noordenSpinEdit.StyleController = this.dataLayoutControl1;
            this.noordenSpinEdit.TabIndex = 5;
            // 
            // idequipoSpinEdit
            // 
            this.idequipoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idequipo", true));
            this.idequipoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idequipoSpinEdit.Location = new System.Drawing.Point(53, 84);
            this.idequipoSpinEdit.MenuManager = this.barManager1;
            this.idequipoSpinEdit.Name = "idequipoSpinEdit";
            this.idequipoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idequipoSpinEdit.Properties.DataSource = this.tLocalizacionEquipoBindingSource;
            this.idequipoSpinEdit.Properties.DisplayMember = "matricula";
            this.idequipoSpinEdit.Properties.NullText = "";
            this.idequipoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idequipoSpinEdit.Properties.ValueMember = "idequipo";
            this.idequipoSpinEdit.Properties.View = this.gridView2;
            this.idequipoSpinEdit.Size = new System.Drawing.Size(174, 20);
            this.idequipoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idequipoSpinEdit.TabIndex = 7;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // idtipotrabajoSpinEdit
            // 
            this.idtipotrabajoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idtipotrabajo", true));
            this.idtipotrabajoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipotrabajoSpinEdit.Location = new System.Drawing.Point(81, 132);
            this.idtipotrabajoSpinEdit.MenuManager = this.barManager1;
            this.idtipotrabajoSpinEdit.Name = "idtipotrabajoSpinEdit";
            this.idtipotrabajoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idtipotrabajoSpinEdit.Properties.DataSource = this.tTipoTrabajoBindingSource;
            this.idtipotrabajoSpinEdit.Properties.DisplayMember = "nametipotrabajo";
            this.idtipotrabajoSpinEdit.Properties.NullText = "";
            this.idtipotrabajoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idtipotrabajoSpinEdit.Properties.ValueMember = "idtipotrabajo";
            this.idtipotrabajoSpinEdit.Properties.View = this.gridView4;
            this.idtipotrabajoSpinEdit.Size = new System.Drawing.Size(146, 20);
            this.idtipotrabajoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtipotrabajoSpinEdit.TabIndex = 9;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // idresponsableSpinEdit
            // 
            this.idresponsableSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idresponsable", true));
            this.idresponsableSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idresponsableSpinEdit.Location = new System.Drawing.Point(82, 156);
            this.idresponsableSpinEdit.MenuManager = this.barManager1;
            this.idresponsableSpinEdit.Name = "idresponsableSpinEdit";
            this.idresponsableSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idresponsableSpinEdit.Properties.DataSource = this.tEmpleadoBindingSource;
            this.idresponsableSpinEdit.Properties.DisplayMember = "nameempleado";
            this.idresponsableSpinEdit.Properties.NullText = "";
            this.idresponsableSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idresponsableSpinEdit.Properties.ValueMember = "idempleado";
            this.idresponsableSpinEdit.Properties.View = this.gridView5;
            this.idresponsableSpinEdit.Size = new System.Drawing.Size(145, 20);
            this.idresponsableSpinEdit.StyleController = this.dataLayoutControl1;
            this.idresponsableSpinEdit.TabIndex = 10;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // mateypiezaplanSpinEdit
            // 
            this.mateypiezaplanSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "mateypiezaplan", true));
            this.mateypiezaplanSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mateypiezaplanSpinEdit.Location = new System.Drawing.Point(141, 211);
            this.mateypiezaplanSpinEdit.MenuManager = this.barManager1;
            this.mateypiezaplanSpinEdit.Name = "mateypiezaplanSpinEdit";
            this.mateypiezaplanSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.mateypiezaplanSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.mateypiezaplanSpinEdit.Size = new System.Drawing.Size(74, 20);
            this.mateypiezaplanSpinEdit.StyleController = this.dataLayoutControl1;
            this.mateypiezaplanSpinEdit.TabIndex = 13;
            // 
            // salarioplanSpinEdit
            // 
            this.salarioplanSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "salarioplan", true));
            this.salarioplanSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.salarioplanSpinEdit.Location = new System.Drawing.Point(82, 235);
            this.salarioplanSpinEdit.MenuManager = this.barManager1;
            this.salarioplanSpinEdit.Name = "salarioplanSpinEdit";
            this.salarioplanSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.salarioplanSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.salarioplanSpinEdit.Size = new System.Drawing.Size(133, 20);
            this.salarioplanSpinEdit.StyleController = this.dataLayoutControl1;
            this.salarioplanSpinEdit.TabIndex = 14;
            // 
            // actividadesTextEdit
            // 
            this.actividadesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "actividades", true));
            this.actividadesTextEdit.Location = new System.Drawing.Point(74, 319);
            this.actividadesTextEdit.MenuManager = this.barManager1;
            this.actividadesTextEdit.Name = "actividadesTextEdit";
            this.actividadesTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.actividadesTextEdit.Size = new System.Drawing.Size(153, 20);
            this.actividadesTextEdit.StyleController = this.dataLayoutControl1;
            this.actividadesTextEdit.TabIndex = 17;
            // 
            // idestadoSpinEdit
            // 
            this.idestadoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idestado", true));
            this.idestadoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idestadoSpinEdit.Location = new System.Drawing.Point(87, 36);
            this.idestadoSpinEdit.MenuManager = this.barManager1;
            this.idestadoSpinEdit.Name = "idestadoSpinEdit";
            this.idestadoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idestadoSpinEdit.Properties.DataSource = this.tEstadoOrdenBindingSource;
            this.idestadoSpinEdit.Properties.DisplayMember = "nameestado";
            this.idestadoSpinEdit.Properties.NullText = "";
            this.idestadoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idestadoSpinEdit.Properties.ValueMember = "idestado";
            this.idestadoSpinEdit.Properties.View = this.gridView6;
            this.idestadoSpinEdit.Size = new System.Drawing.Size(140, 20);
            this.idestadoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idestadoSpinEdit.TabIndex = 18;
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // idtipoordenSpinEdit
            // 
            this.idtipoordenSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.t_OrdenTrabajoBindingSource, "idtipointervencion", true));
            this.idtipoordenSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idtipoordenSpinEdit.Location = new System.Drawing.Point(74, 108);
            this.idtipoordenSpinEdit.MenuManager = this.barManager1;
            this.idtipoordenSpinEdit.Name = "idtipoordenSpinEdit";
            this.idtipoordenSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idtipoordenSpinEdit.Properties.PopupSizeable = true;
            this.idtipoordenSpinEdit.Size = new System.Drawing.Size(153, 20);
            this.idtipoordenSpinEdit.StyleController = this.dataLayoutControl1;
            this.idtipoordenSpinEdit.TabIndex = 8;
            // 
            // ItemForidordentrabajo
            // 
            this.ItemForidordentrabajo.Control = this.idordentrabajoSpinEdit;
            this.ItemForidordentrabajo.CustomizationFormText = "idordentrabajo";
            this.ItemForidordentrabajo.Location = new System.Drawing.Point(0, 0);
            this.ItemForidordentrabajo.Name = "ItemForidordentrabajo";
            this.ItemForidordentrabajo.Size = new System.Drawing.Size(0, 0);
            this.ItemForidordentrabajo.Text = "idordentrabajo";
            this.ItemForidordentrabajo.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForidordentrabajo.TextToControlDistance = 5;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(239, 351);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFornoorden,
            this.ItemForidequipo,
            this.ItemForidtipoorden,
            this.ItemForidtipotrabajo,
            this.ItemForfechasol,
            this.ItemForactividades,
            this.layoutControlGroup3,
            this.ItemForidresponsable,
            this.ItemForidestado,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(219, 331);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemFornoorden
            // 
            this.ItemFornoorden.Control = this.noordenSpinEdit;
            this.ItemFornoorden.CustomizationFormText = "noorden";
            this.ItemFornoorden.Location = new System.Drawing.Point(0, 0);
            this.ItemFornoorden.Name = "ItemFornoorden";
            this.ItemFornoorden.Size = new System.Drawing.Size(219, 24);
            this.ItemFornoorden.Text = "No. Orden:";
            this.ItemFornoorden.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemFornoorden.TextSize = new System.Drawing.Size(54, 13);
            this.ItemFornoorden.TextToControlDistance = 5;
            // 
            // ItemForidequipo
            // 
            this.ItemForidequipo.Control = this.idequipoSpinEdit;
            this.ItemForidequipo.CustomizationFormText = "idequipo";
            this.ItemForidequipo.Location = new System.Drawing.Point(0, 72);
            this.ItemForidequipo.Name = "ItemForidequipo";
            this.ItemForidequipo.Size = new System.Drawing.Size(219, 24);
            this.ItemForidequipo.Text = "Equipo:";
            this.ItemForidequipo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForidequipo.TextSize = new System.Drawing.Size(36, 13);
            this.ItemForidequipo.TextToControlDistance = 5;
            // 
            // ItemForidtipoorden
            // 
            this.ItemForidtipoorden.Control = this.idtipoordenSpinEdit;
            this.ItemForidtipoorden.CustomizationFormText = "idtipoorden";
            this.ItemForidtipoorden.Location = new System.Drawing.Point(0, 96);
            this.ItemForidtipoorden.Name = "ItemForidtipoorden";
            this.ItemForidtipoorden.Size = new System.Drawing.Size(219, 24);
            this.ItemForidtipoorden.Text = "Tipo Orden:";
            this.ItemForidtipoorden.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForidtipoorden.TextSize = new System.Drawing.Size(57, 13);
            this.ItemForidtipoorden.TextToControlDistance = 5;
            // 
            // ItemForidtipotrabajo
            // 
            this.ItemForidtipotrabajo.Control = this.idtipotrabajoSpinEdit;
            this.ItemForidtipotrabajo.CustomizationFormText = "idtipotrabajo";
            this.ItemForidtipotrabajo.Location = new System.Drawing.Point(0, 120);
            this.ItemForidtipotrabajo.Name = "ItemForidtipotrabajo";
            this.ItemForidtipotrabajo.Size = new System.Drawing.Size(219, 24);
            this.ItemForidtipotrabajo.Text = "Tipo Trabajo:";
            this.ItemForidtipotrabajo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForidtipotrabajo.TextSize = new System.Drawing.Size(64, 13);
            this.ItemForidtipotrabajo.TextToControlDistance = 5;
            // 
            // ItemForfechasol
            // 
            this.ItemForfechasol.Control = this.fechasolDateEdit;
            this.ItemForfechasol.CustomizationFormText = "fechasol";
            this.ItemForfechasol.Location = new System.Drawing.Point(0, 283);
            this.ItemForfechasol.Name = "ItemForfechasol";
            this.ItemForfechasol.Size = new System.Drawing.Size(219, 24);
            this.ItemForfechasol.Text = "Solicitud:";
            this.ItemForfechasol.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForfechasol.TextSize = new System.Drawing.Size(43, 13);
            this.ItemForfechasol.TextToControlDistance = 5;
            // 
            // ItemForactividades
            // 
            this.ItemForactividades.Control = this.actividadesTextEdit;
            this.ItemForactividades.CustomizationFormText = "actividades";
            this.ItemForactividades.Location = new System.Drawing.Point(0, 307);
            this.ItemForactividades.Name = "ItemForactividades";
            this.ItemForactividades.Size = new System.Drawing.Size(219, 24);
            this.ItemForactividades.Text = "Actvidades:";
            this.ItemForactividades.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForactividades.TextSize = new System.Drawing.Size(57, 13);
            this.ItemForactividades.TextToControlDistance = 5;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "Plan";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForsalarioplan,
            this.ItemFormateypiezaplan,
            this.ItemForfechainiplan});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 168);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(219, 115);
            this.layoutControlGroup3.Text = "Plan";
            // 
            // ItemForsalarioplan
            // 
            this.ItemForsalarioplan.Control = this.salarioplanSpinEdit;
            this.ItemForsalarioplan.CustomizationFormText = "salarioplan";
            this.ItemForsalarioplan.Location = new System.Drawing.Point(0, 24);
            this.ItemForsalarioplan.Name = "ItemForsalarioplan";
            this.ItemForsalarioplan.Size = new System.Drawing.Size(195, 24);
            this.ItemForsalarioplan.Text = "Salario ($):";
            this.ItemForsalarioplan.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForsalarioplan.TextSize = new System.Drawing.Size(53, 13);
            this.ItemForsalarioplan.TextToControlDistance = 5;
            // 
            // ItemFormateypiezaplan
            // 
            this.ItemFormateypiezaplan.Control = this.mateypiezaplanSpinEdit;
            this.ItemFormateypiezaplan.CustomizationFormText = "mateypiezaplan";
            this.ItemFormateypiezaplan.Location = new System.Drawing.Point(0, 0);
            this.ItemFormateypiezaplan.Name = "ItemFormateypiezaplan";
            this.ItemFormateypiezaplan.Size = new System.Drawing.Size(195, 24);
            this.ItemFormateypiezaplan.Text = "Materiales y piezas ($):";
            this.ItemFormateypiezaplan.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemFormateypiezaplan.TextSize = new System.Drawing.Size(112, 13);
            this.ItemFormateypiezaplan.TextToControlDistance = 5;
            // 
            // ItemForfechainiplan
            // 
            this.ItemForfechainiplan.Control = this.fechainiplanDateEdit;
            this.ItemForfechainiplan.CustomizationFormText = "fechainiplan";
            this.ItemForfechainiplan.Location = new System.Drawing.Point(0, 48);
            this.ItemForfechainiplan.Name = "ItemForfechainiplan";
            this.ItemForfechainiplan.Size = new System.Drawing.Size(195, 24);
            this.ItemForfechainiplan.Text = "Fecha Inicio:";
            this.ItemForfechainiplan.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForfechainiplan.TextSize = new System.Drawing.Size(61, 13);
            this.ItemForfechainiplan.TextToControlDistance = 5;
            // 
            // ItemForidresponsable
            // 
            this.ItemForidresponsable.Control = this.idresponsableSpinEdit;
            this.ItemForidresponsable.CustomizationFormText = "idresponsable";
            this.ItemForidresponsable.Location = new System.Drawing.Point(0, 144);
            this.ItemForidresponsable.Name = "ItemForidresponsable";
            this.ItemForidresponsable.Size = new System.Drawing.Size(219, 24);
            this.ItemForidresponsable.Text = "Responsable:";
            this.ItemForidresponsable.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForidresponsable.TextSize = new System.Drawing.Size(65, 13);
            this.ItemForidresponsable.TextToControlDistance = 5;
            // 
            // ItemForidestado
            // 
            this.ItemForidestado.Control = this.idestadoSpinEdit;
            this.ItemForidestado.CustomizationFormText = "idestado";
            this.ItemForidestado.Location = new System.Drawing.Point(0, 24);
            this.ItemForidestado.MaxSize = new System.Drawing.Size(0, 24);
            this.ItemForidestado.MinSize = new System.Drawing.Size(96, 24);
            this.ItemForidestado.Name = "ItemForidestado";
            this.ItemForidestado.Size = new System.Drawing.Size(219, 24);
            this.ItemForidestado.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForidestado.Text = "Estado Orden:";
            this.ItemForidestado.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForidestado.TextSize = new System.Drawing.Size(70, 13);
            this.ItemForidestado.TextToControlDistance = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.idestadoGridLookUpEdit;
            this.layoutControlItem2.CustomizationFormText = "Estado Documento:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(219, 24);
            this.layoutControlItem2.Text = "Estado Documento:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // t_EquipoTableAdapter
            // 
            this.t_EquipoTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoTrabajoTableAdapter
            // 
            this.t_TipoTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // t_EmpleadoTableAdapter
            // 
            this.t_EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_EstadoOrdenTableAdapter
            // 
            this.t_EstadoOrdenTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 87);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(929, 351);
            this.panelControl1.TabIndex = 8;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.t_OrdenTrabajoGridControl);
            this.panelControl2.Controls.Add(this.splitterControl1);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(925, 347);
            this.panelControl2.TabIndex = 0;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl1.Location = new System.Drawing.Point(658, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 343);
            this.splitterControl1.TabIndex = 4;
            this.splitterControl1.TabStop = false;
            // 
            // t_EstadoTableAdapter
            // 
            this.t_EstadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_CategoriaTableAdapter1
            // 
            this.t_CategoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TipoModeloAccionTableAdapter1
            // 
            this.t_TipoModeloAccionTableAdapter1.ClearBeforeFill = true;
            // 
            // t_TipoModeloMantTableAdapter1
            // 
            this.t_TipoModeloMantTableAdapter1.ClearBeforeFill = true;
            // 
            // t_PlanificacionTableAdapter1
            // 
            this.t_PlanificacionTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 438);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmOrdenTrabajo";
            this.Text = "FrmOrdenTrabajo";
            this.Load += new System.EventHandler(this.FrmOrdenTrabajo_Load);
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.standaloneBarDockControl1, 0);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_OrdenTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_OrdenTrabajoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLocalizacionEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit6View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoOrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit7View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit8View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIntervencionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoIntervecionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit5View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoIntervecionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idestadoGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idordentrabajoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasolDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechasolDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechainiplanDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechainiplanDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noordenSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idequipoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipotrabajoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idresponsableSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mateypiezaplanSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarioplanSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idtipoordenSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidordentrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornoorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidequipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipoorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidtipotrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfechasol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForactividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForsalarioplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormateypiezaplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfechainiplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidresponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidestado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_OrdenTrabajoBindingSource;
        private DSDatosTableAdapters.T_OrdenTrabajoTableAdapter t_OrdenTrabajoTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_OrdenTrabajoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn colnoorden;
        private DevExpress.XtraGrid.Columns.GridColumn colidequipo;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipoorden;
        private DevExpress.XtraGrid.Columns.GridColumn colidresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colidestado;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tTipoIntervecionBindingSource;
    
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private System.Windows.Forms.BindingSource tEquipoBindingSource;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit4View;
   
         private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit5View;
        private System.Windows.Forms.BindingSource tTipoTrabajoBindingSource;
        private DSDatosTableAdapters.T_TipoTrabajoTableAdapter t_TipoTrabajoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit6;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit6View;
        private System.Windows.Forms.BindingSource tEmpleadoBindingSource;
        private DSDatosTableAdapters.T_EmpleadoTableAdapter t_EmpleadoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit7;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit7View;
        private System.Windows.Forms.BindingSource tEstadoOrdenBindingSource;
        private DSDatosTableAdapters.T_EstadoOrdenTableAdapter t_EstadoOrdenTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameequipo;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipotrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colnameempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colnameestado;
        private System.Windows.Forms.BindingSource tLocalizacionEquipoBindingSource;
 
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SpinEdit idordentrabajoSpinEdit;
        private DevExpress.XtraEditors.DateEdit fechasolDateEdit;
        private DevExpress.XtraEditors.DateEdit fechainiplanDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidordentrabajo;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornoorden;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidequipo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtipoorden;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidtipotrabajo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidresponsable;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormateypiezaplan;
        private DevExpress.XtraLayout.LayoutControlItem ItemForsalarioplan;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfechasol;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfechainiplan;
        private DevExpress.XtraLayout.LayoutControlItem ItemForactividades;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidestado;
        private DevExpress.XtraEditors.TextEdit noordenSpinEdit;
        private DevExpress.XtraEditors.GridLookUpEdit idequipoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit idtipotrabajoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GridLookUpEdit idresponsableSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.TextEdit mateypiezaplanSpinEdit;
        private DevExpress.XtraEditors.TextEdit salarioplanSpinEdit;
        private DevExpress.XtraEditors.MemoExEdit actividadesTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit idestadoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit8;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit8View;
        private System.Windows.Forms.BindingSource tEstadoBindingSource;
        private DSDatosTableAdapters.T_EstadoTableAdapter t_EstadoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idestadoGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView idestadoGridLookUpEditView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource tTipoIntervecionBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipointer1;
        private System.Windows.Forms.BindingSource tIntervencionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnameintervencion;
        private DSDatosTableAdapters.T_CategoriaTableAdapter t_CategoriaTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.ImageComboBoxEdit idtipoordenSpinEdit;
        private DSDatosTableAdapters.T_TipoModeloAccionTableAdapter t_TipoModeloAccionTableAdapter1;
        private DSDatosTableAdapters.T_TipoModeloMantTableAdapter t_TipoModeloMantTableAdapter1;
        private DSDatosTableAdapters.T_PlanificacionTableAdapter t_PlanificacionTableAdapter1;


    }
}