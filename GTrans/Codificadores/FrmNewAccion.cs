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

namespace GTrans.Codificadores
{
    public partial class FrmNewAccion : CodificadorForm
    {
        public FrmNewAccion(FrmMain main):base(main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Tipo", "Tipo");
        }

        private void FrmNewAccion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_GrupoAccion' Puede moverla o quitarla según sea necesario.
            this.t_GrupoAccionTableAdapter.Fill(this.dSDatos.T_GrupoAccion);

        }
        public int? Data
        {
            get
            {

                if (!checkEdit1.Checked)
                    return (int?)treeListLookUpEdit1.EditValue;

                return null;

            }
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if (!checkEdit1.Checked)
            {
                if(dxValidationProvider1.Validate())
                {
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }

            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }

        }
    }
}