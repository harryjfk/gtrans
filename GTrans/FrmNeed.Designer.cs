namespace GTrans
{
    partial class FrmNeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNeed));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pGetResourcesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporte = new GTrans.Reportes.DSReporte();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameproducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantdisp1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantneed1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.pGetResourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReporte1 = new GTrans.Reportes.DSReporte();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameproducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantdisp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantneed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.p_GetResourcesTableAdapter = new GTrans.Reportes.DSReporteTableAdapters.P_GetResourcesTableAdapter();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGetResourcesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGetResourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 446);
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(620, 30);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(564, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(620, 40);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 40);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(620, 406);
            this.splitContainerControl1.SplitterPosition = 306;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.pGetResourcesBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(306, 406);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pGetResourcesBindingSource1
            // 
            this.pGetResourcesBindingSource1.DataMember = "P_GetResources";
            this.pGetResourcesBindingSource1.DataSource = this.dSReporte;
            // 
            // dSReporte
            // 
            this.dSReporte.DataSetName = "DSReporte";
            this.dSReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameproducto1,
            this.colcantdisp1,
            this.colcantneed1,
            this.colfecha1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colnameproducto1
            // 
            this.colnameproducto1.Caption = "Producto";
            this.colnameproducto1.FieldName = "nameproducto";
            this.colnameproducto1.Name = "colnameproducto1";
            this.colnameproducto1.OptionsColumn.ReadOnly = true;
            this.colnameproducto1.Visible = true;
            this.colnameproducto1.VisibleIndex = 0;
            // 
            // colcantdisp1
            // 
            this.colcantdisp1.Caption = "Cantidad Disponible";
            this.colcantdisp1.FieldName = "cantdisp";
            this.colcantdisp1.Name = "colcantdisp1";
            this.colcantdisp1.OptionsColumn.ReadOnly = true;
            this.colcantdisp1.Visible = true;
            this.colcantdisp1.VisibleIndex = 1;
            // 
            // colcantneed1
            // 
            this.colcantneed1.Caption = "Cant Necesitada";
            this.colcantneed1.FieldName = "cantneed";
            this.colcantneed1.Name = "colcantneed1";
            this.colcantneed1.OptionsColumn.ReadOnly = true;
            this.colcantneed1.Visible = true;
            this.colcantneed1.VisibleIndex = 2;
            // 
            // colfecha1
            // 
            this.colfecha1.Caption = "Fecha";
            this.colfecha1.FieldName = "fecha";
            this.colfecha1.Name = "colfecha1";
            this.colfecha1.OptionsColumn.ReadOnly = true;
            this.colfecha1.Visible = true;
            this.colfecha1.VisibleIndex = 3;
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.pGetResourcesBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(309, 406);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // pGetResourcesBindingSource
            // 
            this.pGetResourcesBindingSource.DataMember = "P_GetResources";
            this.pGetResourcesBindingSource.DataSource = this.dsReporte1;
            // 
            // dsReporte1
            // 
            this.dsReporte1.DataSetName = "DSReporte";
            this.dsReporte1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameproducto,
            this.colcantdisp,
            this.colcantneed,
            this.colfecha});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colnameproducto
            // 
            this.colnameproducto.Caption = "Producto";
            this.colnameproducto.FieldName = "nameproducto";
            this.colnameproducto.Name = "colnameproducto";
            this.colnameproducto.OptionsColumn.ReadOnly = true;
            this.colnameproducto.Visible = true;
            this.colnameproducto.VisibleIndex = 0;
            // 
            // colcantdisp
            // 
            this.colcantdisp.Caption = "Cantidad Disponible";
            this.colcantdisp.FieldName = "cantdisp";
            this.colcantdisp.Name = "colcantdisp";
            this.colcantdisp.OptionsColumn.ReadOnly = true;
            this.colcantdisp.Visible = true;
            this.colcantdisp.VisibleIndex = 1;
            // 
            // colcantneed
            // 
            this.colcantneed.Caption = "Cant Necesitada";
            this.colcantneed.FieldName = "cantneed";
            this.colcantneed.Name = "colcantneed";
            this.colcantneed.OptionsColumn.ReadOnly = true;
            this.colcantneed.Visible = true;
            this.colcantneed.VisibleIndex = 2;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.OptionsColumn.ReadOnly = true;
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            // 
            // p_GetResourcesTableAdapter
            // 
            this.p_GetResourcesTableAdapter.ClearBeforeFill = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // FrmNeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 476);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmNeed";
            this.Text = "FrmNeed";
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGetResourcesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGetResourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReporte1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource pGetResourcesBindingSource1;
        private Reportes.DSReporte dSReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnameproducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantdisp1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantneed1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource pGetResourcesBindingSource;
        private Reportes.DSReporte dsReporte1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnameproducto;
        private DevExpress.XtraGrid.Columns.GridColumn colcantdisp;
        private DevExpress.XtraGrid.Columns.GridColumn colcantneed;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private Reportes.DSReporteTableAdapters.P_GetResourcesTableAdapter p_GetResourcesTableAdapter;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}