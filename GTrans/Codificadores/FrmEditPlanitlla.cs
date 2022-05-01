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
using DevExpress.XtraEditors.Controls;

namespace GTrans.Codificadores
{
    public partial class FrmEditPlanitlla : CodificadorForm
    {
        public FrmEditPlanitlla(FrmMain main):base(main)
        {
            InitializeComponent();
        }

        private int _edit;
        public int edit
        {
            get
            {
                return _edit;
            }
            set
            {
                _edit = value;
                var e="";
                if(_edit==-1)
                {
                    tEmpleadoBindingSource.AddNew();
                    tEmpleadoBindingSource.MoveLast();
                    dSDatos.T_Empleado_Forma.idempleadoColumn.DefaultValue = -1;
                    e = "Añadir";
                }
                else
                {
                    t_EmpleadoTableAdapter.FillBy(dSDatos.T_Empleado, edit);
                    t_Empleado_FormaTableAdapter.FillBy(dSDatos.T_Empleado_Forma, edit);
                    e = "Añadir";
                }
            e+=" Empleado";
                Text = e;
                toplabel.Text=Text;
            }
        }

        private void FrmEditPlanitlla_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_FormaPago' Puede moverla o quitarla según sea necesario.
            this.t_FormaPagoTableAdapter.Fill(this.dSDatos.T_FormaPago);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_NivelEscolaridad' Puede moverla o quitarla según sea necesario.
            this.t_NivelEscolaridadTableAdapter.Fill(this.dSDatos.T_NivelEscolaridad);


        }

        private void idtipotrabajoSpinEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var t = new FrmTipoTrabajo(Main);
                t.ShowDialog(this);
                t_TipoTrabajoTableAdapter.Fill(dSDatos.T_TipoTrabajo);
                t.Dispose();

            }
        }

        private void nameempleadoTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = (ACINOX.Functions.Validation.IsNum(e.KeyValue));
   
        }

        private void ciempleadoTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = !(ACINOX.Functions.Validation.IsNum(e.KeyValue)) && e.KeyData != Keys.Back;
  
        }
        private DSDatos.T_EmpleadoRow Empleado { get { return ((DSDatos.T_EmpleadoRow)((DataRowView)tEmpleadoBindingSource.Current).Row); } }


        private void ciempleadoTextEdit_Validating(object sender, CancelEventArgs e)
        {
            if (ciempleadoTextEdit.EditValue is string)
            {
                float a = 0;
                e.Cancel = !float.TryParse((string)ciempleadoTextEdit.EditValue, out a) || ((string)ciempleadoTextEdit.EditValue).Length != 11;
                if (!e.Cancel)
                    if ((int)t_EmpleadoTableAdapter.ScalarQuery((string)ciempleadoTextEdit.EditValue, (string)ciempleadoTextEdit.Tag, Empleado.idempleado) > 0)
                    {
                        ciempleadoTextEdit.ErrorText = "El Carnet de identidad tiene q ser unico";
                        e.Cancel = true;
                    }


            }
        }

        private void codempleadoTextEdit_Validating(object sender, CancelEventArgs e)
        {
            if(codempleadoTextEdit.EditValue is string)
            if ((int)t_EmpleadoTableAdapter.ScalarQuery((string)codempleadoTextEdit.EditValue, (string)codempleadoTextEdit.Tag, Empleado.idempleado) > 0)
            {
                codempleadoTextEdit.ErrorText = "El código tiene q ser unico";
                e.Cancel = true;
            }
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            if( dxValidationProvider1.Validate())
            {
                tEmpleadoBindingSource.EndEdit();
                t_EmpleadoTableAdapter.Update(dSDatos.T_Empleado);

                if(_edit==-1)
                    foreach (var item in dSDatos.T_Empleado_Forma)
                    {
                        item.idempleado = Empleado.idempleado;
                    }
                t_Empleado_FormaTableAdapter.Update(dSDatos.T_Empleado_Forma);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();


            }
        }
    }
}