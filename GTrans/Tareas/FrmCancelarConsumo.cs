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

namespace GTrans.Tareas
{
    public partial class FrmCancelarConsumo : SaveableForm
    {
        public FrmCancelarConsumo()
        {
            InitializeComponent();
        }

        private void FrmCancelarConsumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Consumo' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ConsumoEquipo' Puede moverla o quitarla según sea necesario.

        }
        private DSDatos.T_ConsumoRow Consumo { get { return (DSDatos.T_ConsumoRow)((DataRowView)tConsumoBindingSource.Current).Row; } }
      
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                Consumo.idestado = 3;
                tConsumoBindingSource.EndEdit();
                t_ConsumoTableAdapter.Update(dSDatos.T_Consumo);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
        private int _edit;
        public int edit { get { return _edit; } set { _edit = value;
        this.t_ConsumoTableAdapter.FillBy(this.dSDatos.T_Consumo,edit,"-1");
        } }
    }
}