using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GTrans.Abstract;

namespace GTrans.Tareas
{
    public partial class FrmObservacionesEstado : CodificadorForm
    {
        public FrmObservacionesEstado(FrmMain main)
            : base(main)
        {
            InitializeComponent();
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}