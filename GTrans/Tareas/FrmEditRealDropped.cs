using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GTrans.Abstract;
using DevExpress.XtraLayout.Utils;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmEditRealDropped : CodificadorForm
    {
        public FrmEditRealDropped(FrmMain main)
          : base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }

        public int edit;
        public int orden;
        public object temp;
        private DSDatos.T_OrdenSalarioRow SalarioRow { get
        {
            if(tOrdenSalarioBindingSource.Current!=null)

            return (DSDatos.T_OrdenSalarioRow) (((DataRowView)tOrdenSalarioBindingSource.Current).Row);
            return null;
        } }
      
        public DSDatos.T_OrdenSurtidoRow SurtidoRow
        {
            get
            {
                if (tOrdenSurtidoBindingSource.Current != null)

                    return (DSDatos.T_OrdenSurtidoRow)(((DataRowView)tOrdenSurtidoBindingSource.Current).Row);
                return null;
            }
        }
        public int intervencio { get; set; }
        private bool HasVale()
        {
            if (intervencio == -1 )
                
                return !plan;

            return !plan && dSDatos.T_Planificacion.FindByidplanificacion(intervencio).T_TipoModeloMantRow.T_TipoMantenimientoRow.idtipomantenimiento != 1;
        }
        public FormsType TypeForm
        {
            
            
            set
            {
                SetTitleInfo((Bitmap)imageCollection1.Images[0], "", "");
              
                switch (value)
                {
                    case FormsType.Surtido:
                        {
                            t_PlanificacionTableAdapter1.Fill(dSDatos.T_Planificacion);
                            t_TipoMantenimientoTableAdapter1.Fill(dSDatos.T_TipoMantenimiento);
                            t_TipoModeloMantTableAdapter1.Fill(dSDatos.T_TipoModeloMant);
                            t_AlmacenTableAdapter1.Fill(dSDatos.T_Almacen);
                            t_AlmacenExistenciaTableAdapter.FillBy1(dSDatos.T_AlmacenExistencia, 2);
                            //t_ValeExistenciaMonedaTableAdapter1.Fill(((DSDatos)((DSDatos.T_ValeExistenciaRow)temp).Table.DataSet).T_ValeExistenciaMoneda);
                            this.t_OrdenSurtidoTableAdapter.Fill(this.dSDatos.T_OrdenSurtido);
                            this.t_OrdenSurtidoMonedaTableAdapter.Fill(this.dSDatos.T_OrdenSurtidoMoneda);
                            t_ClasificacionTableAdapter1.Fill(dSDatos.T_Clasificacion);
                            t_UMTableAdapter1.Fill(dSDatos.T_UM);
                            tOrdenSurtidoBindingSource.DataSource = dataSet;

                            if (edit == -1)
                            {
                                Text = @"Adicionar costo de materiales y piezas";

                                tOrdenSurtidoBindingSource.AddNew();
                                tOrdenSurtidoBindingSource.MoveLast();
                                SurtidoRow.idproducto = ((DSDatos.P_OrdenSurtidoRow)temp).idproducto;
                                
                               SurtidoRow.idclasificacion = ((DSDatos.P_OrdenSurtidoRow)temp).idclasificacion.ToString();
                                SurtidoRow.unidades = 1;
                                SurtidoRow.plan = plan;
                                SurtidoRow.codproducto = ((DSDatos.P_OrdenSurtidoRow)temp).codproducto;
                                //SurtidoRow.valesal = "";
                                SurtidoRow.idorden = orden;
                               
                             
                            }
                            else
                            {
                                Text = @"Editar costo de materiales y piezas";
                                tOrdenSurtidoBindingSource.Filter = "idordensurtido = " + edit;
                                // tOrdenSalarioBindingSource.AddNew();
                            } tOrdenSurtidoBindingSource.EndEdit();
                          //  dSDatos.T_OrdenSurtidoMoneda.idordensurtidoColumn.DefaultValue = SurtidoRow.idordensurtido;
                            SurtidoRow.plan = plan;
                            nameproducto.Text = ((DSDatos.P_OrdenSurtidoRow)temp).descproducto;
                            dSDatos.T_Clasificacion.DefaultView.RowFilter = "idclasificacion = " +
                                                                            ((DSDatos.P_OrdenSurtidoRow)temp).
                                                                           idclasificacion;
                            nameclasificacion.Text = ((DSDatos.T_ClasificacionRow)dSDatos.T_Clasificacion.DefaultView[0].Row).nameclasificacion;
                            dSDatos.T_UM.DefaultView.RowFilter = "idum = " +
                                                                 ((DSDatos.P_OrdenSurtidoRow)temp).idum;

                            nameum.Text = ((DSDatos.T_UMRow)dSDatos.T_UM.DefaultView[0].Row).nameum;
                            
                 
                            ItemForvalesal.Visibility = HasVale()? LayoutVisibility.Always : LayoutVisibility.Never;
                            xtraTabControl1.SelectedTabPageIndex = 0;
                            break;
                        
                        }
                   
                    case FormsType.Salario:
                        {
                            tOrdenSalarioBindingSource.DataSource = dataSet;
                            //this.t_OrdenSalarioTableAdapter.Fill(this.dSDatos.T_OrdenSalario);
                            if (edit == -1)
                            {
                                Text = @"Adicionar costo de mano de obra";
                                tOrdenSalarioBindingSource.AddNew();
                                tOrdenSalarioBindingSource.MoveLast();
                                SalarioRow.idempleado = ((DSDatos.T_Empleado1Row)temp).idempleado;
                                SalarioRow.idforma = ((DSDatos.T_Empleado1Row)temp).idformapago;
                               // frmpagolabel.Text = ((DSDatos.T_Empleado1Row)temp).nameformapago;
                              //  idempleadolabel.Text = ((DSDatos.T_Empleado1Row)temp).nameempleado;
                                SalarioRow.tarifa = ((DSDatos.T_Empleado1Row)temp).tarifa;
                                SalarioRow.fechafinal = DateTime.Now;
                                SalarioRow.fechainicio = DateTime.Now;
                                SalarioRow.idorden = orden;
                                fechafinalDateEdit.EditValue = SalarioRow.fechafinal;

                                fechainicioDateEdit.EditValue = SalarioRow.fechainicio;
                           
               }
                            else
                            {
                                Text = @"Editar costo de mano de obra";
                                tOrdenSalarioBindingSource.Filter = "idordensalario = " + edit;
                                // tOrdenSalarioBindingSource.AddNew();
                            }
                            fechafinalDateEdit_Properties_EditValueChanged(fechafinalDateEdit, null);
                            SalarioRow.plan = plan;
                            idempleadolabel.Text = ((DSDatos.T_Empleado1Row)temp).nameempleado;
                            frmpagolabel.Text = ((DSDatos.T_Empleado1Row)temp).nameformapago;
                                xtraTabControl1.SelectedTabPageIndex = 1;
                            break;
                        }
                  

                }

              toplabel.Text = Text;
            }
        }

        private void FrmEditRealDropped_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AlmacenExistencia' Puede moverla o quitarla según sea necesario.
            //this.t_AlmacenExistenciaTableAdapter.FillBy(this.dSDatos.T_AlmacenExistencia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
            this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenSurtidoMoneda' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AlmacenExistencia' Puede moverla o quitarla según sea necesario.
            //this.t_AlmacenExistenciaTableAdapter.Fill(this.dSDatos.T_AlmacenExistencia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenSurtido' Puede moverla o quitarla según sea necesario.
             // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenContratacion' Puede moverla o quitarla según sea necesario.
     
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenSalario' Puede moverla o quitarla según sea necesario.
          Loaded();
        }

        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 0:
                    if (ValidationSurtido.Validate())
                    {
                        if (dataSet.T_OrdenSurtidoMoneda.Count==0)
                        {
                            XtraMessageBox.Show("Por favor introduzca al menos un precio con su correspondiente moneda");
                            return;
                        }
                        tOrdenSurtidoBindingSource.EndEdit();
                        fKTOrdenSurtidoMonedaTOrdenSurtidoBindingSource.EndEdit();
                   //     t_OrdenSurtidoTableAdapter.Update(dSDatos.T_OrdenSurtido);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    break;
                case 1:
                    if (ValidationSalario.Validate()&& dxValidationProvider1.Validate())
                    {
                        tOrdenSalarioBindingSource.EndEdit();
                        t_OrdenSalarioTableAdapter.Update(dSDatos.T_OrdenSalario);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    break;

            }
        }

        private void fechafinalDateEdit_Validating(object sender, CancelEventArgs e)
        {
            var c = false;
            try
            {
                c = ((DateTime)fechainicioDateEdit.EditValue) > ((DateTime)fechafinalDateEdit.EditValue);
            }
            catch (Exception)
            {
                if (fechainicioDateEdit.EditValue is DateTime)
                    c = true;
                else
                    c = false;
            }
            e.Cancel = c;
        }

        public DSDatos dataSet
        {
            get;
            set
            
                ;
      
        }

        public bool plan { get; set; }

        private void CodifcadorPieFormulario_Cancelar(object sender, ACINOX.Components.CancelarArgs e)
        {
            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 0:
                
                    {

                        if (edit == -1 &&DialogResult!=System.Windows.Forms.DialogResult.OK)
                            if (SurtidoRow != null)
                            {

                                SurtidoRow.Delete();
                                edit = -2;
                            }
                       // tOrdenSurtidoBindingSource.CancelEdit();
              
                    }
                    break;
                case 1:
                    if (ValidationSalario.Validate())
                    {
                        //tOrdenSalarioBindingSource.EndEdit();
                        //t_OrdenSalarioTableAdapter.Update(dSDatos.T_OrdenSalario);
                        //DialogResult = DialogResult.OK;
                        //Close();
                    }
                    break;

            }
        }



        private void valesalTextEdit_EditValueChanged(object sender, EventArgs e)
        {
             if (valesalTextEdit.EditValue is int)
             {
                 //if (SurtidoRow.valesal == (int)valesalTextEdit.EditValue)
                 //    return;
                 SurtidoRow.valesal = (int)valesalTextEdit.EditValue;
                 dSDatos.T_ValeExistenciaMoneda.Clear();
                 t_ValeExistenciaTableAdapter1.FillBy(dSDatos.T_ValeExistencia, SurtidoRow.valesal);
                 t_ValeExistenciaMonedaTableAdapter1.FillBy(dSDatos.T_ValeExistenciaMoneda, SurtidoRow.valesal);

                 
                 
                 foreach (var item in dSDatos.T_ValeExistenciaMoneda)
                 {
                     var w = dataSet.T_OrdenSurtidoMoneda.Where(p => p.idmoneda == item.idmoneda && p.idordensurtido == SurtidoRow.idordensurtido).AsDataView();

                     foreach (DataRowView f in w)
                         dataSet.T_OrdenSurtidoMoneda.RemoveT_OrdenSurtidoMonedaRow((DSDatos.T_OrdenSurtidoMonedaRow) f.Row);


                         var t = dataSet.T_OrdenSurtidoMoneda.NewT_OrdenSurtidoMonedaRow();
                         t.precio = item.precio;
                         t.idmoneda = item.idmoneda;
                         t.idordensurtido = SurtidoRow.idordensurtido;
                         dataSet.T_OrdenSurtidoMoneda.AddT_OrdenSurtidoMonedaRow(t);
                     

                 }


             }
        }

        private void FrmEditRealDropped_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            CodifcadorPieFormulario_Cancelar(sender, null);
        }
        public object fechaorden { get; set; }
        private void fechainicioDateEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (fechaorden == null);
            if (e.Cancel)
                fechainicioDateEdit.ErrorText = "Por favor defina fecha de inicio en la orden de trabajo";
            else
            {
                if (fechainicioDateEdit.EditValue is DateTime)
                {
                    e.Cancel = (DateTime)fechaorden > ((DateTime)fechainicioDateEdit.EditValue);
                    if (e.Cancel)
                        fechainicioDateEdit.ErrorText = "La fecha no puede ser menor que la fecha de incio de la orden";
                }
                else
                {
                    e.Cancel = false;
                    fechainicioDateEdit.ErrorText = "Por favor defina fecha de inicio";
                }
            }

        }

        private void unidadesSpinEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var s = ItemForvalesal.Visible ;
                if (s)
                    s = !(valesalTextEdit.EditValue is int);
                e.Cancel =s ;
                if (e.Cancel)
                    unidadesSpinEdit.ErrorText = "Por favor defina el vale de salida";
                else
                    if (!plan || dSDatos.T_Planificacion.FindByidplanificacion(SurtidoRow.T_OrdenTrabajoRow.idtipointervencion).T_TipoModeloMantRow.T_TipoMantenimientoRow.idtipomantenimiento != 1)
                    {
                        dSDatos.T_ValeExistenciaMoneda.Clear();

                        t_ValeExistenciaTableAdapter1.FillBy(dSDatos.T_ValeExistencia, SurtidoRow.valesal);
                        t_ValeExistenciaMonedaTableAdapter1.FillBy(dSDatos.T_ValeExistenciaMoneda, SurtidoRow.valesal);
                        double r = 0.0;
                        foreach (var i in dSDatos.T_ValeExistencia)
                            r += i.existencia;
                        var value = double.Parse(unidadesSpinEdit.EditValue.ToString());
                        e.Cancel = value > r;
                        if (e.Cancel)
                            unidadesSpinEdit.ErrorText = "La cantidad tiene que ser menor que la del vale de salida";

                        else
                            if (r > value)
                                if (MessageBox.Show("Esta seguro que desea establecer la cantidad de unidades menor que la extraida en el vale de salida?", "Menor valor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                                    e.Cancel = true;

                    
                    }
            }
            catch (Exception we)
            {
                

                    if (we is StrongTypingException)
                    { e.Cancel =!HasVale();
                        if (e.Cancel)
                        
                        unidadesSpinEdit.ErrorText = "Por favor defina el vale de salida";
                        
                    }
            }
        }


        private void fechafinalDateEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (fechainicioDateEdit.EditValue is DateTime && fechafinalDateEdit.EditValue is DateTime)
            {
                var t = (((DateTime)fechafinalDateEdit.EditValue) - ((DateTime)fechainicioDateEdit.EditValue));
                int v = 0;
                 v = Math.Abs(t.Hours);
                if (t.Days>0)
                   v = v+(t.Days*8);
                if (v == 0)
                    v = 1;
                horasordenSpinEdit.EditValue = Math.Abs(v);
                SalarioRow.horasorden =Math.Abs( v);
            
            }
        }
    }
}