namespace GTrans.Codificadores
{
    partial class FrmTipoTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoTrabajo));
            this.dSDatos = new GTrans.DSDatos();
            this.t_TipoTrabajoGridControl = new DevExpress.XtraGrid.GridControl();
            this.t_TipoTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipotrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.t_TipoTrabajoTableAdapter = new GTrans.DSDatosTableAdapters.T_TipoTrabajoTableAdapter();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoBindingSource)).BeginInit();
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
            this.t_TipoTrabajoGridControl.DataSource = this.t_TipoTrabajoBindingSource;
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
            // t_TipoTrabajoBindingSource
            // 
            this.t_TipoTrabajoBindingSource.DataMember = "T_TipoTrabajo";
            this.t_TipoTrabajoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnametipotrabajo});
            this.gridView2.GridControl = this.t_TipoTrabajoGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.EnableMasterViewMode = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView2.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView2_RowUpdated);
            // 
            // colnametipotrabajo
            // 
            this.colnametipotrabajo.Caption = "Tipo de trabajo";
            this.colnametipotrabajo.FieldName = "nametipotrabajo";
            this.colnametipotrabajo.Name = "colnametipotrabajo";
            this.colnametipotrabajo.Visible = true;
            this.colnametipotrabajo.VisibleIndex = 0;
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
            this.tableAdapterManager.T_MarcaTableAdapter = null;
            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MonedaTableAdapter = null;
            this.tableAdapterManager.T_NivelEscolaridadTableAdapter = null;
            this.tableAdapterManager.T_OrdenSalarioTableAdapter = null;
            this.tableAdapterManager.T_OrdenSurtidoTableAdapter = null;
            this.tableAdapterManager.T_OrdenTrabajoTableAdapter = null;
            this.tableAdapterManager.T_PaisTableAdapter = null;
            this.tableAdapterManager.T_ParalizadoTableAdapter = null;
            this.tableAdapterManager.T_PlanificacionTableAdapter = null;
            this.tableAdapterManager.T_ProductoTableAdapter = null;
            this.tableAdapterManager.T_Tipo_EquipoTableAdapter = null;
            this.tableAdapterManager.T_Tipo_MarcaTableAdapter = null;
            this.tableAdapterManager.T_Tipo_MatriculaTableAdapter = null;
            this.tableAdapterManager.T_Tipo_ParalizadoTableAdapter = null;
            this.tableAdapterManager.T_TipoCombustibleTableAdapter = null;
            this.tableAdapterManager.T_TipoMantenimientoTableAdapter = null;
            this.tableAdapterManager.T_TipoModeloAccionTableAdapter = null;
            this.tableAdapterManager.T_TipoModeloMantTableAdapter = null;
            this.tableAdapterManager.T_TipoTrabajoTableAdapter = null;
            this.tableAdapterManager.T_UEBTableAdapter = null;
            this.tableAdapterManager.T_UMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_TipoTrabajoTableAdapter
            // 
            this.t_TipoTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // FrmTipoOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 362);
            this.Controls.Add(this.t_TipoTrabajoGridControl);
            this.Name = "FrmTipoOrden";
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
            ((System.ComponentModel.ISupportInitialize)(this.t_TipoTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource t_TipoTrabajoBindingSource;
        private DSDatosTableAdapters.T_TipoTrabajoTableAdapter t_TipoTrabajoTableAdapter;
        private DevExpress.XtraGrid.GridControl t_TipoTrabajoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipotrabajo;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}