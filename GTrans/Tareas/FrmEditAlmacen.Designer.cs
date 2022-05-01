namespace GTrans.Tareas
{
    partial class FrmEditAlmacen
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprecio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tAlmacenExistenciaTValeExistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAlmacenExistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcodproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.almacenlayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.namealmacenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tAlmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemFornamealmacen = new DevExpress.XtraLayout.LayoutControlItem();
            this.productolayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tTipoValeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipovale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.valeentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idalmacenSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tAlmacenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamealmacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForidalmacen = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForvaleent = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.t_AlmacenTableAdapter = new GTrans.DSDatosTableAdapters.T_AlmacenTableAdapter();
            this.t_AlmacenExistenciaTableAdapter = new GTrans.DSDatosTableAdapters.T_AlmacenExistenciaTableAdapter();
            this.t_ProductoTableAdapter = new GTrans.DSDatosTableAdapters.T_ProductoTableAdapter();
            this.t_ValeExistenciaTableAdapter = new GTrans.DSDatosTableAdapters.T_ValeExistenciaTableAdapter();
            this.t_TipoValeTableAdapter = new GTrans.DSDatosTableAdapters.T_TipoValeTableAdapter();
            this.tValeExistenciaMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_ValeExistenciaMonedaTableAdapter = new GTrans.DSDatosTableAdapters.T_ValeExistenciaMonedaTableAdapter();
            this.t_MonedaTableAdapter = new GTrans.DSDatosTableAdapters.T_MonedaTableAdapter();
            this.tableAdapterManager1 = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMonedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenExistenciaTValeExistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenExistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenlayout)).BeginInit();
            this.almacenlayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.namealmacenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornamealmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productolayout)).BeginInit();
            this.productolayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoValeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valeentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idalmacenSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidalmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvaleent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tValeExistenciaMonedaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 301);
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(433, 30);
            this.CodifcadorPieFormulario.StringCancelar = "Cancelar";
            this.CodifcadorPieFormulario.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            this.CodifcadorPieFormulario.Load += new System.EventHandler(this.CodifcadorPieFormulario_Load);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(377, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(433, 40);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprecio1,
            this.colidmoneda});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView3_ValidateRow);
            // 
            // colprecio1
            // 
            this.colprecio1.Caption = "Precio";
            this.colprecio1.FieldName = "precio";
            this.colprecio1.Name = "colprecio1";
            this.colprecio1.Visible = true;
            this.colprecio1.VisibleIndex = 0;
            // 
            // colidmoneda
            // 
            this.colidmoneda.Caption = "Moneda";
            this.colidmoneda.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidmoneda.FieldName = "idmoneda";
            this.colidmoneda.Name = "colidmoneda";
            this.colidmoneda.Visible = true;
            this.colidmoneda.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tMonedaBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "namemoneda";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idmoneda";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            this.repositoryItemGridLookUpEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemGridLookUpEdit2_ButtonClick);
            // 
            // tMonedaBindingSource
            // 
            this.tMonedaBindingSource.DataMember = "T_Moneda";
            this.tMonedaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemoneda});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemoneda
            // 
            this.colnamemoneda.Caption = "Moneda";
            this.colnamemoneda.FieldName = "namemoneda";
            this.colnamemoneda.Name = "colnamemoneda";
            this.colnamemoneda.Visible = true;
            this.colnamemoneda.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.tAlmacenExistenciaTValeExistenciaBindingSource;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode1.RelationName = "FK_T_ValeExistenciaMoneda_T_ValeExistencia";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 76);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(409, 173);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3});
            // 
            // tAlmacenExistenciaTValeExistenciaBindingSource
            // 
            this.tAlmacenExistenciaTValeExistenciaBindingSource.DataMember = "T_AlmacenExistencia_T_ValeExistencia";
            this.tAlmacenExistenciaTValeExistenciaBindingSource.DataSource = this.tAlmacenExistenciaBindingSource;
            // 
            // tAlmacenExistenciaBindingSource
            // 
            this.tAlmacenExistenciaBindingSource.DataMember = "T_AlmacenExistencia";
            this.tAlmacenExistenciaBindingSource.DataSource = this.dSDatos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidproducto,
            this.colexistencia});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView2.OptionsDetail.ShowDetailTabs = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView2_ValidateRow);
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            // 
            // colidproducto
            // 
            this.colidproducto.Caption = "Producto";
            this.colidproducto.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidproducto.FieldName = "idproducto";
            this.colidproducto.Name = "colidproducto";
            this.colidproducto.Visible = true;
            this.colidproducto.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tProductoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "codcomplete";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idproducto";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tProductoBindingSource
            // 
            this.tProductoBindingSource.DataMember = "T_Producto";
            this.tProductoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcodproducto,
            this.coldescproducto});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // colexistencia
            // 
            this.colexistencia.Caption = "Cantidad";
            this.colexistencia.FieldName = "existencia";
            this.colexistencia.Name = "colexistencia";
            this.colexistencia.Visible = true;
            this.colexistencia.VisibleIndex = 1;
            // 
            // almacenlayout
            // 
            this.almacenlayout.Controls.Add(this.namealmacenTextEdit);
            this.almacenlayout.DataSource = this.tAlmacenBindingSource;
            this.almacenlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.almacenlayout.Location = new System.Drawing.Point(0, 40);
            this.almacenlayout.Name = "almacenlayout";
            this.almacenlayout.Root = this.layoutControlGroup1;
            this.almacenlayout.Size = new System.Drawing.Size(433, 261);
            this.almacenlayout.TabIndex = 4;
            this.almacenlayout.Text = "dataLayoutControl1";
            // 
            // namealmacenTextEdit
            // 
            this.namealmacenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAlmacenBindingSource, "namealmacen", true));
            this.namealmacenTextEdit.Location = new System.Drawing.Point(59, 12);
            this.namealmacenTextEdit.Name = "namealmacenTextEdit";
            this.namealmacenTextEdit.Size = new System.Drawing.Size(362, 20);
            this.namealmacenTextEdit.StyleController = this.almacenlayout;
            this.namealmacenTextEdit.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.namealmacenTextEdit, conditionValidationRule1);
            // 
            // tAlmacenBindingSource
            // 
            this.tAlmacenBindingSource.DataMember = "T_Almacen";
            this.tAlmacenBindingSource.DataSource = this.dSDatos;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(433, 261);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemFornamealmacen});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(413, 241);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemFornamealmacen
            // 
            this.ItemFornamealmacen.Control = this.namealmacenTextEdit;
            this.ItemFornamealmacen.CustomizationFormText = "namealmacen";
            this.ItemFornamealmacen.Location = new System.Drawing.Point(0, 0);
            this.ItemFornamealmacen.Name = "ItemFornamealmacen";
            this.ItemFornamealmacen.Size = new System.Drawing.Size(413, 241);
            this.ItemFornamealmacen.Text = "Almacen:";
            this.ItemFornamealmacen.TextSize = new System.Drawing.Size(44, 13);
            // 
            // productolayout
            // 
            this.productolayout.Controls.Add(this.dateEdit1);
            this.productolayout.Controls.Add(this.gridLookUpEdit1);
            this.productolayout.Controls.Add(this.gridControl1);
            this.productolayout.Controls.Add(this.valeentTextEdit);
            this.productolayout.Controls.Add(this.idalmacenSpinEdit);
            this.productolayout.DataSource = this.tAlmacenExistenciaBindingSource;
            this.productolayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productolayout.Location = new System.Drawing.Point(0, 40);
            this.productolayout.Name = "productolayout";
            this.productolayout.Root = this.layoutControlGroup3;
            this.productolayout.Size = new System.Drawing.Size(433, 261);
            this.productolayout.TabIndex = 5;
            this.productolayout.Text = "dataLayoutControl2";
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAlmacenExistenciaBindingSource, "fecha", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(283, 36);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(138, 20);
            this.dateEdit1.StyleController = this.productolayout;
            this.dateEdit1.TabIndex = 11;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.dateEdit1, conditionValidationRule2);
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAlmacenExistenciaBindingSource, "idtipovale", true));
            this.gridLookUpEdit1.Location = new System.Drawing.Point(77, 36);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.tTipoValeBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nametipovale";
            this.gridLookUpEdit1.Properties.ValueMember = "idtipovale";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(137, 20);
            this.gridLookUpEdit1.StyleController = this.productolayout;
            this.gridLookUpEdit1.TabIndex = 10;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit1, conditionValidationRule3);
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
            // valeentTextEdit
            // 
            this.valeentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAlmacenExistenciaBindingSource, "vale", true));
            this.valeentTextEdit.Location = new System.Drawing.Point(283, 12);
            this.valeentTextEdit.Name = "valeentTextEdit";
            this.valeentTextEdit.Size = new System.Drawing.Size(138, 20);
            this.valeentTextEdit.StyleController = this.productolayout;
            this.valeentTextEdit.TabIndex = 8;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.valeentTextEdit, conditionValidationRule4);
            this.valeentTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.valeentTextEdit_Validating);
            // 
            // idalmacenSpinEdit
            // 
            this.idalmacenSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAlmacenExistenciaBindingSource, "idalmacen", true));
            this.idalmacenSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idalmacenSpinEdit.Location = new System.Drawing.Point(77, 12);
            this.idalmacenSpinEdit.Name = "idalmacenSpinEdit";
            this.idalmacenSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idalmacenSpinEdit.Properties.DataSource = this.tAlmacenBindingSource1;
            this.idalmacenSpinEdit.Properties.DisplayMember = "namealmacen";
            this.idalmacenSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.idalmacenSpinEdit.Properties.NullText = "";
            this.idalmacenSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idalmacenSpinEdit.Properties.ValueMember = "idalmacen";
            this.idalmacenSpinEdit.Properties.View = this.gridView1;
            this.idalmacenSpinEdit.Size = new System.Drawing.Size(137, 20);
            this.idalmacenSpinEdit.StyleController = this.productolayout;
            this.idalmacenSpinEdit.TabIndex = 6;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idalmacenSpinEdit, conditionValidationRule5);
            // 
            // tAlmacenBindingSource1
            // 
            this.tAlmacenBindingSource1.DataMember = "T_Almacen";
            this.tAlmacenBindingSource1.DataSource = this.dSDatos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamealmacen});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnamealmacen
            // 
            this.colnamealmacen.Caption = "Almacen";
            this.colnamealmacen.FieldName = "namealmacen";
            this.colnamealmacen.Name = "colnamealmacen";
            this.colnamealmacen.Visible = true;
            this.colnamealmacen.VisibleIndex = 0;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(433, 261);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AllowDrawBackground = false;
            this.layoutControlGroup4.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForidalmacen,
            this.layoutControlItem1,
            this.ItemForvaleent,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "autoGeneratedGroup0";
            this.layoutControlGroup4.Size = new System.Drawing.Size(413, 241);
            this.layoutControlGroup4.Text = "autoGeneratedGroup0";
            // 
            // ItemForidalmacen
            // 
            this.ItemForidalmacen.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForidalmacen.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForidalmacen.Control = this.idalmacenSpinEdit;
            this.ItemForidalmacen.CustomizationFormText = "idalmacen";
            this.ItemForidalmacen.Location = new System.Drawing.Point(0, 0);
            this.ItemForidalmacen.Name = "ItemForidalmacen";
            this.ItemForidalmacen.Size = new System.Drawing.Size(206, 24);
            this.ItemForidalmacen.Text = "Almacen:";
            this.ItemForidalmacen.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "Productos";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(413, 193);
            this.layoutControlItem1.Text = "Productos";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // ItemForvaleent
            // 
            this.ItemForvaleent.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForvaleent.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForvaleent.Control = this.valeentTextEdit;
            this.ItemForvaleent.CustomizationFormText = "valeent";
            this.ItemForvaleent.Location = new System.Drawing.Point(206, 0);
            this.ItemForvaleent.Name = "ItemForvaleent";
            this.ItemForvaleent.Size = new System.Drawing.Size(207, 24);
            this.ItemForvaleent.Text = "Vale:";
            this.ItemForvaleent.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.gridLookUpEdit1;
            this.layoutControlItem2.CustomizationFormText = "Tipo de Vale:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(206, 24);
            this.layoutControlItem2.Text = "Tipo de Vale:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.dateEdit1;
            this.layoutControlItem3.CustomizationFormText = "Fecha:";
            this.layoutControlItem3.Location = new System.Drawing.Point(206, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(207, 24);
            this.layoutControlItem3.Text = "Fecha:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidateHiddenControls = false;
            // 
            // t_AlmacenTableAdapter
            // 
            this.t_AlmacenTableAdapter.ClearBeforeFill = true;
            // 
            // t_AlmacenExistenciaTableAdapter
            // 
            this.t_AlmacenExistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // t_ProductoTableAdapter
            // 
            this.t_ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ValeExistenciaTableAdapter
            // 
            this.t_ValeExistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // t_TipoValeTableAdapter
            // 
            this.t_TipoValeTableAdapter.ClearBeforeFill = true;
            // 
            // tValeExistenciaMonedaBindingSource
            // 
            this.tValeExistenciaMonedaBindingSource.DataMember = "T_ValeExistenciaMoneda";
            this.tValeExistenciaMonedaBindingSource.DataSource = this.dSDatos;
            // 
            // t_ValeExistenciaMonedaTableAdapter
            // 
            this.t_ValeExistenciaMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // t_MonedaTableAdapter
            // 
            this.t_MonedaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager1.T_ValeExistenciaMonedaTableAdapter = this.t_ValeExistenciaMonedaTableAdapter;
            this.tableAdapterManager1.T_ValeExistenciaTableAdapter = this.t_ValeExistenciaTableAdapter;
            this.tableAdapterManager1.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmEditAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 331);
            this.Controls.Add(this.productolayout);
            this.Controls.Add(this.almacenlayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEditAlmacen";
            this.Text = "FrmEditAlmacen";
            this.Load += new System.EventHandler(this.FrmEditAlmacen_Load);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.almacenlayout, 0);
            this.Controls.SetChildIndex(this.productolayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMonedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenExistenciaTValeExistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenExistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenlayout)).EndInit();
            this.almacenlayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.namealmacenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornamealmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productolayout)).EndInit();
            this.productolayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoValeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valeentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idalmacenSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAlmacenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidalmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForvaleent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tValeExistenciaMonedaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl almacenlayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tAlmacenBindingSource;
        private DSDatosTableAdapters.T_AlmacenTableAdapter t_AlmacenTableAdapter;
        private DevExpress.XtraEditors.TextEdit namealmacenTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornamealmacen;
        private DevExpress.XtraDataLayout.DataLayoutControl productolayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private System.Windows.Forms.BindingSource tAlmacenExistenciaBindingSource;
        private DSDatosTableAdapters.T_AlmacenExistenciaTableAdapter t_AlmacenExistenciaTableAdapter;
        private DevExpress.XtraEditors.TextEdit valeentTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidalmacen;
        private DevExpress.XtraLayout.LayoutControlItem ItemForvaleent;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.BindingSource tProductoBindingSource;
        private DSDatosTableAdapters.T_ProductoTableAdapter t_ProductoTableAdapter;
        private DevExpress.XtraEditors.GridLookUpEdit idalmacenSpinEdit;
        private System.Windows.Forms.BindingSource tAlmacenBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamealmacen;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource tAlmacenExistenciaTValeExistenciaBindingSource;
        private DSDatosTableAdapters.T_ValeExistenciaTableAdapter t_ValeExistenciaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidproducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcodproducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldescproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colexistencia;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource tTipoValeBindingSource;
        private DSDatosTableAdapters.T_TipoValeTableAdapter t_TipoValeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipovale;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio1;
        private DevExpress.XtraGrid.Columns.GridColumn colidmoneda;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource tValeExistenciaMonedaBindingSource;
        private DSDatosTableAdapters.T_ValeExistenciaMonedaTableAdapter t_ValeExistenciaMonedaTableAdapter;
        private System.Windows.Forms.BindingSource tMonedaBindingSource;
        private DSDatosTableAdapters.T_MonedaTableAdapter t_MonedaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemoneda;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}