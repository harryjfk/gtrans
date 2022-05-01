namespace GTrans.Codificadores
{
    partial class FrmNivelEscolaridad
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
            this.dSDatos = new DSDatos();
            this.t_NivelEscolaridadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_NivelEscolaridadTableAdapter = new DSDatosTableAdapters.T_NivelEscolaridadTableAdapter();
            this.tableAdapterManager = new DSDatosTableAdapters.TableAdapterManager();
            this.t_NivelEscolaridadGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnamenivelescolaridad = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_NivelEscolaridadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_NivelEscolaridadGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 348);
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(400, 30);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(344, 36);
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_NivelEscolaridadBindingSource
            // 
            this.t_NivelEscolaridadBindingSource.DataMember = "T_NivelEscolaridad";
            this.t_NivelEscolaridadBindingSource.DataSource = this.dSDatos;
            // 
            // t_NivelEscolaridadTableAdapter
            // 
            this.t_NivelEscolaridadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         
            this.tableAdapterManager.T_NivelEscolaridadTableAdapter = this.t_NivelEscolaridadTableAdapter;
         
            this.tableAdapterManager.UpdateOrder = DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_NivelEscolaridadGridControl
            // 
            this.t_NivelEscolaridadGridControl.DataSource = this.t_NivelEscolaridadBindingSource;
            this.t_NivelEscolaridadGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_NivelEscolaridadGridControl.Location = new System.Drawing.Point(0, 40);
            this.t_NivelEscolaridadGridControl.MainView = this.gridView1;
            this.t_NivelEscolaridadGridControl.Name = "t_NivelEscolaridadGridControl";
            this.t_NivelEscolaridadGridControl.Size = new System.Drawing.Size(400, 308);
            this.t_NivelEscolaridadGridControl.TabIndex = 1;
            this.t_NivelEscolaridadGridControl.UseEmbeddedNavigator = true;
            this.t_NivelEscolaridadGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnamenivelescolaridad});
            this.gridView1.GridControl = this.t_NivelEscolaridadGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colnamenivelescolaridad
            // 
            this.colnamenivelescolaridad.Caption = "Nivel Escolar";
            this.colnamenivelescolaridad.FieldName = "namenivelescolaridad";
            this.colnamenivelescolaridad.Name = "colnamenivelescolaridad";
            this.colnamenivelescolaridad.Visible = true;
            this.colnamenivelescolaridad.VisibleIndex = 0;
            // 
            // FrmNivelEscolaridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 378);
            this.Controls.Add(this.t_NivelEscolaridadGridControl);
            this.Name = "FrmNivelEscolaridad";
            this.Text = "Niveles de escolaridad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNivelEscolaridad_FormClosed);
            this.Load += new System.EventHandler(this.FrmNivelEscolaridad_Load);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.t_NivelEscolaridadGridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_NivelEscolaridadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_NivelEscolaridadGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource t_NivelEscolaridadBindingSource;
        private DSDatosTableAdapters.T_NivelEscolaridadTableAdapter t_NivelEscolaridadTableAdapter;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl t_NivelEscolaridadGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnamenivelescolaridad;
    }
}