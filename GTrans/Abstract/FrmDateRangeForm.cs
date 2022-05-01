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

namespace GTrans.Abstract
{
    public partial class FrmDateRangeForm : CodificadorForm
    {
        public FrmDateRangeForm()
        {
            InitializeComponent();
        }
        public FrmDateRangeForm(FrmMain main):base(main)
        {
            InitializeComponent();
        }

        public int TypeReport { get; set; }

        public int? TipoOrden { get { return gridLookUpEdit1.EditValue is int ? (int?)gridLookUpEdit1.EditValue : null; } }

        public DateTime FechaInicial { get { return (DateTime)dateEdit1.EditValue; } }
        public DateTime FechaFinal { get { return (DateTime)dateEdit2.EditValue; } }
        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate() && dxValidationProvider2.Validate())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void FrmDateRangeForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstadoOrden' Puede moverla o quitarla según sea necesario.
            this.t_EstadoOrdenTableAdapter.Fill(this.dSDatos.T_EstadoOrden);

        }

        private void FrmDateRangeForm_Shown(object sender, EventArgs e)
        {
            toplabel.Text = Text;
        }
    }
}