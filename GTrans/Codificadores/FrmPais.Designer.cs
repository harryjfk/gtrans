namespace GTrans.Codificadores
{
    partial class FrmPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPais));
            this.dSDatos = new GTrans.DSDatos();
            this.t_PaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_PaisTableAdapter = new GTrans.DSDatosTableAdapters.T_PaisTableAdapter();
            this.tableAdapterManager = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.t_PaisGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamepais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimgpais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PaisGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 356);
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(463, 30);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(407, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(463, 40);
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_PaisBindingSource
            // 
            this.t_PaisBindingSource.DataMember = "T_Pais";
            this.t_PaisBindingSource.DataSource = this.dSDatos;
            // 
            // t_PaisTableAdapter
            // 
            this.t_PaisTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_OrdenTrabajoTableAdapter = null;
            this.tableAdapterManager.T_PaisTableAdapter = this.t_PaisTableAdapter;
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
            // t_PaisGridControl
            // 
            this.t_PaisGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_PaisGridControl.DataSource = this.t_PaisBindingSource;
            this.t_PaisGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_PaisGridControl.Location = new System.Drawing.Point(0, 40);
            this.t_PaisGridControl.MainView = this.gridView1;
            this.t_PaisGridControl.Name = "t_PaisGridControl";
            this.t_PaisGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.t_PaisGridControl.Size = new System.Drawing.Size(463, 316);
            this.t_PaisGridControl.TabIndex = 3;
            this.t_PaisGridControl.UseEmbeddedNavigator = true;
            this.t_PaisGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamepais,
            this.colimgpais});
            this.gridView1.GridControl = this.t_PaisGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 32;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnamepais
            // 
            this.colnamepais.Caption = "Nombre";
            this.colnamepais.FieldName = "nombre_pais";
            this.colnamepais.Name = "colnamepais";
            this.colnamepais.Visible = true;
            this.colnamepais.VisibleIndex = 1;
            this.colnamepais.Width = 379;
            // 
            // colimgpais
            // 
            this.colimgpais.Caption = "Bandera";
            this.colimgpais.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colimgpais.FieldName = "imgpais";
            this.colimgpais.Name = "colimgpais";
            this.colimgpais.Visible = true;
            this.colimgpais.VisibleIndex = 0;
            this.colimgpais.Width = 66;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 386);
            this.Controls.Add(this.t_PaisGridControl);
            this.Name = "FrmPais";
            this.Text = "Paises";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPais_FormClosed);
            this.Load += new System.EventHandler(this.FrmPais_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.t_PaisGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_PaisGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_PaisBindingSource;
        private DSDatosTableAdapters.T_PaisTableAdapter t_PaisTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_PaisGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamepais;
        private DevExpress.XtraGrid.Columns.GridColumn colimgpais;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.Utils.ImageCollection imageCollection1;

    }
}