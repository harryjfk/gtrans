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
    public partial class FrmEquiposReport : CodificadorForm
    {
        public FrmEquiposReport(FrmMain main):base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        public int? Empresa { get { return gridLookUpEdit1.EditValue is int ? (int?)gridLookUpEdit1.EditValue : null; } }
        public int? UEB { get { return gridLookUpEdit2.EditValue is int ? (int?)gridLookUpEdit2.EditValue : null; } }
        public int? Area { get { return gridLookUpEdit3.EditValue is int ? (int?)gridLookUpEdit3.EditValue : null; } }

        private void FrmEquiposReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Area' Puede moverla o quitarla según sea necesario.
            this.t_AreaTableAdapter.Fill(this.dSDatos.T_Area);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_UEB' Puede moverla o quitarla según sea necesario.
            this.t_UEBTableAdapter.Fill(this.dSDatos.T_UEB);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empresa' Puede moverla o quitarla según sea necesario.
            this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);
      
        }

        private void FrmEquiposReport_Shown(object sender, EventArgs e)
        {
            toplabel.Text = Text;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            tEmpresaBindingSource.Position = tEmpresaBindingSource.Find("id_empresa", gridLookUpEdit1.EditValue);
        }

        private int GetPos(int s )
        {
            int t = 0;
            foreach (DataRowView item in fKTUEBTEmpresaBindingSource)
            {
                if (((DSDatos.T_UEBRow)item.Row).id_ueb == s)
                    return t;
                t++;
            }
            return -1;

        }
        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

            fKTUEBTEmpresaBindingSource.Position = GetPos( (int)gridLookUpEdit2.EditValue);
        }
    }
}