namespace GTrans.Tareas
{
    partial class FrmDeletedWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeletedWorker));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fGetPossibleWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidempleadoposs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tOrdenTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnoorden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.f_GetPossibleWorkersTableAdapter = new GTrans.DSDatosTableAdapters.F_GetPossibleWorkersTableAdapter();
            this.t_EmpleadoTableAdapter = new GTrans.DSDatosTableAdapters.T_EmpleadoTableAdapter();
            this.t_OrdenTrabajoTableAdapter = new GTrans.DSDatosTableAdapters.T_OrdenTrabajoTableAdapter();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGetPossibleWorkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOrdenTrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 427);
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(574, 30);
            this.CodifcadorPieFormulario.StringCancelar = "Cancelar";
            this.CodifcadorPieFormulario.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.CodifcadorPieFormulario_Aceptar);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(518, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(574, 40);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.fGetPossibleWorkersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(574, 387);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // fGetPossibleWorkersBindingSource
            // 
            this.fGetPossibleWorkersBindingSource.DataMember = "F_GetPossibleWorkers";
            this.fGetPossibleWorkersBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidempleado,
            this.colidempleadoposs,
            this.colcant,
            this.colidorden,
            this.colchecked});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEdit);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colidempleado
            // 
            this.colidempleado.Caption = "Empleado(Borrado)";
            this.colidempleado.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidempleado.FieldName = "idempleado";
            this.colidempleado.Name = "colidempleado";
            this.colidempleado.Visible = true;
            this.colidempleado.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tEmpleadoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "nameempleado";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idempleado";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tEmpleadoBindingSource
            // 
            this.tEmpleadoBindingSource.DataMember = "T_Empleado";
            this.tEmpleadoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameempleado,
            this.colcodempleado});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameempleado
            // 
            this.colnameempleado.Caption = "Nombre";
            this.colnameempleado.FieldName = "nameempleado";
            this.colnameempleado.Name = "colnameempleado";
            this.colnameempleado.Visible = true;
            this.colnameempleado.VisibleIndex = 1;
            // 
            // colcodempleado
            // 
            this.colcodempleado.Caption = "Código";
            this.colcodempleado.FieldName = "codempleado";
            this.colcodempleado.Name = "colcodempleado";
            this.colcodempleado.Visible = true;
            this.colcodempleado.VisibleIndex = 0;
            // 
            // colidempleadoposs
            // 
            this.colidempleadoposs.Caption = "Empleado(Sustituto)";
            this.colidempleadoposs.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidempleadoposs.FieldName = "idempleadoposs";
            this.colidempleadoposs.Name = "colidempleadoposs";
            this.colidempleadoposs.Visible = true;
            this.colidempleadoposs.VisibleIndex = 1;
            // 
            // colcant
            // 
            this.colcant.Caption = "Cantidad de Horas Trabajando (Plan)";
            this.colcant.FieldName = "cant";
            this.colcant.Name = "colcant";
            this.colcant.Visible = true;
            this.colcant.VisibleIndex = 2;
            // 
            // colidorden
            // 
            this.colidorden.Caption = "Orden Afectada";
            this.colidorden.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colidorden.FieldName = "idorden";
            this.colidorden.Name = "colidorden";
            this.colidorden.Visible = true;
            this.colidorden.VisibleIndex = 3;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.tOrdenTrabajoBindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "noorden";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.ValueMember = "idordentrabajo";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // tOrdenTrabajoBindingSource
            // 
            this.tOrdenTrabajoBindingSource.DataMember = "T_OrdenTrabajo";
            this.tOrdenTrabajoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnoorden});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colnoorden
            // 
            this.colnoorden.Caption = "No Orden";
            this.colnoorden.FieldName = "noorden";
            this.colnoorden.Name = "colnoorden";
            this.colnoorden.Visible = true;
            this.colnoorden.VisibleIndex = 0;
            // 
            // colchecked
            // 
            this.colchecked.Caption = "Sustituir";
            this.colchecked.FieldName = "checked";
            this.colchecked.Name = "colchecked";
            this.colchecked.Visible = true;
            this.colchecked.VisibleIndex = 4;
            // 
            // f_GetPossibleWorkersTableAdapter
            // 
            this.f_GetPossibleWorkersTableAdapter.ClearBeforeFill = false;
            // 
            // t_EmpleadoTableAdapter
            // 
            this.t_EmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_OrdenTrabajoTableAdapter
            // 
            this.t_OrdenTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("convert_32x32.png", "images/actions/convert_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/convert_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "convert_32x32.png");
            // 
            // FrmDeletedWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 457);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmDeletedWorker";
            this.Text = "FrmDeletedWorker";
            this.Load += new System.EventHandler(this.FrmDeletedWorker_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fGetPossibleWorkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOrdenTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource fGetPossibleWorkersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colidempleadoposs;
        private DevExpress.XtraGrid.Columns.GridColumn colcant;
        private DevExpress.XtraGrid.Columns.GridColumn colidorden;
        private DevExpress.XtraGrid.Columns.GridColumn colchecked;
        private DSDatosTableAdapters.F_GetPossibleWorkersTableAdapter f_GetPossibleWorkersTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Windows.Forms.BindingSource tEmpleadoBindingSource;
        private DSDatosTableAdapters.T_EmpleadoTableAdapter t_EmpleadoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodempleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private System.Windows.Forms.BindingSource tOrdenTrabajoBindingSource;
        private DSDatosTableAdapters.T_OrdenTrabajoTableAdapter t_OrdenTrabajoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnoorden;
        private DevExpress.Utils.ImageCollection imageCollection1;
        public DSDatos dSDatos;
    }
}