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
using DevExpress.XtraGrid.Views.Grid;

namespace GTrans.Tareas
{
    public partial class FrmDeletedWorker : CodificadorForm
    {
        public FrmDeletedWorker()
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Reemplazar Trabajador", "Elija por cada orden que utiliza el trabajador a dar de baja, el trabajador que lo sustituirá.");
        }
        private List<DSDatos.T_EmpleadoRow> _list;
        public List<DSDatos.T_EmpleadoRow> List { get { return _list; } set { _list = value;

        foreach (var item in value)
        {
            f_GetPossibleWorkersTableAdapter.Fill(dSDatos.F_GetPossibleWorkers, item.idempleado);
        }
        
        } }
        public bool NeedShow()
        {
            return dSDatos.F_GetPossibleWorkers.Count > 0;
        }

        private void FrmDeletedWorker_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_OrdenTrabajoTableAdapter.Fill(this.dSDatos.T_OrdenTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empleado' Puede moverla o quitarla según sea necesario.
            this.t_EmpleadoTableAdapter.Fill(this.dSDatos.T_Empleado);

        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var row = (DSDatos.F_GetPossibleWorkersRow)((GridView)sender).GetDataRow(((GridView)sender).FocusedRowHandle);
            if (e.Value is bool)
                if ((bool)e.Value == true)
                { 
                    e.Valid = dSDatos.F_GetPossibleWorkers.HasSelected(row.idorden);
                    if (!e.Valid)
                        e.ErrorText = "No se pueden seleccionar mas de un sustituto para este trabajador";
                }

        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
          
        }



        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
  
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if (dSDatos.F_GetPossibleWorkers.IsComplete())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                XtraMessageBox.Show("Faltan datos por establecer");
        }
    }
}