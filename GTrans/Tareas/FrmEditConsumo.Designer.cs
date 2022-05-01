namespace GTrans.Tareas
{
    partial class FrmEditConsumo
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule9 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule10 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.ucPieFormulario1 = new ACINOX.Components.UCPieFormulario();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tConsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSDatos = new GTrans.DSDatos();
            this.tTipoCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnametipocombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fKTConsumoEquipoTConsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidequipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tEquipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colodometro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.NoComprobanteSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.TerminalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cantidadSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.importeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ObservacionesTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.idestadoSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.tEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnameestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemForTerminal = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForfecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForcantidad = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForObservaciones = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNoComprobante = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForimporte = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForidestado = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.t_ConsumoTableAdapter = new GTrans.DSDatosTableAdapters.T_ConsumoTableAdapter();
            this.t_EstadoTableAdapter = new GTrans.DSDatosTableAdapters.T_EstadoTableAdapter();
            this.t_ConsumoEquipoTableAdapter = new GTrans.DSDatosTableAdapters.T_ConsumoEquipoTableAdapter();
            this.t_EquipoTableAdapter = new GTrans.DSDatosTableAdapters.T_EquipoTableAdapter();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.t_TipoCombustibleTableAdapter = new GTrans.DSDatosTableAdapters.T_TipoCombustibleTableAdapter();
            this.tableAdapterManager1 = new GTrans.DSDatosTableAdapters.TableAdapterManager();
            this.dxValidationProvider2 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).BeginInit();
            this.topcaptionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoCombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTConsumoEquipoTConsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoComprobanteSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionesTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForimporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidestado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // toplabel
            // 
            this.toplabel.Size = new System.Drawing.Size(458, 36);
            // 
            // topcaptionpanel
            // 
            this.topcaptionpanel.Size = new System.Drawing.Size(514, 40);
            // 
            // ucPieFormulario1
            // 
            this.ucPieFormulario1.Cerrar = true;
            this.ucPieFormulario1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPieFormulario1.Location = new System.Drawing.Point(0, 349);
            this.ucPieFormulario1.Name = "ucPieFormulario1";
            this.ucPieFormulario1.ShowingType = ACINOX.Components.PieFormularioType.pfOKCancel;
            this.ucPieFormulario1.Size = new System.Drawing.Size(514, 30);
            this.ucPieFormulario1.StringAceptar = "Aceptar";
            this.ucPieFormulario1.StringCancelar = "Cancelar";
            this.ucPieFormulario1.TabIndex = 3;
            this.ucPieFormulario1.Aceptar += new ACINOX.Components.UCPieFormulario.DelAceptar(this.ucPieFormulario1_Aceptar);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.gridLookUpEdit1);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Controls.Add(this.fechaDateEdit);
            this.dataLayoutControl1.Controls.Add(this.NoComprobanteSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.TerminalSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.cantidadSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.importeSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.ObservacionesTextEdit);
            this.dataLayoutControl1.Controls.Add(this.idestadoSpinEdit);
            this.dataLayoutControl1.DataSource = this.tConsumoBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTerminal});
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 40);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(514, 309);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "idtipocombustible", true));
            this.gridLookUpEdit1.Location = new System.Drawing.Point(115, 36);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.gridLookUpEdit1.Properties.DataSource = this.tTipoCombustibleBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nametipocombustible";
            this.gridLookUpEdit1.Properties.ValueMember = "idtipocombustible";
            this.gridLookUpEdit1.Properties.View = this.gridView2;
            this.gridLookUpEdit1.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gridLookUpEdit1_Properties_ButtonClick);
            this.gridLookUpEdit1.Size = new System.Drawing.Size(140, 20);
            this.gridLookUpEdit1.StyleController = this.dataLayoutControl1;
            this.gridLookUpEdit1.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit1, conditionValidationRule1);
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            // 
            // tConsumoBindingSource
            // 
            this.tConsumoBindingSource.DataMember = "T_Consumo";
            this.tConsumoBindingSource.DataSource = this.dSDatos;
            // 
            // dSDatos
            // 
            this.dSDatos.DataSetName = "DSDatos";
            this.dSDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.fKTConsumoEquipoTConsumoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(259, 100);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(243, 197);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // fKTConsumoEquipoTConsumoBindingSource
            // 
            this.fKTConsumoEquipoTConsumoBindingSource.DataMember = "T_ConsumoEquipo";
            this.fKTConsumoEquipoTConsumoBindingSource.DataSource = this.dSDatos;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidequipo,
            this.colcantidad,
            this.colimporte,
            this.colodometro});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colidequipo
            // 
            this.colidequipo.Caption = "Equipo";
            this.colidequipo.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colidequipo.FieldName = "idequipo";
            this.colidequipo.Name = "colidequipo";
            this.colidequipo.Visible = true;
            this.colidequipo.VisibleIndex = 0;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tEquipoBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "matricula";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.ValueMember = "idequipo";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // tEquipoBindingSource
            // 
            this.tEquipoBindingSource.DataMember = "T_Equipo";
            this.tEquipoBindingSource.DataSource = this.dSDatos;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmatricula});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colmatricula
            // 
            this.colmatricula.Caption = "Matrícula";
            this.colmatricula.FieldName = "matricula";
            this.colmatricula.Name = "colmatricula";
            this.colmatricula.Visible = true;
            this.colmatricula.VisibleIndex = 0;
            // 
            // colcantidad
            // 
            this.colcantidad.Caption = "Cantidad";
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 1;
            // 
            // colimporte
            // 
            this.colimporte.Caption = "Importe";
            this.colimporte.FieldName = "importe";
            this.colimporte.Name = "colimporte";
            this.colimporte.OptionsColumn.AllowEdit = false;
            this.colimporte.OptionsColumn.ReadOnly = true;
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 2;
            // 
            // colodometro
            // 
            this.colodometro.Caption = "Odómetro";
            this.colodometro.FieldName = "odometro";
            this.colodometro.Name = "colodometro";
            this.colodometro.Visible = true;
            this.colodometro.VisibleIndex = 3;
            // 
            // fechaDateEdit
            // 
            this.fechaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "fecha", true));
            this.fechaDateEdit.EditValue = null;
            this.fechaDateEdit.Location = new System.Drawing.Point(115, 12);
            this.fechaDateEdit.Name = "fechaDateEdit";
            this.fechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaDateEdit.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.fechaDateEdit_Properties_Validating);
            this.fechaDateEdit.Size = new System.Drawing.Size(140, 20);
            this.fechaDateEdit.StyleController = this.dataLayoutControl1;
            this.fechaDateEdit.TabIndex = 4;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.fechaDateEdit, conditionValidationRule2);
            // 
            // NoComprobanteSpinEdit
            // 
            this.NoComprobanteSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "NoComprobante", true));
            this.NoComprobanteSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NoComprobanteSpinEdit.Location = new System.Drawing.Point(362, 12);
            this.NoComprobanteSpinEdit.Name = "NoComprobanteSpinEdit";
            this.NoComprobanteSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NoComprobanteSpinEdit.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.NoComprobanteSpinEdit_Properties_Validating);
            this.NoComprobanteSpinEdit.Size = new System.Drawing.Size(140, 20);
            this.NoComprobanteSpinEdit.StyleController = this.dataLayoutControl1;
            this.NoComprobanteSpinEdit.TabIndex = 5;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule3.ErrorText = "Valor no válido";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule3.Value1 = 0F;
            this.dxValidationProvider2.SetValidationRule(this.NoComprobanteSpinEdit, conditionValidationRule3);
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.NoComprobanteSpinEdit, conditionValidationRule4);
            this.NoComprobanteSpinEdit.Validating += new System.ComponentModel.CancelEventHandler(this.NoComprobanteSpinEdit_Properties_Validating);
            // 
            // TerminalSpinEdit
            // 
            this.TerminalSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "Terminal", true));
            this.TerminalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TerminalSpinEdit.Location = new System.Drawing.Point(115, 36);
            this.TerminalSpinEdit.Name = "TerminalSpinEdit";
            this.TerminalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TerminalSpinEdit.Size = new System.Drawing.Size(140, 20);
            this.TerminalSpinEdit.StyleController = this.dataLayoutControl1;
            this.TerminalSpinEdit.TabIndex = 6;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule5.ErrorText = "Valor no válido";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule5.Value1 = 0F;
            this.dxValidationProvider2.SetValidationRule(this.TerminalSpinEdit, conditionValidationRule5);
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            conditionValidationRule6.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.TerminalSpinEdit, conditionValidationRule6);
            // 
            // cantidadSpinEdit
            // 
            this.cantidadSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "cantidad", true));
            this.cantidadSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.cantidadSpinEdit.Location = new System.Drawing.Point(115, 60);
            this.cantidadSpinEdit.Name = "cantidadSpinEdit";
            this.cantidadSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cantidadSpinEdit.Properties.EditValueChanged += new System.EventHandler(this.cantidadSpinEdit_Properties_EditValueChanged);
            this.cantidadSpinEdit.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cantidadSpinEdit_Properties_EditValueChanging);
            this.cantidadSpinEdit.Size = new System.Drawing.Size(140, 20);
            this.cantidadSpinEdit.StyleController = this.dataLayoutControl1;
            this.cantidadSpinEdit.TabIndex = 7;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.GreaterOrEqual;
            conditionValidationRule7.ErrorText = "Valor no válido";
            conditionValidationRule7.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            conditionValidationRule7.Value1 = 0F;
            this.dxValidationProvider2.SetValidationRule(this.cantidadSpinEdit, conditionValidationRule7);
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "This value is not valid";
            conditionValidationRule8.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.cantidadSpinEdit, conditionValidationRule8);
            // 
            // importeSpinEdit
            // 
            this.importeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "importe", true));
            this.importeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.importeSpinEdit.Enabled = false;
            this.importeSpinEdit.Location = new System.Drawing.Point(362, 36);
            this.importeSpinEdit.Name = "importeSpinEdit";
            this.importeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.importeSpinEdit.Size = new System.Drawing.Size(140, 20);
            this.importeSpinEdit.StyleController = this.dataLayoutControl1;
            this.importeSpinEdit.TabIndex = 8;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule9.ErrorText = "This value is not valid";
            conditionValidationRule9.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.importeSpinEdit, conditionValidationRule9);
            // 
            // ObservacionesTextEdit
            // 
            this.ObservacionesTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "Observaciones", true));
            this.ObservacionesTextEdit.Location = new System.Drawing.Point(12, 100);
            this.ObservacionesTextEdit.Name = "ObservacionesTextEdit";
            this.ObservacionesTextEdit.Size = new System.Drawing.Size(243, 197);
            this.ObservacionesTextEdit.StyleController = this.dataLayoutControl1;
            this.ObservacionesTextEdit.TabIndex = 9;
            // 
            // idestadoSpinEdit
            // 
            this.idestadoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tConsumoBindingSource, "idestado", true));
            this.idestadoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idestadoSpinEdit.Location = new System.Drawing.Point(362, 60);
            this.idestadoSpinEdit.Name = "idestadoSpinEdit";
            this.idestadoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idestadoSpinEdit.Properties.DataSource = this.tEstadoBindingSource;
            this.idestadoSpinEdit.Properties.DisplayMember = "nameestado";
            this.idestadoSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.idestadoSpinEdit.Properties.NullText = "";
            this.idestadoSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.idestadoSpinEdit.Properties.ValueMember = "idestado";
            this.idestadoSpinEdit.Properties.View = this.gridLookUpEdit1View;
            this.idestadoSpinEdit.Properties.EditValueChanged += new System.EventHandler(this.idestadoSpinEdit_Properties_EditValueChanged);
            this.idestadoSpinEdit.Size = new System.Drawing.Size(140, 20);
            this.idestadoSpinEdit.StyleController = this.dataLayoutControl1;
            this.idestadoSpinEdit.TabIndex = 10;
            conditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule10.ErrorText = "This value is not valid";
            conditionValidationRule10.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.idestadoSpinEdit, conditionValidationRule10);
            // 
            // tEstadoBindingSource
            // 
            this.tEstadoBindingSource.DataMember = "T_Estado";
            this.tEstadoBindingSource.DataSource = this.dSDatos;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnameestado});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colnameestado
            // 
            this.colnameestado.Caption = "Estado";
            this.colnameestado.FieldName = "nameestado";
            this.colnameestado.Name = "colnameestado";
            this.colnameestado.Visible = true;
            this.colnameestado.VisibleIndex = 0;
            // 
            // ItemForTerminal
            // 
            this.ItemForTerminal.Control = this.TerminalSpinEdit;
            this.ItemForTerminal.CustomizationFormText = "Terminal";
            this.ItemForTerminal.Location = new System.Drawing.Point(0, 24);
            this.ItemForTerminal.Name = "ItemForTerminal";
            this.ItemForTerminal.Size = new System.Drawing.Size(247, 24);
            this.ItemForTerminal.Text = "Terminal";
            this.ItemForTerminal.TextSize = new System.Drawing.Size(100, 13);
            this.ItemForTerminal.TextToControlDistance = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(514, 309);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForfecha,
            this.ItemForcantidad,
            this.ItemForObservaciones,
            this.ItemForNoComprobante,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForimporte,
            this.ItemForidestado});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(494, 289);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForfecha
            // 
            this.ItemForfecha.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForfecha.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForfecha.Control = this.fechaDateEdit;
            this.ItemForfecha.CustomizationFormText = "Fecha:";
            this.ItemForfecha.Location = new System.Drawing.Point(0, 0);
            this.ItemForfecha.Name = "ItemForfecha";
            this.ItemForfecha.Size = new System.Drawing.Size(247, 24);
            this.ItemForfecha.Text = "Fecha:";
            this.ItemForfecha.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForcantidad
            // 
            this.ItemForcantidad.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForcantidad.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForcantidad.Control = this.cantidadSpinEdit;
            this.ItemForcantidad.CustomizationFormText = "Cantidad:";
            this.ItemForcantidad.Location = new System.Drawing.Point(0, 48);
            this.ItemForcantidad.Name = "ItemForcantidad";
            this.ItemForcantidad.Size = new System.Drawing.Size(247, 24);
            this.ItemForcantidad.Text = "Cantidad:";
            this.ItemForcantidad.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForObservaciones
            // 
            this.ItemForObservaciones.Control = this.ObservacionesTextEdit;
            this.ItemForObservaciones.CustomizationFormText = "Observaciones";
            this.ItemForObservaciones.Location = new System.Drawing.Point(0, 72);
            this.ItemForObservaciones.Name = "ItemForObservaciones";
            this.ItemForObservaciones.Size = new System.Drawing.Size(247, 217);
            this.ItemForObservaciones.Text = "Observaciones";
            this.ItemForObservaciones.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForObservaciones.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForNoComprobante
            // 
            this.ItemForNoComprobante.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForNoComprobante.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForNoComprobante.Control = this.NoComprobanteSpinEdit;
            this.ItemForNoComprobante.CustomizationFormText = "No. Comprobante:";
            this.ItemForNoComprobante.Location = new System.Drawing.Point(247, 0);
            this.ItemForNoComprobante.Name = "ItemForNoComprobante";
            this.ItemForNoComprobante.Size = new System.Drawing.Size(247, 24);
            this.ItemForNoComprobante.Text = "No. Comprobante:";
            this.ItemForNoComprobante.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForimporte
            // 
            this.ItemForimporte.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForimporte.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForimporte.Control = this.importeSpinEdit;
            this.ItemForimporte.CustomizationFormText = "Importe:";
            this.ItemForimporte.Location = new System.Drawing.Point(247, 24);
            this.ItemForimporte.Name = "ItemForimporte";
            this.ItemForimporte.Size = new System.Drawing.Size(247, 24);
            this.ItemForimporte.Text = "Importe:";
            this.ItemForimporte.TextSize = new System.Drawing.Size(100, 13);
            // 
            // ItemForidestado
            // 
            this.ItemForidestado.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ItemForidestado.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ItemForidestado.Control = this.idestadoSpinEdit;
            this.ItemForidestado.CustomizationFormText = "Estado:";
            this.ItemForidestado.Location = new System.Drawing.Point(247, 48);
            this.ItemForidestado.Name = "ItemForidestado";
            this.ItemForidestado.Size = new System.Drawing.Size(247, 24);
            this.ItemForidestado.Text = "Estado:";
            this.ItemForidestado.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.CustomizationFormText = "Desloze";
            this.layoutControlItem1.Location = new System.Drawing.Point(247, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(247, 217);
            this.layoutControlItem1.Text = "Desloze";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.gridLookUpEdit1;
            this.layoutControlItem2.CustomizationFormText = "Tipo de Combustible:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem2.Text = "Tipo de Combustible:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(100, 13);
            // 
            // t_ConsumoTableAdapter
            // 
            this.t_ConsumoTableAdapter.ClearBeforeFill = true;
            // 
            // t_EstadoTableAdapter
            // 
            this.t_EstadoTableAdapter.ClearBeforeFill = true;
            // 
            // t_ConsumoEquipoTableAdapter
            // 
            this.t_ConsumoEquipoTableAdapter.ClearBeforeFill = true;
            // 
            // t_EquipoTableAdapter
            // 
            this.t_EquipoTableAdapter.ClearBeforeFill = true;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidateHiddenControls = false;
            // 
            // t_TipoCombustibleTableAdapter
            // 
            this.t_TipoCombustibleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.T_AlmacenExistenciaTableAdapter = null;
            this.tableAdapterManager1.T_AlmacenTableAdapter = null;
            this.tableAdapterManager1.T_AreaTableAdapter = null;
            this.tableAdapterManager1.T_CategoriaTableAdapter = null;
            this.tableAdapterManager1.T_ClasificacionTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoEquipoTableAdapter = null;
            this.tableAdapterManager1.T_ConsumoTableAdapter = null;
            this.tableAdapterManager1.T_Empleado_FormaTableAdapter = null;
            this.tableAdapterManager1.T_EmpleadoTableAdapter = null;
            this.tableAdapterManager1.T_EmpresaTableAdapter = null;
            this.tableAdapterManager1.T_EquipoTableAdapter = this.t_EquipoTableAdapter;
            this.tableAdapterManager1.T_Estado_TecnicoTableAdapter = null;
            this.tableAdapterManager1.T_EstadoOrdenTableAdapter = null;
            this.tableAdapterManager1.T_EstadoTableAdapter = this.t_EstadoTableAdapter;
            this.tableAdapterManager1.T_FormaPagoTableAdapter = null;
            this.tableAdapterManager1.T_GrupoAccionTableAdapter = null;
            this.tableAdapterManager1.T_MarcaTableAdapter = null;
            this.tableAdapterManager1.T_ModeloTableAdapter = null;
            this.tableAdapterManager1.T_MonedaTableAdapter = null;
            this.tableAdapterManager1.T_NivelEscolaridadTableAdapter = null;
            this.tableAdapterManager1.T_OrdenSalarioTableAdapter = null;
            this.tableAdapterManager1.T_OrdenSurtidoMonedaTableAdapter = null;
            this.tableAdapterManager1.T_OrdenSurtidoTableAdapter = null;
            this.tableAdapterManager1.T_OrdenTrabajoTableAdapter = null;
            this.tableAdapterManager1.T_PaisTableAdapter = null;
            this.tableAdapterManager1.T_ParalizadoTableAdapter = null;
            this.tableAdapterManager1.T_PlanificacionTableAdapter = null;
            this.tableAdapterManager1.T_ProductoGenericoTableAdapter = null;
            this.tableAdapterManager1.T_ProductoTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_EquipoTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_MarcaTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_MatriculaTableAdapter = null;
            this.tableAdapterManager1.T_Tipo_ParalizadoTableAdapter = null;
            this.tableAdapterManager1.T_TipoCombustibleTableAdapter = this.t_TipoCombustibleTableAdapter;
            this.tableAdapterManager1.T_TipoMantenimientoTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloAccionTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloMantSurtidoTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloMantTableAdapter = null;
            this.tableAdapterManager1.T_TipoModeloMantTrabTableAdapter = null;
            this.tableAdapterManager1.T_TipoTrabajoTableAdapter = null;
            this.tableAdapterManager1.T_TipoValeTableAdapter = null;
            this.tableAdapterManager1.T_UEBTableAdapter = null;
            this.tableAdapterManager1.T_UMTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaMonedaTableAdapter = null;
            this.tableAdapterManager1.T_ValeExistenciaTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GTrans.DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dxValidationProvider2
            // 
            this.dxValidationProvider2.ValidateHiddenControls = false;
            // 
            // FrmEditConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 379);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ucPieFormulario1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditConsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEditConsumo";
            this.Load += new System.EventHandler(this.FrmEditConsumo_Load);
            this.Controls.SetChildIndex(this.ucPieFormulario1, 0);
            this.Controls.SetChildIndex(this.topcaptionpanel, 0);
            this.Controls.SetChildIndex(this.dataLayoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcaptionpanel)).EndInit();
            this.topcaptionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tConsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTipoCombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTConsumoEquipoTConsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEquipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoComprobanteSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TerminalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacionesTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idestadoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForfecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNoComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForimporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForidestado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ACINOX.Components.UCPieFormulario ucPieFormulario1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DSDatos dSDatos;
        private System.Windows.Forms.BindingSource tConsumoBindingSource;
        private DSDatosTableAdapters.T_ConsumoTableAdapter t_ConsumoTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit fechaDateEdit;
        private DevExpress.XtraEditors.SpinEdit NoComprobanteSpinEdit;
        private DevExpress.XtraEditors.SpinEdit TerminalSpinEdit;
        private DevExpress.XtraEditors.SpinEdit cantidadSpinEdit;
        private DevExpress.XtraEditors.SpinEdit importeSpinEdit;
        private DevExpress.XtraEditors.MemoEdit ObservacionesTextEdit;
        private DevExpress.XtraEditors.GridLookUpEdit idestadoSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForfecha;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTerminal;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcantidad;
        private DevExpress.XtraLayout.LayoutControlItem ItemForObservaciones;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNoComprobante;
        private DevExpress.XtraLayout.LayoutControlItem ItemForimporte;
        private DevExpress.XtraLayout.LayoutControlItem ItemForidestado;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource tEstadoBindingSource;
        private DSDatosTableAdapters.T_EstadoTableAdapter t_EstadoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnameestado;
        private System.Windows.Forms.BindingSource fKTConsumoEquipoTConsumoBindingSource;
        private DSDatosTableAdapters.T_ConsumoEquipoTableAdapter t_ConsumoEquipoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidequipo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn colodometro;
        private System.Windows.Forms.BindingSource tEquipoBindingSource;
        private DSDatosTableAdapters.T_EquipoTableAdapter t_EquipoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colmatricula;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource tTipoCombustibleBindingSource;
        private DSDatosTableAdapters.T_TipoCombustibleTableAdapter t_TipoCombustibleTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnametipocombustible;
        private DevExpress.XtraGrid.Columns.GridColumn colprecio;
        private DSDatosTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider2;
    }
}