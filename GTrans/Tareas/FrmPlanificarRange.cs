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
    public partial class FrmPlanificarRange : CodificadorForm
    {
        public FrmPlanificarRange(FrmMain Main):base(Main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0],"Rango de Planificación", "Especifique el rango para crear la planificación");
        }
        public int? equipo { get { int? t = null;
        if (gridLookUpEdit1.EditValue is int)
            t = (int)gridLookUpEdit1.EditValue;
        return t;
        }
        }
        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate() && dxValidationProvider2.Validate())
            {

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void FrmPlanificarRange_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            startedit.EditValue = new DateTime(DateTime.Now.Year, 1, 1);
            endedit.EditValue = new DateTime(DateTime.Now.Year, 12, 31);
        }
    }
}