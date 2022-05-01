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
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Reportes
{
    public partial class FrmPlantillaReport : CodificadorForm
    {
        public FrmPlantillaReport(FrmMain main):base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }
        public int? Oficio { get { return gridLookUpEdit1.EditValue is int ? (int?)gridLookUpEdit1.EditValue : null; } }

        public int? NivelEscolaridad { get { return gridLookUpEdit2.EditValue is int ? (int?)gridLookUpEdit2.EditValue : null; } }
  
        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void FrmPlantillaReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_NivelEscolaridad' Puede moverla o quitarla según sea necesario.
            this.t_NivelEscolaridadTableAdapter.Fill(this.dSDatos.T_NivelEscolaridad);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);

        }

        private void FrmPlantillaReport_Shown(object sender, EventArgs e)
        {
            toplabel.Text = Text;
        }

    }
}