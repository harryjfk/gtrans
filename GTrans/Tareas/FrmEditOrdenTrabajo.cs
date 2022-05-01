using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GTrans.Abstract;
using GTrans.Codificadores;
using DevExpress.XtraEditors.Repository;
using System.Linq;
using DevExpress.XtraLayout.Utils;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmEditOrdenTrabajo : CodificadorForm
    {
        public FrmEditOrdenTrabajo(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            HelperAdapter.DoAdapter(tableAdapterManager1);
        }
        public int edit { get; set; }
        private int _intervencion=-1;
        public int intervencion { get { return _intervencion; } set { _intervencion = value;  } }
        private int _equipo=-1;
        public int equipo { get { return _equipo; } set { _equipo = value; } }
        private void FrmEditOrdenTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Paralizado' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_ParalizadoTableAdapter.Fill(this.dSDatos.T_Tipo_Paralizado);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Paralizado' Puede moverla o quitarla según sea necesario.
            this.t_ParalizadoTableAdapter.FillBy(this.dSDatos.T_Paralizado);
         
         
        }

        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        public static void FillCombo(RepositoryItemImageComboBox edit, DSDatos dSDatos, int equipo)
        {
            edit.Items.Clear();
            edit.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Avería", -1, 0));
            foreach (var item in dSDatos.T_Planificacion)
            {
                if(equipo==-1)
                    edit.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(item.T_EquipoRow.matricula+'-'+item.T_TipoModeloMantRow.nametipomantenimiento, item.idplanificacion,0));
    
                else
                edit.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(item.T_TipoModeloMantRow.nametipomantenimiento, item.idplanificacion,0));
            }

        }
        private void FrmEditOrdenTrabajo_Shown(object sender, EventArgs e)
        {
            Tag = 0;

            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Estado' Puede moverla o quitarla según sea necesario.
            this.t_EstadoTableAdapter.Fill(this.dSDatos.T_Estado);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstadoOrden' Puede moverla o quitarla según sea necesario.
            this.t_EstadoOrdenTableAdapter.Fill(this.dSDatos.T_EstadoOrden);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empleado' Puede moverla o quitarla según sea necesario.
            this.t_EmpleadoTableAdapter.Fill(this.dSDatos.T_Empleado);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoOrden' Puede moverla o quitarla según sea necesario.
            t_CategoriaTableAdapter1.Fill(dSDatos.T_Categoria);
            t_EquipoTableAdapter1.Fill(dSDatos.T_Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoIntervecion' Puede moverla o quitarla según sea necesario.
            int? s;
            if (equipo == -1)
                s = null;
            else s = equipo;
            t_PlanificacionTableAdapter.FillByOrden(dSDatos.T_Planificacion, s);
            t_TipoModeloMantTableAdapter1.FillFull(dSDatos.T_TipoModeloMant);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenTrabajo' Puede moverla o quitarla según sea necesario.
          
            //
            var t = "";
            var ed = false;
            var i = 0;
            if (edit != -1)
                ed = true;
            if (!ed)
            {
                t = "Emitir Orden";
                i = 0;
                tOrdenTrabajoBindingSource.AddNew();
                tOrdenTrabajoBindingSource.MoveLast();
                orden.idestadoorden = 1;
                idestadoGridLookUpEdit.EditValue = 1;
                orden.idestado = 1;
                idestadoGridLookUpEdit1.EditValue = 1;
                idestadoGridLookUpEdit.Enabled = false;
                layoutControlGroup4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem12.Visibility = layoutControlGroup4.Visibility;
                if (equipo != -1)
                {
                    orden.idequipo = equipo;
                    idequipoSpinEdit.EditValue = equipo;
                }
                if(_intervencion!=-1)
                {

                    orden.idtipointervencion = _intervencion;
                    idtipointervencionSpinEdit.EditValue = _intervencion;
                    var planificacion = dSDatos.T_Planificacion.Where(p => p.idplanificacion == _intervencion).ToList();
                    if (planificacion.Count > 0)
                    {
                     
                      
                        p_PlanificarTrabajadorTableAdapter1.Fill(dSDatos.P_PlanificarTrabajador, planificacion[0].idplanificacion);
                        foreach (var item in dSDatos.P_PlanificarTrabajador)
                        {
                            var surtido = dSDatos.T_OrdenSalario.NewT_OrdenSalarioRow();
                            surtido.idempleado = item.idempleado;
                            surtido.fechainicio = item.fecha;
                            surtido.fechafinal = item.fechafin;
                            surtido.idforma = item.idformapago;
                            surtido.plan = true;
                            surtido.horasorden = item.canthoras;
                            surtido.idorden = orden.idordentrabajo;
                            surtido.tarifa = item.tarifa;
                            surtido.GetImporte();
                            dSDatos.T_OrdenSalario.AddT_OrdenSalarioRow(surtido);
                        }
                        var monedas = new DSDatosTableAdapters.T_ValeExistenciaMoneda1TableAdapter();
                         t_TipoModeloMantSurtidoTableAdapter1.FillBy(dSDatos.T_TipoModeloMantSurtido, planificacion[0].T_TipoModeloMantRow.idtipomodelomant);
                        foreach (var item in dSDatos.T_TipoModeloMantSurtido)
                        {
                            var surtido = dSDatos.T_OrdenSurtido.NewT_OrdenSurtidoRow();
                            surtido.idproducto = item.idproducto;
                            monedas.Fill(dSDatos.T_ValeExistenciaMoneda1, item.idproducto);

                            surtido.idorden = orden.idordentrabajo;
                            surtido.idclasificacion = item.idclasificacion;
                            surtido.plan = true;
                            surtido.codproducto = item.codproducto;
                            surtido.unidades = item.cant;
                           
                            dSDatos.T_OrdenSurtido.AddT_OrdenSurtidoRow(surtido);
                            foreach (var mon in dSDatos.T_ValeExistenciaMoneda1)
                            {
                                var w = dSDatos.T_OrdenSurtidoMoneda.NewT_OrdenSurtidoMonedaRow();
                                w.idmoneda  =mon.idmoneda;
                                w.idordensurtido  =surtido.idordensurtido;
                                w.precio = mon.precio;
                                dSDatos.T_OrdenSurtidoMoneda.AddT_OrdenSurtidoMonedaRow(w);

                            } surtido.GetImporte();
                        }
                        mateypiezaplanSpinEdit.EditValue = dSDatos.T_OrdenSurtido.Where(p => p.idorden == orden.idordentrabajo && p.plan).Sum(p => p.importe);
                        salarioplanSpinEdit.EditValue = dSDatos.T_OrdenSalario.Where(p => p.idorden == orden.idordentrabajo && p.plan).Sum(p => p.importe);
                   
                    }
                }
                t_OrdenTrabajoTableAdapter.Fill(dsDatos1.T_OrdenTrabajo);
                noordenSpinEdit.EditValue = dsDatos1.T_OrdenTrabajo.LastNoOrden();
            }

            else
            {
                t_OrdenTrabajoTableAdapter.FillCalculated(dSDatos.T_OrdenTrabajo,edit);
                t_OrdenSurtidoTableAdapter1.FillBy(dSDatos.T_OrdenSurtido,edit);
                t_OrdenSurtidoMonedaTableAdapter1.FillBy(dSDatos.T_OrdenSurtidoMoneda,edit);
                t_OrdenSalarioTableAdapter1.FillBy(dSDatos.T_OrdenSalario, edit);

                //foreach (var surtido in dSDatos.T_OrdenSurtido)
                //    if(!surtido.plan)
                //    surtido.GetImporte();
                //foreach (var salario in dSDatos.T_OrdenSalario)
                //    salario.GetImporte();
                var editada =
                   orden.idestado == 1;
                t = !editada ? "Seguir Orden" : "Emitir Orden";
                i = 1;
                actividadesTextEdit.Enabled = editada;

                idestadoGridLookUpEdit1.Enabled = editada;
                noordenSpinEdit.Enabled = editada;
                idtipointervencionSpinEdit.Enabled = noordenSpinEdit.Enabled;
                idequipoSpinEdit.Enabled = noordenSpinEdit.Enabled;

                idtipotrabajoSpinEdit.Enabled = noordenSpinEdit.Enabled;
                idresponsableSpinEdit.Enabled = noordenSpinEdit.Enabled;
                fechasolDateEdit.Enabled = noordenSpinEdit.Enabled;
                fechainiplanDateEdit.Enabled = noordenSpinEdit.Enabled;
                mateypiezaplanSpinEdit.Enabled = noordenSpinEdit.Enabled;
                salarioplanSpinEdit.Enabled = noordenSpinEdit.Enabled;
                mateypiezaplanSpinEdit.EditValue = dSDatos.T_OrdenSurtido.Where(p => p.idorden == orden.idordentrabajo && p.plan).Sum(p => p.importe);
                salarioplanSpinEdit.EditValue = dSDatos.T_OrdenSalario.Where(p => p.idorden == orden.idordentrabajo && p.plan).Sum(p => p.importe);
     
                //labplanSpinEdit.Enabled = noordenSpinEdit.Enabled;
                //tiempparoplanSpinEdit.Enabled = noordenSpinEdit.Enabled;
                dataLayoutControl1.Enabled = orden.idestadoorden == 1;
                if (editada)
                {
                    layoutControlGroup4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = layoutControlGroup4.Visibility;
                }
                // tOrdenTrabajoBindingSource.Filter = "idcategoria <> " + edit;
                //aqui falta buscar sus hijos para q nolos coja
            }
         
                layoutControlItem9.Visibility = orden.idestado==2?DevExpress.XtraLayout.Utils.LayoutVisibility.Always:DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem10.Visibility = layoutControlItem9.Visibility;

                ItemForfechasol.Visibility = orden.idestado == 1 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                ItemForfechainiplan.Visibility = ItemForfechasol.Visibility;

            try
            {
                fechasolDateEdit.Enabled = orden.idtipointervencion == -1;
            }
            catch (Exception w) { }
            try
            {
                fechainiplanDateEdit.Enabled = orden.idtipointervencion == -1;
            }
            catch (Exception w) { }



            Tag = 1;
            tTipoIntervecionBindingSource.Position = 1;
            toplabel.Text = t;
            toppicture.Image = imageCollection1.Images[i];
            ValidationEditarSinCon.Validate();
            dSDatos.T_OrdenSurtido.idordenColumn.DefaultValue = orden.idordentrabajo;
            dSDatos.T_OrdenSalario.idordenColumn.DefaultValue = orden.idordentrabajo;
            FillCombo(idtipointervencionSpinEdit.Properties,dSDatos,_equipo);
            if(orden.idestado!=3)
            tEstadoBindingSource.Filter = "nameestado <> 'Cancelada'";
            Loaded();

        }
        private bool Valid(object sender)
        {
            salario = false;
            bool r = false;
            if (idestadoGridLookUpEdit.EditValue == null || idestadoGridLookUpEdit1.EditValue == null)
                return r;
            if (idestadoGridLookUpEdit.EditValue.ToString() == "" || idestadoGridLookUpEdit1.EditValue.ToString() == "")
                return r;
            if (((int)idestadoGridLookUpEdit.EditValue == 1 && (int)idestadoGridLookUpEdit1.EditValue == 1) || ((int)idestadoGridLookUpEdit.EditValue == 1 && (int)idestadoGridLookUpEdit1.EditValue == 2 && !layoutControlGroup4.Visible))
            {
                r = ValidationEditarSinCon.Validate();

                //GridLookUpEdit ob = null;
                //if (r)
                //{
                //    if (textEdit6.Visible)
                //        ob = textEdit6;
                //    else
                //        ob = idtipointervencionSpinEdit;
                //    if (ob.Enabled)
                //    {
                //        ob.Focus();
                //        r = ob.DoValidate();
                //        if (sender is DevExpress.XtraEditors.BaseEdit)
                //            ((DevExpress.XtraEditors.BaseEdit) sender).Focus();
                //    }
                //}
            }
            else
                if ((int)idestadoGridLookUpEdit.EditValue == 1 && (int)idestadoGridLookUpEdit1.EditValue == 2)
                {
                    r = ValidationEditarCon.Validate();
                }
                else
                    if ((int)idestadoGridLookUpEdit.EditValue == 2 && (int)idestadoGridLookUpEdit1.EditValue == 2)
                    {
                        r = true;
                    }

            if(r)
            {
                if (orden.idestadoorden == 2)
                {
                    //if (mateypiezaplanSpinEdit.EditValue!=null && salarioplanSpinEdit.EditValue!=null)
                    //    r = mateypiezaplanSpinEdit.EditValue.ToString() != "0" && salarioplanSpinEdit.EditValue.ToString() != "0";
                    var tq=dSDatos.T_Planificacion.FindByidplanificacion(orden.idtipointervencion);
                    var f=tq==null;
                    if(!f)
                     f=tq.T_TipoModeloMantRow.idtipomant !=1;
                    if (textEdit1.EditValue != null && textEdit2.EditValue != null &&f )
                        r = textEdit1.EditValue.ToString() != "0" && textEdit2.EditValue.ToString() != "0";
            
                }
                   //else
                   //if (!r)
                    salario = r;
            }



            return r;
        }
        bool salario = false;
        private DSDatos.T_OrdenTrabajoRow orden { get { return ((DSDatos.T_OrdenTrabajoRow)((DataRowView)tOrdenTrabajoBindingSource.Current).Row); } }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dataLayoutControl1.Enabled)
            {
                if (Valid(sender))
                {
                    tOrdenTrabajoBindingSource.EndEdit();

                    if ((int)idestadoGridLookUpEdit1.EditValue == 2 && (int)idestadoGridLookUpEdit.EditValue==1)
                    {
                     tLocalizacionEquipoBindingSource.EndEdit();
                        t_EquipoTableAdapter1.Update(dSDatos.T_Equipo);
                    }
                    if ((int)idestadoGridLookUpEdit.EditValue == 2)
                    {
                        if (checkEdit1.Checked)
                            if (XtraMessageBox.Show("Está seguro que desea establecer el equipo como paralizado?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.No)
                                return;
                  
                        if (XtraMessageBox.Show("Está seguro que desea establecer esta orden como solucionada?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;

                    }
                        
                   
                    t_OrdenTrabajoTableAdapter.Update(dSDatos.T_OrdenTrabajo);
                   /* if (edit == -1)
                    {*/
                        foreach (var item in dSDatos.T_OrdenSurtido)
                            if (item.RowState != DataRowState.Deleted) if (item.idorden != orden.idordentrabajo)
                                item.idorden = orden.idordentrabajo;
                        foreach (var item in dSDatos.T_OrdenSalario)
                             if(item.RowState!=DataRowState.Deleted)
                            if (item.idorden != orden.idordentrabajo)
                                item.idorden = orden.idordentrabajo;

              /*   }*/

                    tableAdapterManager.UpdateAll(dSDatos);
                    t_OrdenSalarioTableAdapter1.Update(dSDatos.T_OrdenSalario);
                  //  if ((int)idestadoGridLookUpEdit.EditValue == 2 && orden.idestado ==2 &&idestadoGridLookUpEdit.Enabled)
                   // t_OrdenTrabajoTableAdapter.P_OrdenState(orden.idordentrabajo);
                    DialogResult = DialogResult.OK;
                    Close();

                }
                else
                    if(!salario)
                        XtraMessageBox.Show("Rellene valores de salario y/o materiales vacio.");
       
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

       
        private void fechainiplanDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Valid(sender);
            if (sender == idequipoSpinEdit)
            {
                if (idequipoSpinEdit.EditValue is int)
                    tLocalizacionEquipoBindingSource.Position = tLocalizacionEquipoBindingSource.Find("idequipo",int.Parse(idequipoSpinEdit.EditValue.ToString()));

                // dSDatos.T_Localizacion_Equipo.  FindByidlocalizacionequipo(int.Parse(idequipoSpinEdit.EditValue.ToString()));
            }
          
          
        }

        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!(idtipointervencionSpinEdit.EditValue is int))
            {
                XtraMessageBox.Show("Debe seleccionar primero una intervención");
                return;
            }
            var valores = new FrmEditRealOrdenTrabajo(Main);
            valores.orden = edit;
            valores.fechaorden = fechainiplanDateEdit.EditValue;
            valores.DataSet = dSDatos;
            if (sender == textEdit1 || sender == mateypiezaplanSpinEdit)
            {
              
                valores.plan = sender == mateypiezaplanSpinEdit;
                valores.intervencion = (int)idtipointervencionSpinEdit.EditValue;
                valores.TypeForm = FormsType.Surtido;
            }

            else
                if (sender == textEdit2 || sender == salarioplanSpinEdit)
                {
                    valores.plan = sender == salarioplanSpinEdit;
                    valores.TypeForm = FormsType.Salario;
                }


            var fechainireal = dateEdit1.EditValue;
            var fechaterminacion = dateEdit2.EditValue;
            //var lab = textEdit3.EditValue;
            //var tiempopar = textEdit5.EditValue;
            var memo = memoEdit1.EditValue;
            valores.ShowDialog(this) ;
   
            if (!(mateypiezaplanSpinEdit.EditValue is decimal))
                mateypiezaplanSpinEdit.EditValue = dSDatos.T_OrdenSurtido.Where(p => p.RowState != DataRowState.Deleted).Where(p => p.idorden == orden.idordentrabajo && p.plan).Sum(p => p.importe);
            salarioplanSpinEdit.EditValue = dSDatos.T_OrdenSalario.Where(p=>p.RowState!=DataRowState.Deleted).Where(p => p.idorden == orden.idordentrabajo && p.plan).Sum(p => p.importe);
            textEdit1.EditValue = dSDatos.T_OrdenSurtido.Where(p => p.RowState != DataRowState.Deleted).Where(p => p.idorden == orden.idordentrabajo && !p.plan).Sum(p => p.importe);
            textEdit2.EditValue = dSDatos.T_OrdenSalario.Where(p => p.RowState != DataRowState.Deleted).Where(p => p.idorden == orden.idordentrabajo && !p.plan).Sum(p => p.importe); ;
            dateEdit1.EditValue = fechainireal;
            dateEdit2.EditValue = fechaterminacion;
            //textEdit3.EditValue = lab;
            //textEdit5.EditValue = tiempopar;
            memoEdit1.EditValue = memo;
            //fechainiplanDateEdit_EditValueChanged(textEdit6, null);
        }

   

        private void idestadoGridLookUpEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if ((int)e.NewValue == 2 && orden.idestado == 1)
            {
                XtraMessageBox.Show("No se puede cambiar de estado sin confirmar el anterior", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            //if (orden.idestado == 2)
            //    e.Cancel = false;
            //else
            //    if(orden.idestadoorden==1 && orden.idestado
        }
        private void idequipoSpinEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue is int)
            if(dSDatos.T_OrdenTrabajo.Where(item=>item != orden && item.idequipo == (int)e.NewValue && item.idestadoorden == 1).ToList().Count>0    )
            {
                XtraMessageBox.Show("No se puede emitir una orden a un equipo que ya tiene una orden emitida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        
        private void idtipointervencionSpinEdit_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = idtipointervencionSpinEdit.EditValue.ToString() == "";
        }

        private void noordenSpinEdit_Validating(object sender, CancelEventArgs e)
        {
            orden.Table.DefaultView.Sort = "noorden";
            e.Cancel =orden.Table.DefaultView.Find(noordenSpinEdit.EditValue.ToString())!=-1;
            if (e.Cancel)
            noordenSpinEdit.ErrorText = "Ya existe una orden con ese No. de orden";
        }

        private void idresponsableSpinEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void idresponsableSpinEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var tipos = new FrmEmpleado(Main);
                if (tipos.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    t_EmpleadoTableAdapter.Fill(dSDatos.T_Empleado);

            }
        }

        private void dateEdit1_Validating(object sender, CancelEventArgs e)
        {
            var c = false;
            try
            {
                c = ((DateTime)fechainiplanDateEdit.EditValue) > ((DateTime)dateEdit1.EditValue);
                if (c)
                    fechainiplanDateEdit.ErrorText = "Defina la fecha inicial menor o igual que la fecha inicial real";
      
            }
            catch (Exception)
            {
                if (!(dateEdit1.EditValue is DateTime))
                {
                    c = false;
                }
                else
                if (fechainiplanDateEdit.EditValue== null)
                {
                    c = true;
                    fechainiplanDateEdit.ErrorText = "Defina la fecha de solicitud menor o igual que la fecha planificada";
                }
                else
                    c = true;
            }
            e.Cancel = c;
        }

        private void dateEdit2_Validating(object sender, CancelEventArgs e)
        {
            var c = false;
            try
            {
                c = ((DateTime)dateEdit1.EditValue) > ((DateTime)dateEdit2.EditValue);
                if (c)
                    dateEdit2.ErrorText = "Defina la fecha final mayor o igual que la fecha inicial real";
      
            }
            catch (Exception)
            {
                if (!(dateEdit2.EditValue is DateTime))
                {
                    c = false;
                }
                else
                if (!(dateEdit1.EditValue  is DateTime))
                {
                    c = true;
                    dateEdit2.ErrorText = "Defina la fecha de solicitud menor o igual que la fecha planificada";
          
                }
                   
                else
                    c = false;
            }
            e.Cancel = c;
        }

        private void fechainiplanDateEdit_Validating(object sender, CancelEventArgs e)
        {
            var c = false;
            try
            {
                c = ((DateTime)fechasolDateEdit.EditValue) > ((DateTime)fechainiplanDateEdit.EditValue);
                if(c)
                fechainiplanDateEdit.ErrorText = "Defina la fecha de solicitud menor o igual que la fecha planificada";
            }
            catch (Exception)
            {
                if(!( fechainiplanDateEdit.EditValue is DateTime))
                {
                    c=false;
                } else
                if (!(fechasolDateEdit.EditValue is DateTime ))
                {
                       c = true;
                     
                      fechainiplanDateEdit.ErrorText = "Defina la fecha de solicitud menor o igual que la fecha planificada";
                }
                 
                else
                    c = false;
            }
            e.Cancel = c;
        }

        private void idtipotrabajoSpinEdit_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void idtipotrabajoSpinEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmTipoTrabajo(Main);
                t.ShowDialog(this);
                t_TipoTrabajoTableAdapter.Fill(dSDatos.T_TipoTrabajo);
            }
           
        }

        private void idequipoSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(idequipoSpinEdit.EditValue is int)
            {
                _equipo = (int)idequipoSpinEdit.EditValue;
                t_PlanificacionTableAdapter.FillByOrden(dSDatos.T_Planificacion,_equipo );
                FillCombo(idtipointervencionSpinEdit.Properties,dSDatos,_equipo);
                tLocalizacionEquipoBindingSource.Position = tLocalizacionEquipoBindingSource.Find("idequipo", idequipoSpinEdit.EditValue);
            }
               
        }

        private void idtipointervencionSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(idtipointervencionSpinEdit.EditValue is int)
            {
                var t = (int)idtipointervencionSpinEdit.EditValue;
                if(t!=-1)
                {
                    var s = new List<String>();
                    var p = dSDatos.T_Planificacion.FindByidplanificacion(t);
                    t_TipoModeloAccionTableAdapter1.FillBy(dSDatos.T_TipoModeloAccion,p.idmodelomant,"2");
                    foreach (var f in p.T_TipoModeloMantRow.GetT_TipoModeloAccionRows())
                        s.Add(f.nameaccion);
                    actividadesTextEdit.Lines = s.ToArray();
                    fechasolDateEdit.EditValue = p.fecha;
                    fechainiplanDateEdit.EditValue = p.fecha;
                }
            }
        }

        private void gridLookUpEdit1_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmParalizado(Main);
                t.ShowDialog(this);
                t_ParalizadoTableAdapter.FillBy(dSDatos.T_Paralizado);
            }
           
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            layoutControlItem2.Visibility = checkEdit1.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void tLocalizacionEquipoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            checkEdit1_CheckedChanged(null, null);
        }
    }
}