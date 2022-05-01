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
using GTrans.Codificadores;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmEditEquipo : SaveableForm
    {
        public FrmEditEquipo()
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }

        private void FrmEditEquipo_Load(object sender, EventArgs e)
        {
       
       
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
        
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Categoria' Puede moverla o quitarla según sea necesario.
       
               //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            //this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Area' Puede moverla o quitarla según sea necesario.
            //this.t_AreaTableAdapter.Fill(this.dSDatos.T_Area);
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_UEB' Puede moverla o quitarla según sea necesario.
            //this.t_UEBTableAdapter.Fill(this.dSDatos.T_UEB);
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empresa' Puede moverla o quitarla según sea necesario.
            //this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);

            fecha_bajaDateEdit.Validating += ValidFechaDateEdit_Validating;
            fecha_puestaDateEdit.Validating += ValidFechaDateEdit_Validating;
            fecha_fabDateEdit.Validating += ValidFechaDateEdit_Validating;

        }
        private int _edit;
        public int idparent { get; set; }
        private int _type;
        public int edit
        {
            get { return _edit; }
            set
            {
                _edit = value;
     
                var text = "";
                if (_edit == -1)
                    text += "Añadir ";
                else
                    text += "Editar ";
                switch (type)
                {
                    case 0:
                        {
                            text += "Empresa";
                            if (edit != -1)
                                this.t_EmpresaTableAdapter.FillBy(this.dSDatos.T_Empresa, edit);
                            else { tEmpresaBindingSource.AddNew(); }
                            break;
                        }
                    case 1:
                        {
                            text += "UEB";
                            this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);
                            if (edit != -1)
                            {
                                this.t_UEBTableAdapter.FillBy(this.dSDatos.T_UEB, edit);
                                //dSDatos.T_UEB.id_uebColumn.DefaultValue = edit;
                                
                            }

                            else
                            {
                                dSDatos.T_UEB.id_empresaColumn.DefaultValue = idparent;
                                tUEBBindingSource.AddNew();
                                id_empresaSpinEdit.EditValue = idparent;
                            }
                            break;
                        }
                    case 2:
                        {
                            text += "Area";
                            this.t_UEBTableAdapter.Fill(this.dSDatos.T_UEB);
                            if (edit != -1)
                                this.t_AreaTableAdapter.FillBy(this.dSDatos.T_Area, edit);
                            else
                            {
                                dSDatos.T_Area.id_uebColumn.DefaultValue = idparent;
                                tAreaBindingSource.AddNew();
                                spinEdit1.EditValue = idparent;
                            }
                            break;
                        }
                    case 3:
                        {
                            this.t_UEBTableAdapter.Fill(this.dSDatos.T_UEB);
                            this.t_MarcaTableAdapter.Fill(this.dSDatos.T_Marca);
                            this.t_CategoriaTableAdapter.Fill(this.dSDatos.T_Categoria);
                            t_AreaTableAdapter.Fill(dSDatos.T_Area);
                            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoCombustible' Puede moverla o quitarla según sea necesario.
                            this.t_TipoCombustibleTableAdapter.Fill(this.dSDatos.T_TipoCombustible);
                            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Matricula' Puede moverla o quitarla según sea necesario.
                            this.t_Tipo_MatriculaTableAdapter.Fill(this.dSDatos.T_Tipo_Matricula);
                            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Pais' Puede moverla o quitarla según sea necesario.
                            this.t_PaisTableAdapter.Fill(this.dSDatos.T_Pais);
                            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Paralizado' Puede moverla o quitarla según sea necesario.
                             // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Estado_Tecnico' Puede moverla o quitarla según sea necesario.
                            this.t_Estado_TecnicoTableAdapter.Fill(this.dSDatos.T_Estado_Tecnico);
                            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Modelo' Puede moverla o quitarla según sea necesario.
                            this.t_ModeloTableAdapter.FillByTipoMarca(this.dSDatos.T_Modelo,1);
                            this.t_ModeloTableAdapter.FillByTipoMarca(this.dsDatos2.T_Modelo, 2);
                            this.t_ModeloTableAdapter.FillByTipoMarca(this.dsDatos1.T_Modelo, 3);
                            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Equipo' Puede moverla o quitarla según sea necesario.
                            this.t_Tipo_EquipoTableAdapter.Fill(this.dSDatos.T_Tipo_Equipo);
     
                            text += "Equipo";
                            if (edit != -1)
                            {
                                t_EquipoTableAdapter.FillBy1(dSDatos.T_Equipo, edit);
                                if (Equipo.paralizado)
                                {
                                    this.t_ParalizadoTableAdapter.Fill(this.dSDatos.T_Paralizado);
                       
                                }
                                equipolayout.Enabled = !Equipo.baja;

                            }
                                
                            else
                            {

                                if(idparent!=-1)
                                dSDatos.T_TipoModeloAccion.idtipomodelomantColumn.DefaultValue = idparent;
                                tEquipoBindingSource.AddNew();
                                Equipo.explotacion = true;
                                if (idparent != -1)
                                Equipo.id_areaasig = idparent;
                            }
                            fecha_fabDateEdit.EditValue = fecha_fabDateEdit.EditValue;
                            break;
                        }
                    default: break;

                }
                Text = text;
                toplabel.Text = text;
            }
        }
        public DSDatos.T_EquipoRow Equipo { get { return (DSDatos.T_EquipoRow)((DataRowView)tEquipoBindingSource.Current).Row; } }
        public int type
        {
            get { return _type; }
            set
            {
                _type = value;
                empresalayout.Visible = type == 0;
                ueblayout.Visible = type == 1;
                arealayout.Visible = type == 2;
                equipolayout.Visible = type == 3;

                switch (_type)
                {
                    case 0: { Height = 154; break; }
                    case 1: { Height = 178; break; }
                    case 2: { Height = 178; break; }
                    case 3: { Height = 674; break; }
                    default: break;
                }

            }
        }
            private void ucPieFormulario1_Aceptar(object sender)
        {
          var t =       fecha_fabDateEdit.Tag==null;
                if(!t)
                    t = !(bool)fecha_fabDateEdit.Tag;
            if (t && dxValidationProvider1.Validate() && dxValidationProvider2.Validate() && dxValidationProvider3.Validate() && dxValidationProvider4.Validate())
            {
                switch (_type)
                {
                    case 0: {
                        tEmpresaBindingSource.EndEdit();
                        t_EmpresaTableAdapter.Update(dSDatos.T_Empresa);
                        break; }
                    case 1:
                        {
                            tUEBBindingSource.EndEdit();
                            t_UEBTableAdapter.Update(dSDatos.T_UEB);
                            break;
                        }
                    case 2:
                        {
                            tAreaBindingSource.EndEdit();
                            t_AreaTableAdapter.Update(dSDatos.T_Area);
                            break;
                        }
                    case 3:
                        {


                            tEquipoBindingSource.EndEdit();
                            t_EquipoTableAdapter.Update(dSDatos.T_Equipo);
                            break;

                        }
                    default: break;
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void idmodelomotorSpinEdit_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmMarca();
                t.ShowDialog(this);
                t_MarcaTableAdapter.Fill(dsDatos1.T_Marca);
                t_MarcaTableAdapter.Fill(dsDatos2.T_Marca);
                t_MarcaTableAdapter.Fill(dSDatos.T_Marca);
                this.t_ModeloTableAdapter.FillByTipoMarca(this.dsDatos1.T_Modelo, 3); 
                this.t_ModeloTableAdapter.FillByTipoMarca(this.dsDatos2.T_Modelo, 2);
          
            }
        }

        private void id_paisSpinEdit_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmPais(Main);
                t.ShowDialog(this);
                t_PaisTableAdapter.Fill(dSDatos.T_Pais);
            }
        }

        private void id_tipo_combustibleSpinEdit_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmTipoCombustible(Main);
                t.ShowDialog(this);
                t_TipoCombustibleTableAdapter.Fill(dSDatos.T_TipoCombustible);
            }
        }

      

        private void no_inventarioTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var edit = (TextEdit)sender;
            if (!(edit.EditValue is String))
                return;
            var validat =(int) t_EquipoTableAdapter.ScalarQuery(edit.EditValue.ToString(),edit.Tag.ToString(),Equipo.idequipo);

            
            var s = "";
            if(validat!=0)
            switch (int.Parse(edit.Tag.ToString()))
            {

                case 1: { s = "No. inventario"; break; }
                case 2: { s = "No. Carrocería"; break; }
                case 3: { s = "No. Motor"; break; }
                case 4: { s = "Matrícula"; break; }
                case 5: { s = "No. Circulación"; break; }
                case 6: { s = "No. Somatón"; break; }
                default: break;
            }

            e.Cancel = s != "";
            if (s != "")
                edit.ErrorText = s + " tiene que ser único";
            if (!e.Cancel)
                matriculaTextEdit_Properties_Validating(sender, e);
        }

        private void id_tipo_equipoSpinEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var tipoequipo = new FrmTipoEquipo(Main);
                tipoequipo.ShowDialog();
                t_CategoriaTableAdapter.Fill(dSDatos.T_Categoria);
                t_Tipo_EquipoTableAdapter.Fill(dSDatos.T_Tipo_Equipo);
            }
        }

        private void ucPieFormulario1_Load(object sender, EventArgs e)
        {

        }

        private void fecha_fabDateEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            if (fecha_fabDateEdit.EditValue is DateTime)
                e.Cancel = ((DateTime)fecha_fabDateEdit.EditValue) > DateTime.Now;
            if (e.Cancel)
                fecha_fabDateEdit.ErrorText = "La fecha de fabricación tiene que ser menor que la fecha actual.";
            fecha_fabDateEdit.Tag = e.Cancel;
        
        }

        private void matriculaTextEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = ((TextEdit)sender).Text.IndexOf("_") !=-1;
            if (e.Cancel)
                ((TextEdit)sender).ErrorText = "No se puede dejar vacio.";
        }

    }
}