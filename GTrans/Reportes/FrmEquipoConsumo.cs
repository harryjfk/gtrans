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
    public partial class FrmEquipoConsumo :CodificadorForm
    {
        public FrmEquipoConsumo(FrmMain main):base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }
        public int? Equipo { get { return gridLookUpEdit1.EditValue is int ? (int?)gridLookUpEdit1.EditValue : null; } }
     
        private void FrmEquipoConsumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);

        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {

            if (dxValidationProvider1.Validate())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            
        }

        private void FrmEquipoConsumo_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void FrmEquipoConsumo_Shown(object sender, EventArgs e)
        {
            toplabel.Text = Text;
        }
    }
}