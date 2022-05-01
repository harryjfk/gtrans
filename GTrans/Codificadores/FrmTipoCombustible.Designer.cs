namespace GTrans.Codificadores
{
    partial class FrmTipoCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoCombustible));
            this.dSDatos = new GTrans.DSDatos();
            this.t_TipoTrabajoGridControl = new DevExpress.XtraGrid.GridControl();
            this.tTipoCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipocombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.t_TipoCombustibleTableAdapter = new GTrans.DSDatosTableAdapters.T_TipoCombustibleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoCombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
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
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_TipoTrabajoGridControl
            // 
            this.t_TipoTrabajoGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_TipoTrabajoGridControl.DataSource = this.tTipoCombustibleBindingSource;
            this.t_TipoTrabajoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_TipoTrabajoGridControl.Location = new System.Drawing.Point(0, 40);
            this.t_TipoTrabajoGridControl.MainView = this.gridView2;
            this.t_TipoTrabajoGridControl.Name = "t_TipoTrabajoGridControl";
            this.t_TipoTrabajoGridControl.Size = new System.Drawing.Size(419, 292);
            this.t_TipoTrabajoGridControl.TabIndex = 0;
            this.t_TipoTrabajoGridControl.UseEmbeddedNavigator = true;
            this.t_TipoTrabajoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // tTipoCombustibleBindingSource
            // 
            this.tTipoCombustibleBindingSource.DataMember = "T_TipoCombustible";
            this.tTipoCombustibleBindingSource.DataSource = this.dSDatos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipocombustible,
            this.colprecio});
            this.gridView2.GridControl = this.t_TipoTrabajoGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView2_ValidateRow);
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colnametipocombustible
            // 
            this.colnametipocombustible.Caption = "Tipo de Combustible";
            this.colnametipocombustible.FieldName = "nametipocombustible";
            this.colnametipocombustible.Name = "colnametipocombustible";
            this.colnametipocombustible.Visible = true;
            this.colnametipocombustible.VisibleIndex = 0;
            // 
            // colprecio
            // 
            this.colprecio.Caption = "Precio";
            this.colprecio.FieldName = "precio";
            this.colprecio.Name = "colprecio";
            this.colprecio.Visible = true;
            this.colprecio.VisibleIndex = 1;
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
            // t_TipoCombustibleTableAdapter
            // 
            this.t_TipoCombustibleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTipoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 362);
            this.Controls.Add(this.t_TipoTrabajoGridControl);
            this.Name = "FrmTipoCombustible";
            this.Text = "FrmTipoOrden";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTipoOrden_FormClosed);
            this.Load += new System.EventHandler(this.FrmTipoOrden_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.t_TipoTrabajoGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoCombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_TipoTrabajoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.BindingSource tTipoCombustibleBindingSource;
        private DSDatosTableAdapters.T_TipoCombustibleTableAdapter t_TipoCombustibleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipocombustible;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
    }
}