using GTrans.Reportes;
using GTrans.Reportes.DSReporteTableAdapters;
namespace GTrans.Tareas
{
    partial class FrmConsumo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsumo));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView1 = new DevExpress.XtraCharts.StackedLineSeriesView();
            DevExpress.XtraCharts.StackedLineSeriesView stackedLineSeriesView2 = new DevExpress.XtraCharts.StackedLineSeriesView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.colnombre_ueb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidequipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcantidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colodometro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tConsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pGraficoGastoPorAreaCombBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSGraficos = new GTrans.Graficos.DSGraficos();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.dSGraficosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_YearsConsumnTableAdapter1 = new GTrans.Reportes.DSReporteTableAdapters.P_YearsConsumnTableAdapter();
            this.dsReporte1 = new GTrans.Reportes.DSReporte();
            this.t_ConsumoTableAdapter = new GTrans.DSDatosTableAdapters.T_ConsumoTableAdapter();
            this.t_EmpresaTableAdapter = new GTrans.DSDatosTableAdapters.T_EmpresaTableAdapter();
            this.t_AreaTableAdapter1 = new GTrans.DSDatosTableAdapters.T_AreaTableAdapter();
            this.t_UEBTableAdapter1 = new GTrans.DSDatosTableAdapters.T_UEBTableAdapter();
            this.t_EquipoTableAdapter1 = new GTrans.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.t_ConsumoEquipoTableAdapter1 = new GTrans.DSDatosTableAdapters.T_ConsumoEquipoTableAdapter();
            this.t_EstadoTableAdapter = new GTrans.DSDatosTableAdapters.T_EstadoTableAdapter();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.p_GraficoGastoPorAreaCombTableAdapter = new GTrans.Graficos.DSGraficosTableAdapters.P_GraficoGastoPorAreaCombTableAdapter();
            this.tableAdapterManager1 = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGraficoGastoPorAreaCombBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGraficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGraficosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(715, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(771, 40);
            // 
            // gridView5
            // 
            this.gridView5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colnombre_ueb});
            this.gridView5.GridControl = this.gridControl1;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsBehavior.ReadOnly = true;
            this.gridView5.OptionsDetail.ShowDetailTabs = false;
            this.gridView5.OptionsView.ShowColumnHeaders = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.OptionsView.ShowIndicator = false;
            this.gridView5.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn2.FieldName = "gridColumn2";
            this.gridColumn2.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.UnboundExpression = "1";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 50;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 3, 3)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("home_32x32.png", "images/navigation/home_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/navigation/home_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "home_32x32.png");
            this.imageCollection1.InsertGalleryImage("bringtofront_32x32.png", "images/arrange/bringtofront_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrange/bringtofront_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "bringtofront_32x32.png");
            this.imageCollection1.InsertGalleryImage("sendbackward_32x32.png", "images/arrange/sendbackward_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/arrange/sendbackward_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "sendbackward_32x32.png");
            this.imageCollection1.Images.SetKeyName(3, "truck.png");
            this.imageCollection1.Images.SetKeyName(4, "consadd.png");
            this.imageCollection1.Images.SetKeyName(5, "consedit.png");
            this.imageCollection1.Images.SetKeyName(6, "consdelete.png");
            // 
            // colnombre_ueb
            // 
            this.colnombre_ueb.FieldName = "nombre_ueb";
            this.colnombre_ueb.Name = "colnombre_ueb";
            this.colnombre_ueb.Visible = true;
            this.colnombre_ueb.VisibleIndex = 1;
            this.colnombre_ueb.Width = 73;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.tEmpresaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            gridLevelNode1.LevelTemplate = this.gridView5;
            gridLevelNode2.LevelTemplate = this.gridView4;
            gridLevelNode3.LevelTemplate = this.gridView3;
            gridLevelNode3.RelationName = "FK_T_Equipo_T_Area";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "FK_T_Area_T_UEB";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "FK_T_UEB_T_Empresa";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(160, 267);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView4,
            this.gridView5});
            // 
            // tEmpresaBindingSource
            // 
            this.tEmpresaBindingSource.DataMember = "T_Empresa";
            this.tEmpresaBindingSource.DataSource = this.dSDatos;
            this.tEmpresaBindingSource.CurrentChanged += new System.EventHandler(this.tEmpresaBindingSource_CurrentChanged);
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colnombre_empresa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.UnboundExpression = "0";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // colnombre_empresa
            // 
            this.colnombre_empresa.FieldName = "nombre_empresa";
            this.colnombre_empresa.Name = "colnombre_empresa";
            this.colnombre_empresa.Visible = true;
            this.colnombre_empresa.VisibleIndex = 1;
            this.colnombre_empresa.Width = 106;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(52, 206);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Menú principal";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Insertar";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageIndex = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.Tag = true;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Editar";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageIndex = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.Tag = false;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Eliminar ";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageIndex = 6;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 40);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(771, 40);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(771, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 351);
            this.barDockControlBottom.Size = new System.Drawing.Size(771, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 351);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(771, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 351);
            // 
            // gridView3
            // 
            this.gridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colmatricula});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsView.ShowColumnHeaders = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.OptionsView.ShowIndicator = false;
            this.gridView3.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn4.FieldName = "gridColumn4";
            this.gridColumn4.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.UnboundExpression = "3";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 50;
            // 
            // colmatricula
            // 
            this.colmatricula.FieldName = "matricula";
            this.colmatricula.Name = "colmatricula";
            this.colmatricula.Visible = true;
            this.colmatricula.VisibleIndex = 1;
            this.colmatricula.Width = 73;
            // 
            // gridView4
            // 
            this.gridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colnombre_area});
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsBehavior.ReadOnly = true;
            this.gridView4.OptionsDetail.ShowDetailTabs = false;
            this.gridView4.OptionsView.ShowColumnHeaders = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView4.OptionsView.ShowIndicator = false;
            this.gridView4.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.UnboundExpression = "2";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 50;
            // 
            // colnombre_area
            // 
            this.colnombre_area.FieldName = "nombre_area";
            this.colnombre_area.Name = "colnombre_area";
            this.colnombre_area.Visible = true;
            this.colnombre_area.VisibleIndex = 1;
            this.colnombre_area.Width = 73;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidequipo,
            this.colcantidad1,
            this.colimporte1,
            this.colodometro});
            this.gridView6.GridControl = this.gridControl2;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsBehavior.Editable = false;
            this.gridView6.OptionsBehavior.ReadOnly = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colidequipo
            // 
            this.colidequipo.Caption = "Equipo";
            this.colidequipo.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidequipo.FieldName = "idequipo";
            this.colidequipo.Name = "colidequipo";
            this.colidequipo.Visible = true;
            this.colidequipo.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tEquipoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "matricula";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idequipo";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tEquipoBindingSource
            // 
            this.tEquipoBindingSource.DataMember = "T_Equipo";
            this.tEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colcantidad1
            // 
            this.colcantidad1.Caption = "Cantidad";
            this.colcantidad1.FieldName = "cantidad";
            this.colcantidad1.Name = "colcantidad1";
            this.colcantidad1.Visible = true;
            this.colcantidad1.VisibleIndex = 1;
            // 
            // colimporte1
            // 
            this.colimporte1.Caption = "Importe";
            this.colimporte1.FieldName = "importe";
            this.colimporte1.Name = "colimporte1";
            this.colimporte1.Visible = true;
            this.colimporte1.VisibleIndex = 2;
            // 
            // colodometro
            // 
            this.colodometro.Caption = "Odometro";
            this.colodometro.FieldName = "odometro";
            this.colodometro.Name = "colodometro";
            this.colodometro.Visible = true;
            this.colodometro.VisibleIndex = 3;
            // 
            // gridControl2
            // 
            this.gridControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.tConsumoBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode4.LevelTemplate = this.gridView6;
            gridLevelNode4.RelationName = "FK_T_ConsumoEquipo_T_Consumo";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            this.gridControl2.Location = new System.Drawing.Point(167, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl2.Size = new System.Drawing.Size(374, 267);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView6});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tConsumoBindingSource
            // 
            this.tConsumoBindingSource.DataMember = "T_Consumo";
            this.tConsumoBindingSource.DataSource = this.dSDatos;
            this.tConsumoBindingSource.CurrentChanged += new System.EventHandler(this.tConsumoBindingSource_CurrentChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colNoComprobante,
            this.colcantidad,
            this.colimporte,
            this.colidestado});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            // 
            // colNoComprobante
            // 
            this.colNoComprobante.FieldName = "NoComprobante";
            this.colNoComprobante.Name = "colNoComprobante";
            this.colNoComprobante.Visible = true;
            this.colNoComprobante.VisibleIndex = 1;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe Total";
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 3;
            // 
            // colidestado
            // 
            this.colidestado.Caption = "Estado";
            this.colidestado.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidestado.FieldName = "idestado";
            this.colidestado.Name = "colidestado";
            this.colidestado.Visible = true;
            this.colidestado.VisibleIndex = 4;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tEstadoBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "nameestado";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idestado";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tEstadoBindingSource
            // 
            this.tEstadoBindingSource.DataMember = "T_Estado";
            this.tEstadoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // pGraficoGastoPorAreaCombBindingSource
            // 
            this.pGraficoGastoPorAreaCombBindingSource.DataMember = "P_GraficoGastoPorAreaComb";
            this.pGraficoGastoPorAreaCombBindingSource.DataSource = this.dSGraficos;
            // 
            // dSGraficos
            // 
            this.dSGraficos.DataSetName = "DSGraficos";
            this.dSGraficos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chartControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(541, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(228, 267);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Estadisticas";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.dSGraficosBindingSource;
            xyDiagram1.AxisX.Title.Text = "Eje de argumentos";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Eje de valores";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.EmptyChartText.Text = "";
            this.chartControl1.Location = new System.Drawing.Point(2, 21);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "namemes";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.DataSource = this.pGraficoGastoPorAreaCombBindingSource;
            series1.Name = "Consumo";
            series1.ValueDataMembersSerializable = "cantidad";
            series1.View = stackedLineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.View = stackedLineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(224, 244);
            this.chartControl1.SmallChartText.Text = "Incrementar tamaño de gráfico,\\r\\npara ver distribución.";
            this.chartControl1.TabIndex = 0;
            // 
            // dSGraficosBindingSource
            // 
            this.dSGraficosBindingSource.DataMember = "P_GraficoGastoPorAreaComb";
            this.dSGraficosBindingSource.DataSource = this.dSGraficos;
            // 
            // p_YearsConsumnTableAdapter1
            // 
            this.p_YearsConsumnTableAdapter1.ClearBeforeFill = true;
            // 
            // dsReporte1
            // 
            this.dsReporte1.DataSetName = "DSReporte";
            this.dsReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_ConsumoTableAdapter
            // 
            this.t_ConsumoTableAdapter.ClearBeforeFill = true;
            // 
            // t_EmpresaTableAdapter
            // 
            this.t_EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // t_AreaTableAdapter1
            // 
            this.t_AreaTableAdapter1.ClearBeforeFill = true;
            // 
            // t_UEBTableAdapter1
            // 
            this.t_UEBTableAdapter1.ClearBeforeFill = true;
            // 
            // t_EquipoTableAdapter1
            // 
            this.t_EquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_ConsumoEquipoTableAdapter1
            // 
            this.t_ConsumoEquipoTableAdapter1.ClearBeforeFill = true;
            // 
            // t_EstadoTableAdapter
            // 
            this.t_EstadoTableAdapter.ClearBeforeFill = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitterControl2);
            this.panelControl1.Controls.Add(this.gridControl2);
            this.panelControl1.Controls.Add(this.splitterControl1);
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.barDockControl1);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 80);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(771, 271);
            this.panelControl1.TabIndex = 13;
            // 
            // splitterControl2
            // 
            this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterControl2.Location = new System.Drawing.Point(536, 2);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 267);
            this.splitterControl2.TabIndex = 9;
            this.splitterControl2.TabStop = false;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(162, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 267);
            this.splitterControl1.TabIndex = 7;
            this.splitterControl1.TabStop = false;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl1.Location = new System.Drawing.Point(2, 2);
            this.barDockControl1.Size = new System.Drawing.Size(0, 267);
            // 
            // p_GraficoGastoPorAreaCombTableAdapter
            // 
            this.p_GraficoGastoPorAreaCombTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.T_AlmacenExistenciaTableAdapter = null;
            this.tableAdapterManager1.T_AlmacenTableAdapter = null;
            this.tableAdapterManager1.T_AreaTableAdapter = this.t_AreaTableAdapter1;
            this.tableAdapterManager1.T_CategoriaTableAdapter = null;
            this.tableAdapterManager1.T_ClasificacionTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoEquipoTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoTableAdapter = null;
            this.tableAdapterManager1.T_Empleado_FormaTableAdapter = null;
            this.tableAdapterManager1.T_EmpleadoTableAdapter = null;
            this.tableAdapterManager1.T_EmpresaTableAdapter = this.t_EmpresaTableAdapter;
            this.tableAdapterManager1.T_EquipoTableAdapter = this.t_EquipoTableAdapter1;
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
            this.tableAdapterManager1.T_UEBTableAdapter = this.t_UEBTableAdapter1;
            this.tableAdapterManager1.T_UMTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaMonedaTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 374);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmConsumo";
            this.Text = "FrmConsumo";
            this.Load += new System.EventHandler(this.FrmConsumo_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGraficoGastoPorAreaCombBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGraficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedLineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGraficosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tEmpresaBindingSource;
        private DSDatosTableAdapters.T_EmpresaTableAdapter t_EmpresaTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_empresa;
        private DSDatosTableAdapters.T_AreaTableAdapter t_AreaTableAdapter1;
        private DSDatosTableAdapters.T_UEBTableAdapter t_UEBTableAdapter1;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_ueb;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_area;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricula;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DSDatosTableAdapters.T_ConsumoTableAdapter t_ConsumoTableAdapter;
        private System.Windows.Forms.BindingSource tConsumoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colidequipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte1;
        private DevExpress.XtraGrid.Columns.GridColumn colodometro;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNoComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn colidestado;
        private DSDatosTableAdapters.T_ConsumoEquipoTableAdapter t_ConsumoEquipoTableAdapter1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource tEquipoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private P_YearsConsumnTableAdapter p_YearsConsumnTableAdapter1;
        private DSReporte dsReporte1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource tEstadoBindingSource;
        private DSDatosTableAdapters.T_EstadoTableAdapter t_EstadoTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private Graficos.DSGraficos dSGraficos;
        private System.Windows.Forms.BindingSource pGraficoGastoPorAreaCombBindingSource;
        private Graficos.DSGraficosTableAdapters.P_GraficoGastoPorAreaCombTableAdapter p_GraficoGastoPorAreaCombTableAdapter;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource dSGraficosBindingSource;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}