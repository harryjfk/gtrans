namespace GTrans.Codificadores
{
    partial class FrmNewAccion
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewAccion));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.treeListLookUpEdit1 = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tGrupoAccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_GrupoAccionTableAdapter = new GTrans.DSDatosTableAdapters.T_GrupoAccionTableAdapter();
            this.colnamegrupoaccion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcodigogrupoaccion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.colnamegrupoaccion1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcodigogrupoaccion1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGrupoAccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodifcadorPieFormulario
            // 
            this.CodifcadorPieFormulario.Location = new System.Drawing.Point(0, 109);
            this.CodifcadorPieFormulario.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.CodifcadorPieFormulario.Size = new System.Drawing.Size(379, 30);
            this.CodifcadorPieFormulario.StringCancelar = "Cancelar";
            this.CodifcadorPieFormulario.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.CodifcadorPieFormulario_Aceptar);
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(323, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(379, 40);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.treeListLookUpEdit1);
            this.layoutControl1.Controls.Add(this.checkEdit2);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 40);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(379, 69);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // treeListLookUpEdit1
            // 
            this.treeListLookUpEdit1.Location = new System.Drawing.Point(191, 35);
            this.treeListLookUpEdit1.Name = "treeListLookUpEdit1";
            this.treeListLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEdit1.Properties.DataSource = this.tGrupoAccionBindingSource;
            this.treeListLookUpEdit1.Properties.DisplayMember = "codigogrupoaccion";
            this.treeListLookUpEdit1.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.treeListLookUpEdit1.Properties.ValueMember = "idgrupoacciones";
            this.treeListLookUpEdit1.Size = new System.Drawing.Size(176, 20);
            this.treeListLookUpEdit1.StyleController = this.layoutControl1;
            this.treeListLookUpEdit1.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.treeListLookUpEdit1, conditionValidationRule1);
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
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colnamegrupoaccion1,
            this.colcodigogrupoaccion1});
            this.treeListLookUpEdit1TreeList.DataSource = this.tGrupoAccionBindingSource;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "idgrupoacciones";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.EnableFiltering = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "idparent";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(12, 35);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "Acción";
            this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit2.Properties.RadioGroupIndex = 0;
            this.checkEdit2.Size = new System.Drawing.Size(175, 19);
            this.checkEdit2.StyleController = this.layoutControl1;
            this.checkEdit2.TabIndex = 5;
            this.checkEdit2.TabStop = false;
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(12, 12);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Categoría";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit1.Properties.RadioGroupIndex = 0;
            this.checkEdit1.Size = new System.Drawing.Size(355, 19);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(379, 69);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEdit1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 23);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEdit2;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 23);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.treeListLookUpEdit1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(179, 23);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(180, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // t_GrupoAccionTableAdapter
            // 
            this.t_GrupoAccionTableAdapter.ClearBeforeFill = true;
            // 
            // colnamegrupoaccion
            // 
            this.colnamegrupoaccion.Caption = "Nombre";
            this.colnamegrupoaccion.FieldName = "namegrupoaccion";
            this.colnamegrupoaccion.Name = "colnamegrupoaccion";
            this.colnamegrupoaccion.Visible = true;
            this.colnamegrupoaccion.VisibleIndex = 1;
            this.colnamegrupoaccion.Width = 192;
            // 
            // colcodigogrupoaccion
            // 
            this.colcodigogrupoaccion.Caption = "Código";
            this.colcodigogrupoaccion.FieldName = "codigogrupoaccion";
            this.colcodigogrupoaccion.Name = "colcodigogrupoaccion";
            this.colcodigogrupoaccion.Visible = true;
            this.colcodigogrupoaccion.VisibleIndex = 0;
            this.colcodigogrupoaccion.Width = 192;
            // 
            // colnamegrupoaccion1
            // 
            this.colnamegrupoaccion1.Caption = "Nombre";
            this.colnamegrupoaccion1.FieldName = "namegrupoaccion";
            this.colnamegrupoaccion1.Name = "colnamegrupoaccion1";
            this.colnamegrupoaccion1.Visible = true;
            this.colnamegrupoaccion1.VisibleIndex = 1;
            this.colnamegrupoaccion1.Width = 192;
            // 
            // colcodigogrupoaccion1
            // 
            this.colcodigogrupoaccion1.Caption = "Código";
            this.colcodigogrupoaccion1.FieldName = "codigogrupoaccion";
            this.colcodigogrupoaccion1.Name = "colcodigogrupoaccion1";
            this.colcodigogrupoaccion1.Visible = true;
            this.colcodigogrupoaccion1.VisibleIndex = 0;
            this.colcodigogrupoaccion1.Width = 192;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("ide_32x32.png", "images/programming/ide_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/programming/ide_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "ide_32x32.png");
            // 
            // FrmNewAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 139);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmNewAccion";
            this.Text = "FrmNewAccion";
            this.Load += new System.EventHandler(this.FrmNewAccion_Load);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.CodifcadorPieFormulario, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGrupoAccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tGrupoAccionBindingSource;
        private DSDatosTableAdapters.T_GrupoAccionTableAdapter t_GrupoAccionTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnamegrupoaccion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcodigogrupoaccion;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnamegrupoaccion1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcodigogrupoaccion1;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}