namespace GTrans.Codificadores
{
    partial class FrmFormaPago
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
            this.dSDatos = new DSDatos();
            this.t_FormaPagoBindingSource = new System.Windows.Forms.BindingSource();
            this.t_FormaPagoTableAdapter = new DSDatosTableAdapters.T_FormaPagoTableAdapter();
            this.tableAdapterManager = new DSDatosTableAdapters.TableAdapterManager();
            this.t_FormaPagoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameformapago = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormaPagoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 383);
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(380, 30);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(324, 36);
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_FormaPagoBindingSource
            // 
            this.t_FormaPagoBindingSource.DataMember = "T_FormaPago";
            this.t_FormaPagoBindingSource.DataSource = this.dSDatos;
            // 
            // t_FormaPagoTableAdapter
            // 
            this.t_FormaPagoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
       
            this.tableAdapterManager.T_CategoriaTableAdapter = null;
            this.tableAdapterManager.T_ClasificacionTableAdapter = null;
         
            this.tableAdapterManager.T_Empleado_FormaTableAdapter = null;
            this.tableAdapterManager.T_EmpleadoTableAdapter = null;
            this.tableAdapterManager.T_EquipoTableAdapter = null;

            this.tableAdapterManager.T_EstadoOrdenTableAdapter = null;
            this.tableAdapterManager.T_EstadoTableAdapter = null;

            this.tableAdapterManager.T_FormaPagoTableAdapter = this.t_FormaPagoTableAdapter;
          
            this.tableAdapterManager.T_MarcaTableAdapter = null;

            this.tableAdapterManager.T_ModeloTableAdapter = null;
            this.tableAdapterManager.T_MonedaTableAdapter = null;

            this.tableAdapterManager.T_OrdenSalarioTableAdapter = null;
            this.tableAdapterManager.T_OrdenSurtidoTableAdapter = null;
            this.tableAdapterManager.T_OrdenTrabajoTableAdapter = null;
            this.tableAdapterManager.T_PaisTableAdapter = null;
            this.tableAdapterManager.T_PlanificacionTableAdapter = null;
   
            this.tableAdapterManager.T_ProductoTableAdapter = null;
      
            this.tableAdapterManager.T_TipoTrabajoTableAdapter = null;
            this.tableAdapterManager.T_UMTableAdapter = null;
   
            this.tableAdapterManager.UpdateOrder = DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_FormaPagoGridControl
            // 
            this.t_FormaPagoGridControl.DataSource = this.t_FormaPagoBindingSource;
            this.t_FormaPagoGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_FormaPagoGridControl.Location = new System.Drawing.Point(0, 40);
            this.t_FormaPagoGridControl.MainView = this.gridView1;
            this.t_FormaPagoGridControl.Name = "t_FormaPagoGridControl";
            this.t_FormaPagoGridControl.Size = new System.Drawing.Size(380, 343);
            this.t_FormaPagoGridControl.TabIndex = 1;
            this.t_FormaPagoGridControl.UseEmbeddedNavigator = true;
            this.t_FormaPagoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameformapago});
            this.gridView1.GridControl = this.t_FormaPagoGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnameformapago
            // 
            this.colnameformapago.Caption = "Forma de Pago";
            this.colnameformapago.FieldName = "nameformapago";
            this.colnameformapago.Name = "colnameformapago";
            this.colnameformapago.Visible = true;
            this.colnameformapago.VisibleIndex = 0;
            // 
            // FrmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 413);
            this.Controls.Add(this.t_FormaPagoGridControl);
            this.Name = "FrmFormaPago";
            this.Text = "Formas de Pago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFormaPago_FormClosed);
            this.Load += new System.EventHandler(this.FrmFormaPago_Load);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.t_FormaPagoGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_FormaPagoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_FormaPagoBindingSource;
        private DSDatosTableAdapters.T_FormaPagoTableAdapter t_FormaPagoTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_FormaPagoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameformapago;
  }
}