namespace GTrans.Codificadores
{
    partial class FrmGrupoAcciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrupoAcciones));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tGrupoAccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.t_GrupoAccionTableAdapter = new GTrans.DSDatosTableAdapters.T_GrupoAccionTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colcodigogrupoaccion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colnamegrupoaccion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGrupoAccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // tGrupoAccionBindingSource
            // 
            this.tGrupoAccionBindingSource.DataMember = "T_GrupoAccion";
            this.tGrupoAccionBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_GrupoAccionTableAdapter
            // 
            this.t_GrupoAccionTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colcodigogrupoaccion,
            this.colnamegrupoaccion});
            this.treeList1.DataSource = this.tGrupoAccionBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "idgrupoacciones";
            this.treeList1.Location = new System.Drawing.Point(0, 40);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "idparent";
            this.treeList1.Size = new System.Drawing.Size(430, 281);
            this.treeList1.TabIndex = 3;
            this.treeList1.ValidateNode += new DevExpress.XtraTreeList.ValidateNodeEventHandler(this.treeList1_ValidateNode);
            this.treeList1.Validating += new System.ComponentModel.CancelEventHandler(this.treeList1_Validating);
            // 
            // colcodigogrupoaccion
            // 
            this.colcodigogrupoaccion.Caption = "Código";
            this.colcodigogrupoaccion.FieldName = "codigogrupoaccion";
            this.colcodigogrupoaccion.Name = "colcodigogrupoaccion";
            this.colcodigogrupoaccion.Visible = true;
            this.colcodigogrupoaccion.VisibleIndex = 0;
            this.colcodigogrupoaccion.Width = 127;
            // 
            // colnamegrupoaccion
            // 
            this.colnamegrupoaccion.Caption = "Nombre";
            this.colnamegrupoaccion.FieldName = "namegrupoaccion";
            this.colnamegrupoaccion.Name = "colnamegrupoaccion";
            this.colnamegrupoaccion.Visible = true;
            this.colnamegrupoaccion.VisibleIndex = 1;
            this.colnamegrupoaccion.Width = 128;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 321);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.treeList1;
            this.controlNavigator1.Size = new System.Drawing.Size(430, 19);
            this.controlNavigator1.TabIndex = 4;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.End;
            this.controlNavigator1.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.controlNavigator1_ButtonClick);
            // 
            // FrmGrupoAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 370);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.controlNavigator1);
            this.Name = "FrmGrupoAcciones";
            this.Text = "FrmGrupoAcciones";
            this.Load += new System.EventHandler(this.FrmGrupoAcciones_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.controlNavigator1, 0);
            this.Controls.SetChildIndex(this.treeList1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGrupoAccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tGrupoAccionBindingSource;
        private DSDatosTableAdapters.T_GrupoAccionTableAdapter t_GrupoAccionTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcodigogrupoaccion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnamegrupoaccion;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
    }
}