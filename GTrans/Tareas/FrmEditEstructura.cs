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
    public partial class FrmEditEstructura : SaveableForm
    {
        private int _edit;
        public int idparent { get; set; }
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
                            text += "Marca";
                            if (edit != -1)
                                this.t_MarcaTableAdapter.FillBy(this.dSDatos.T_Marca, edit);
                            else {
                                dSDatos.T_Marca.idtipomarcaColumn.DefaultValue = 1;
                                tMarcaBindingSource.AddNew(); }
                            break;
                        }
                    case 1:
                        {
                            text += "Modelo";
                            this.t_MarcaTableAdapter.FillBy1(this.dSDatos.T_Marca,1);
                            FillTipo();
                            if (edit != -1)
                            {
                                this.t_ModeloTableAdapter.FillBy(this.dSDatos.T_Modelo, edit);
                                dSDatos.T_TipoModeloMant.idmodeloColumn.DefaultValue = edit;
                                t_TipoModeloMantTableAdapter.FillBy1(dSDatos.T_TipoModeloMant, edit);
                            }

                            else
                            {

                                if (idparent != -1)
                                    dSDatos.T_Modelo.idmarcaColumn.DefaultValue = idparent;
                                tModeloBindingSource.AddNew();
                                if (idparent != -1)
                                    idmarcaSpinEdit.EditValue = idparent;
                            }
                            break;
                        }
                    case 2:
                        {
                            text += "Tipo de Mantenimiento";
                            this.t_ModeloTableAdapter.Fill(this.dSDatos.T_Modelo);
                            if (edit != -1)
                            {

                                this.t_TipoModeloMantTableAdapter.FillBy(this.dSDatos.T_TipoModeloMant, edit);
                                dSDatos.T_TipoModeloMantTrab.idtipomodelmantColumn.DefaultValue = edit;
                                dSDatos.T_TipoModeloMantSurtido.idtipomodelomantColumn.DefaultValue = edit;
                                t_TipoModeloMantSurtidoTableAdapter.FillBy(dSDatos.T_TipoModeloMantSurtido, edit);
                                t_TipoModeloMantTrabTableAdapter.FillBy(dSDatos.T_TipoModeloMantTrab, edit);

                            }
                                
                            else
                            {
                                dSDatos.T_TipoModeloMantTrab.idtipomodelmantColumn.DefaultValue = -1;
                                dSDatos.T_TipoModeloMantSurtido.idtipomodelomantColumn.DefaultValue = -1;
                                if (idparent != -1)
                                    dSDatos.T_TipoModeloMant.idmodeloColumn.DefaultValue = idparent;
                                tTipoModeloMantBindingSource.AddNew();
                                if (idparent != -1)
                                    idmodeloSpinEdit.EditValue = idparent;


                            }
                            break;
                        }
                    case 3:
                        {
                            text += "Acción";
                            t_TipoModeloMantTableAdapter.FillFull(dSDatos.T_TipoModeloMant);
                            if (edit != -1)
                                t_TipoModeloAccionTableAdapter.FillBy(dSDatos.T_TipoModeloAccion, edit, "-1");
                            else
                            {
                                if (idparent != -1)
                                dSDatos.T_TipoModeloAccion.idtipomodelomantColumn.DefaultValue = idparent;
                                tTipoModeloAccionBindingSource.AddNew();
                                if (idparent != -1)
                                    Accion.idtipomodelomant = idparent;
                            }

                            break;
                        }
                    default: break;

                }
                Text = text;
                toplabel.Text = text;
            }
        }
        public DSDatos.T_TipoModeloAccionRow Accion { get { return (DSDatos.T_TipoModeloAccionRow)(((DataRowView)tTipoModeloAccionBindingSource.Current).Row); } }

        public DSDatos.T_ModeloRow Modelo { get { return (DSDatos.T_ModeloRow)(((DataRowView)tModeloBindingSource.Current).Row); } }
        private int _type;
        public int type
        {
            get { return _type; }
            set
            {
                _type = value;
                marcalayout.Visible = type == 0;
                modelolayout.Visible = type == 1;
                tipomantlayout.Visible = type == 2;
                accionlayout.Visible = type == 3;

                switch (_type)
                {
                    case 0: { Height = 154; break; }
                    case 1: { Height = 270; break; }
                    case 2: { Height = 400; break; }
                    case 3: { Height = 240; break; }
                    default: break;
                }

            }
        }
        public FrmEditEstructura()
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }

        private void FrmEditEstructura_Load(object sender, EventArgs e)
        {
            t_ClasificacionTableAdapter1.Fill(dSDatos.T_Clasificacion);
            t_UMTableAdapter1.Fill(dSDatos.T_UM);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoModeloMantTrab' Puede moverla o quitarla según sea necesario.
            //this.t_TipoModeloMantTrabTableAdapter.Fill(this.dSDatos.T_TipoModeloMantTrab);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Producto' Puede moverla o quitarla según sea necesario.
            this.t_ProductoTableAdapter.FillBy(this.dSDatos.T_Producto,-1,"-1");
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoModeloMantSurtido' Puede moverla o quitarla según sea necesario.
            //this.t_TipoModeloMantSurtidoTableAdapter.Fill(this.dSDatos.T_TipoModeloMantSurtido);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_GrupoAccion' Puede moverla o quitarla según sea necesario.
            this.t_GrupoAccionTableAdapter.Fill(this.dSDatos.T_GrupoAccion);

        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate() && dxValidationProvider2.Validate() )
            {
                switch (type)
                {
                    case 0: { tMarcaBindingSource.EndEdit(); t_MarcaTableAdapter.Update(dSDatos.T_Marca); break; }
                    case 1:
                        {
                            tModeloBindingSource.EndEdit(); t_ModeloTableAdapter.Update(dSDatos.T_Modelo);
                            if (edit == -1)
                                foreach (var t in dSDatos.T_TipoModeloMant)
                                    t.idmodelo = Modelo.idmodelo;
                            t_TipoModeloMantTableAdapter.Update(dSDatos.T_TipoModeloMant);
                            break;
                        }
                    case 2:
                        {
                            tTipoModeloMantBindingSource.EndEdit();
                            t_TipoModeloMantTableAdapter.Update(dSDatos.T_TipoModeloMant);

                            if (edit==-1)
                            {
                                foreach (var item in dSDatos.T_TipoModeloMantSurtido)
                                    if (item.idtipomodelomant == -1)
                                        item.idtipomodelomant = TipoMantimiento.idtipomodelomant;
                                foreach (var item in dSDatos.T_TipoModeloMantTrab)
                                    if (item.idtipomodelmant == -1)
                                        item.idtipomodelmant = TipoMantimiento.idtipomodelomant;

                            }

                            t_TipoModeloMantTrabTableAdapter.Update(dSDatos.T_TipoModeloMantTrab);
                            t_TipoModeloMantSurtidoTableAdapter.Update(dSDatos.T_TipoModeloMantSurtido);

                            break;
                        }
                    case 3:
                        {
                            tTipoModeloAccionBindingSource.EndEdit();
                            t_TipoModeloAccionTableAdapter.Update(dSDatos.T_TipoModeloAccion);
                            break;
                        }
                    default: break;
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
        private DSDatos.T_TipoModeloMantRow TipoMantimiento { get { return (DSDatos.T_TipoModeloMantRow)((DataRowView)tTipoModeloMantBindingSource.Current).Row; } }
        private void idtipomantSpinEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmTipoMantenimiento(Main);
                t.ShowDialog(this);
                FillTipo();


                t.Dispose();
            }
        }
        private void FillTipo()
        {
            //if (idmodeloSpinEdit.EditValue is int)
            //    if ((int)idmodeloSpinEdit.EditValue != -1)
            //    {
            //        var w = -1;
            //        if (edit != -1)
            //            w = TipoMantimiento.idtipomant;
                //    this.t_TipoMantenimientoTableAdapter.FillBy(this.dSDatos.T_TipoMantenimiento,w, (int)idmodeloSpinEdit.EditValue);
                    this.t_TipoMantenimientoTableAdapter.Fill(this.dSDatos.T_TipoMantenimiento);

                //}
        }

        private void idmodeloSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            FillTipo();
        }

        private void treeListLookUpEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var s = new FrmGrupoAcciones(Main);
                s.ShowDialog(this);
                t_GrupoAccionTableAdapter.Fill(dSDatos.T_GrupoAccion);
                s.Dispose();

            }
        }

        private void gridView5_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DSDatos.T_TipoModeloMantSurtidoRow row = (DSDatos.T_TipoModeloMantSurtidoRow)((DataRowView)e.Row).Row;

            if ((row.cant < 0) || (row.cant > 999000))
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo cantidad.\n";
            }
        }
           

        private void gridView6_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DSDatos.T_TipoModeloMantTrabRow row = (DSDatos.T_TipoModeloMantTrabRow)((DataRowView)e.Row).Row;

            if ((row.canthoras < 0) || (row.canthoras > 999000))
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo cantidad de horas.\n";
            }
            else
            {
                try
                {
                  //  var s = Sumcantidad();
                    var c = TipoMantimiento.cantdays * 8;
                       foreach (var i in tTipoModeloMantTrabBindingSource)
       if( ((DSDatos.T_TipoModeloMantTrabRow)((DataRowView)i).Row).canthoras>c)
       {
          e.Valid = false;

           e.ErrorText += "Debe entrar una cantidad de horas por tipo de trabajo menor que la del tipo de mantenimiento.\n";
           break;           
       }



                   }
                catch (Exception w) { MessageBox.Show("Defina la cantidad de dias a trabajar."); }
               
            }
        }
    }
}