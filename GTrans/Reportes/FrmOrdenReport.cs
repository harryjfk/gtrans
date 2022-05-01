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

namespace GTrans.Reportes
{
    public partial class FrmOrdenReport : CodificadorForm
    {
        public FrmOrdenReport(FrmMain main):base(main)
        {
            InitializeComponent();
        }

        private void FrmOrdenReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_OrdenTrabajoTableAdapter.Fill(this.dSDatos.T_OrdenTrabajo);

        }
        public int Orden { get { return (int)gridLookUpEdit1.EditValue; } }
        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
    }
}