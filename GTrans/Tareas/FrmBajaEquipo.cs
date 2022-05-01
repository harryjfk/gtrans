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

namespace GTrans.Tareas
{
    public partial class FrmBajaEquipo : DevExpress.XtraEditors.XtraForm
    {
        public FrmBajaEquipo()
        {
            InitializeComponent();
        }
        private int _idequipo;
        public int idequipo { get { return _idequipo; } set { _idequipo = value; this.t_EquipoTableAdapter.FillBy(this.dSDatos.T_Equipo,value,"-1","0");  } }
        private void FrmBajaEquipo_Load(object sender, EventArgs e)
        {

            fecha_bajaDateEdit.EditValue = DateTime.Now;
        }
        public DSDatos.T_EquipoRow Equipo { get { return (DSDatos.T_EquipoRow) ((DataRowView)tEquipoBindingSource.Current).Row; } }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                Equipo.baja = true;
                Equipo.explotacion = false;
                tEquipoBindingSource.EndEdit();
               t_EquipoTableAdapter.Update(dSDatos.T_Equipo);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
    }
}