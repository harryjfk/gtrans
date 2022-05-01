namespace GTrans.Codificadores
{
    partial class FrmMarca
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidtipomarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tTipoMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_tipo_marca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre_tipo_marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemarca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamemodelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidmarca1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.t_MarcaTableAdapter = new GTrans.DSDatosTableAdapters.T_MarcaTableAdapter();
            this.t_Tipo_MarcaTableAdapter = new GTrans.DSDatosTableAdapters.T_Tipo_MarcaTableAdapter();
            this.t_ModeloTableAdapter1 = new GTrans.DSDatosTableAdapters.T_ModeloTableAdapter();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemarca,
            this.colidtipomarca});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView3.OptionsDetail.ShowDetailTabs = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridView1_RowDeleted);
            this.gridView3.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView3_RowUpdated);
            // 
            // colnamemarca
            // 
            this.colnamemarca.Caption = "Marca";
            this.colnamemarca.FieldName = "namemarca";
            this.colnamemarca.Name = "colnamemarca";
            this.colnamemarca.Visible = true;
            this.colnamemarca.VisibleIndex = 0;
            // 
            // colidtipomarca
            // 
            this.colidtipomarca.Caption = "Tipo de Marca";
            this.colidtipomarca.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidtipomarca.FieldName = "idtipomarca";
            this.colidtipomarca.Name = "colidtipomarca";
            this.colidtipomarca.Visible = true;
            this.colidtipomarca.VisibleIndex = 1;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tTipoMarcaBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nombre_tipo_marca";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "id_tipo_marca";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tTipoMarcaBindingSource
            // 
            this.tTipoMarcaBindingSource.DataMember = "T_Tipo_Marca";
            this.tTipoMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_tipo_marca1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnombre_tipo_marca1
            // 
            this.colnombre_tipo_marca1.Caption = "Tipo de Marca";
            this.colnombre_tipo_marca1.FieldName = "nombre_tipo_marca";
            this.colnombre_tipo_marca1.Name = "colnombre_tipo_marca1";
            this.colnombre_tipo_marca1.Visible = true;
            this.colnombre_tipo_marca1.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.tTipoMarcaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView3;
            gridLevelNode2.LevelTemplate = this.gridView2;
            gridLevelNode2.RelationName = "FK_T_Modelo_T_Marca";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "FK_T_Marca_T_Tipo_Marca";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(430, 300);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2,
            this.gridView3});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre_tipo_marca});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridView1_RowDeleted);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnombre_tipo_marca
            // 
            this.colnombre_tipo_marca.Caption = "Tipo de Marca";
            this.colnombre_tipo_marca.FieldName = "nombre_tipo_marca";
            this.colnombre_tipo_marca.Name = "colnombre_tipo_marca";
            this.colnombre_tipo_marca.Visible = true;
            this.colnombre_tipo_marca.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tMarcaBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "namemarca";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idmarca";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tMarcaBindingSource
            // 
            this.tMarcaBindingSource.DataMember = "T_Marca";
            this.tMarcaBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemarca1});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnamemarca1
            // 
            this.colnamemarca1.Caption = "Marca";
            this.colnamemarca1.FieldName = "namemarca";
            this.colnamemarca1.Name = "colnamemarca1";
            this.colnamemarca1.Visible = true;
            this.colnamemarca1.VisibleIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamemodelo,
            this.colidmarca1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gridView1_RowDeleted);
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colnamemodelo
            // 
            this.colnamemodelo.Caption = "Modelo";
            this.colnamemodelo.FieldName = "namemodelo";
            this.colnamemodelo.Name = "colnamemodelo";
            this.colnamemodelo.Visible = true;
            this.colnamemodelo.VisibleIndex = 0;
            // 
            // colidmarca1
            // 
            this.colidmarca1.Caption = "Marca";
            this.colidmarca1.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidmarca1.FieldName = "idmarca";
            this.colidmarca1.Name = "colidmarca1";
            this.colidmarca1.Visible = true;
            this.colidmarca1.VisibleIndex = 1;
            // 
            // t_MarcaTableAdapter
            // 
            this.t_MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // t_Tipo_MarcaTableAdapter
            // 
            this.t_Tipo_MarcaTableAdapter.ClearBeforeFill = true;
            // 
            // t_ModeloTableAdapter1
            // 
            this.t_ModeloTableAdapter1.ClearBeforeFill = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMarca_FormClosed);
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.Shown += new System.EventHandler(this.FrmMarca_Shown);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tMarcaBindingSource;
        private DSDatosTableAdapters.T_MarcaTableAdapter t_MarcaTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemodelo;
        private DevExpress.XtraGrid.Columns.GridColumn colidmarca1;
        private System.Windows.Forms.BindingSource tTipoMarcaBindingSource;
        private DSDatosTableAdapters.T_Tipo_MarcaTableAdapter t_Tipo_MarcaTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca;
        private DevExpress.XtraGrid.Columns.GridColumn colidtipomarca;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_tipo_marca1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colnamemarca1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_tipo_marca;
        private DSDatosTableAdapters.T_ModeloTableAdapter t_ModeloTableAdapter1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}