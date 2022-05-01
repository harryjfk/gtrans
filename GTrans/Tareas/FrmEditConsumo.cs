using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GTrans.Abstract;
using GTrans.Codificadores;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmEditConsumo : SaveableForm
    {
        public FrmEditConsumo()
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
            fechaDateEdit.Validating += ValidFechaDateEdit_Validating;
        }

        private int _edit;
        public int edit
        {
            get { return _edit; }
            set
            {
                _edit = value;  
                this.t_EquipoTableAdapter.Trabajando(this.dSDatos.T_Equipo);
                this.t_TipoCombustibleTableAdapter.Fill(this.dSDatos.T_TipoCombustible);
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Estado' Puede moverla o quitarla según sea necesario.
                this.t_EstadoTableAdapter.Fill(this.dSDatos.T_Estado);
                if (edit == -1)
                {
                    Text = "Insertar ";
                    tConsumoBindingSource.AddNew();
                    Consumo.idestado = 1;
                    idestadoSpinEdit.EditValue = 1;
                    dSDatos.T_ConsumoEquipo.idconsumoColumn.DefaultValue = -1;
                }
                else
                {
                    Text = "Editar ";
                    t_ConsumoTableAdapter.FillBy(dSDatos.T_Consumo, edit,"-1");
                    t_ConsumoEquipoTableAdapter.FillByConsumo(dSDatos.T_ConsumoEquipo, edit,"-1");
                    dSDatos.T_ConsumoEquipo.idconsumoColumn.DefaultValue = edit;
                    dataLayoutControl1.Enabled = Consumo.idestado == 1;
                }
                
                Text += "Consumo";
                toplabel.Text = Text;
                tEstadoBindingSource.Filter = "idestado<>3";
                loading = false;
            }
        }
        private bool loading = true;
        private void FrmEditConsumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoCombustible' Puede moverla o quitarla según sea necesario.
          

        }
        private DSDatos.T_ConsumoRow Consumo { get { return (DSDatos.T_ConsumoRow)((DataRowView)tConsumoBindingSource.Current).Row;} }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            var w = fechaDateEdit.Tag == null;
            if (!w)
                w = !(bool)fechaDateEdit.Tag;
            if (fKTConsumoEquipoTConsumoBindingSource.Count == 0)
                XtraMessageBox.Show("No se puede dejar el desloze de equipos vacio.", "Error");

            else
                if (w&& dxValidationProvider1.Validate() && dxValidationProvider2.Validate())
                {
                    tConsumoBindingSource.EndEdit();
                    t_ConsumoTableAdapter.Update(dSDatos.T_Consumo);
                    if (edit == -1)
                        foreach (var t in dSDatos.T_ConsumoEquipo)
                            t.idconsumo = Consumo.idconsumo;
                    try
                    {
                        t_ConsumoEquipoTableAdapter.Update(dSDatos.T_ConsumoEquipo);
                    }
                    catch (Exception k) { XtraMessageBox.Show("No se pueden insertar equipos duplicados."); }
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
        }
        private void CalcularImporte()
        {
            if (loading)
                return;
            var p= 0.0;
            var c = 0.0;
            if (gridLookUpEdit1.EditValue is int)
                p = TipoCombustible.precio;
      
            if (cantidadSpinEdit.EditValue is Decimal)
                c = Convert.ToDouble( cantidadSpinEdit.EditValue);
            else
            {
                try
                {
                    c= Consumo.cantidad;
                }catch(Exception){}
            }
            if(tConsumoBindingSource.Current!=null)
            {
         //       gridLookUpEdit1.EditValueChanged -= gridLookUpEdit1_EditValueChanged;
         //   Consumo.importe = p*c;
                var t = 0.0;
            importeSpinEdit.EditValue = p * c;
            foreach (var i in fKTConsumoEquipoTConsumoBindingSource)
            {
                ((DSDatos.T_ConsumoEquipoRow)((DataRowView)i).Row).importe = ((DSDatos.T_ConsumoEquipoRow)((DataRowView)i).Row).cantidad * p;
                t += ((DSDatos.T_ConsumoEquipoRow)((DataRowView)i).Row).cantidad;
            }
               //    gridLookUpEdit1.EditValueChanged += gridLookUpEdit1_EditValueChanged;
                if(t>c)
                {
                    XtraMessageBox.Show("La cantidad total del consumo no puede ser menor que la suma de cada uno de los deslozes.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cantidadSpinEdit.EditValue = Consumo.cantidad;
                }
            }
        }
        

        private void idestadoSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(idestadoSpinEdit.EditValue is int && dataLayoutControl1.Enabled)
            if ((int)idestadoSpinEdit.EditValue == 2)
                if (XtraMessageBox.Show(@"Esta seguro que desea confirmar el consumo?  Ya no podrá modificar ninguno de estos valores al hacerlo.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    idestadoSpinEdit.EditValue = 1;

        }
 
        private DSDatos.T_TipoCombustibleRow TipoCombustible { get { return (DSDatos.T_TipoCombustibleRow)((DataRowView)tTipoCombustibleBindingSource.Current).Row; } }

        private void cantidadSpinEdit_Properties_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
         
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (gridLookUpEdit1.EditValue is int)
                tTipoCombustibleBindingSource.Position = tTipoCombustibleBindingSource.Find("idtipocombustible", gridLookUpEdit1.EditValue);
            CalcularImporte();
        }

        private void gridLookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmTipoCombustible(Main);
                t.ShowDialog(this);
                t_TipoCombustibleTableAdapter.Fill(dSDatos.T_TipoCombustible);

            }
        }

        private void NoComprobanteSpinEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            var edit = (TextEdit)sender;
            //if (!(edit.EditValue is String))
            //    return;
            var validat = (int)t_ConsumoTableAdapter.ScalarQuery(int.Parse(edit.EditValue.ToString()), Consumo.idconsumo);


            var s = "";
            if (validat != 0)
                s = " No. de Comprobante";

            e.Cancel = s != "";
            if (s != "")
                edit.ErrorText = s + " tiene que ser único";
        }
        private double Sumcantidad()
        {
            var s = 0.0;

            foreach (var i in fKTConsumoEquipoTConsumoBindingSource)
                s += ((DSDatos.T_ConsumoEquipoRow)((DataRowView)i).Row).cantidad;
            return s;

        }            

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var c = 0;
            if (cantidadSpinEdit.EditValue != null)
            {
                if (int.TryParse(cantidadSpinEdit.EditValue.ToString(), out c))
                {
                    var cq = Sumcantidad();
                    e.Valid = c >= cq;
                    e.ErrorText = e.Valid ? "" : "La cantidad tiene que ser menor que la cantidad total. ";
                }
            }
            else
            {
                e.Valid = false;
                e.ErrorText = " Por favor defina primero la cantidad global del ticket";
            }

            if(e.Valid)
            {

            }

            DSDatos.T_ConsumoEquipoRow row = (DSDatos.T_ConsumoEquipoRow)((DataRowView)e.Row).Row;

            if (row.cantidad < 0)
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo cantidad.\n";
            }

            if (row.odometro < 0)
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo odómetro.\n";
            }

        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
            if(e.Column==colcantidad)
            {
                try
                {

              
                var r =(DSDatos.T_ConsumoEquipoRow) ((DataRowView)((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetRow(e.RowHandle)).Row;
                var p = 0.0;
                
                if (gridLookUpEdit1.EditValue is int)
                    p = TipoCombustible.precio;
                var c = 0.0;
                try
                {
                    c = int.Parse(e.Value.ToString());
                }
                catch (Exception) { }

                r.importe =c * p;
                  }catch(Exception w)
                {
                    MessageBox.Show("Por favor seleccione un equipo a entrar el consumo.");
                }
                // g

            }
        }

        private void cantidadSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CalcularImporte();
        }

        private void fechaDateEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            if (fechaDateEdit.EditValue is DateTime)
                e.Cancel = ((DateTime)fechaDateEdit.EditValue) > DateTime.Now;
            if (e.Cancel)
                fechaDateEdit.ErrorText = "La fecha del consumo tiene que ser menor que la fecha actual.";
            fechaDateEdit.Tag = e.Cancel;
        }
    }
}