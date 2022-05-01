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
using DevExpress.XtraLayout.Utils;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Reportes
{
    public partial class FrmAlmacenReport : CodificadorForm
    {
        private bool _value;
        public FrmAlmacenReport(FrmMain main):base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }
        public int? TipoVale { get { return gridLookUpEdit1.EditValue is int ? (int?)gridLookUpEdit1.EditValue : null; } }

        public int? Producto { get { return gridLookUpEdit2.EditValue is int ? (int?)gridLookUpEdit2.EditValue : null; } }

        public bool value { get { return _value; } set { _value = value;
        layoutControlItem1.Visibility = value == true ? LayoutVisibility.Always : LayoutVisibility.Never;
        layoutControlItem2.Visibility = value == false ? LayoutVisibility.Always : LayoutVisibility.Never;
        } }
        private void FrmAlmacenReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoVale' Puede moverla o quitarla según sea necesario.
            this.t_TipoValeTableAdapter.Fill(this.dSDatos.T_TipoVale);
            t_ClasificacionTableAdapter1.Fill(dSDatos.T_Clasificacion);
            t_UMTableAdapter1.Fill(dSDatos.T_UM);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Producto' Puede moverla o quitarla según sea necesario.
            this.t_ProductoTableAdapter.FillBy(this.dSDatos.T_Producto,-1,"-1");

        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}