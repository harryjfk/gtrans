using ACINOX.DBT.DSDllTableAdapters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using GTrans.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GTrans.Tareas
{
    public partial class FrmOrdenTrabajo : SaveableForm
    {
        public FrmOrdenTrabajo(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager);
        }

  
        private void FrmOrdenTrabajo_Load(object sender, EventArgs e)
        {
           
            t_CategoriaTableAdapter1.Fill(dSDatos.T_Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_EquipoTableAdapter.Fill(this.dSDatos.T_Equipo);

            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Intervencion' Puede moverla o quitarla según sea necesario.
          
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Estado' Puede moverla o quitarla según sea necesario.
            this.t_EstadoTableAdapter.Fill(this.dSDatos.T_Estado);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Localizacion_Equipo' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_EstadoOrden' Puede moverla o quitarla según sea necesario.
            this.t_EstadoOrdenTableAdapter.Fill(this.dSDatos.T_EstadoOrden);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empleado' Puede moverla o quitarla según sea necesario.
            this.t_EmpleadoTableAdapter.Fill(this.dSDatos.T_Empleado);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoOrden' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoIntervecion' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_OrdenTrabajoTableAdapter.Fill(this.dSDatos.T_OrdenTrabajo);
            t_TipoModeloMantTableAdapter1.FillFull(dSDatos.T_TipoModeloMant);
            t_OrdenTrabajoBindingSource_CurrentChanged(t_OrdenTrabajoBindingSource, null);
          
                SetCombo( idtipoordenSpinEdit.Properties);
            Loaded();
        }

        public void CreateNewOrden(int equipo, int type=-1)
        {
            var edit = new FrmEditOrdenTrabajo(Main);

            var t = t_OrdenTrabajoTableAdapter.GetDataByPLan(type);
            if (t.Count==0 ||type==-1)
            {
                if (equipo != -1)
                    edit.equipo = equipo;
                edit.edit = -1;
                if (type != -1)
                {
                    edit.intervencion = type;

                }

            }
            else
                edit.edit = t[0].idordentrabajo;
            if (edit.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.t_OrdenTrabajoTableAdapter.Fill(this.dSDatos.T_OrdenTrabajo);

            }
            edit.Dispose();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CreateNewOrden(equipo != null ? equipo.idequipo : -1);  
        }
        private DSDatos.T_EquipoRow _equipo=null;
        public DSDatos.T_EquipoRow equipo
        {
            get { return _equipo; }
            set
            {
                _equipo = value;
                t_OrdenTrabajoBindingSource.Filter = " idequipo = " + value.idequipo + " and idestado = 2";
                if (t_OrdenTrabajoBindingSource.Count > 0)
                {
                    t_OrdenTrabajoBindingSource.MoveLast();
                    var last = (DSDatos.T_OrdenTrabajoRow)(((DataRowView)t_OrdenTrabajoBindingSource.Current).Row);
                    if (last.idestadoorden == 1)
                        barButtonItem2_ItemClick(barButtonItem2, null);
                    else
                        barButtonItem1_ItemClick(barButtonItem1, null);
                }

                else
                    barButtonItem1_ItemClick(barButtonItem1, null);
                t_OrdenTrabajoBindingSource.Filter = "";
                t_OrdenTrabajoBindingSource_CurrentChanged(t_OrdenTrabajoBindingSource, null);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var edit = new FrmEditOrdenTrabajo(Main);
            if (equipo != null)
                edit.equipo = equipo.idequipo;
            edit.edit =
          orden.idordentrabajo;

            if (edit.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var s = t_OrdenTrabajoBindingSource.Position;
                this.t_OrdenTrabajoTableAdapter.Fill(this.dSDatos.T_OrdenTrabajo);
                t_OrdenTrabajoBindingSource.Position =s;
            }
        }
        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }

        private void t_OrdenTrabajoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            barButtonItem2.Enabled = t_OrdenTrabajoBindingSource.Count > 0;
            barButtonItem3.Enabled = barButtonItem2.Enabled? orden.idestado!=3:false;
        }
        private DSDatos.T_OrdenTrabajoRow orden { get { return ((DSDatos.T_OrdenTrabajoRow)((DataRowView)t_OrdenTrabajoBindingSource.Current).Row); 
            //t_OrdenTrabajoBindingSource_CurrentChanged(t_OrdenTrabajoBindingSource, null); 
        } }
      
        private void t_OrdenTrabajoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (t_OrdenTrabajoBindingSource.Count != 0)
            {
              
                barButtonItem3.Enabled =
                   orden.idestado == 1 || orden.idestado==2 ;
                barButtonItem3.Tag = orden.idestado == 1 ||orden.idestadoorden==1 ? true : false;
                barButtonItem3.Caption = orden.idestado == 1 || orden.idestadoorden == 1 ? "Eliminar" : "Cancelar";
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if((bool)barButtonItem3.Tag )
            {
                if(XtraMessageBox.Show("Esta seguro que desea eliminar esta orden de trabajo","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
                {
                    t_OrdenTrabajoBindingSource.RemoveCurrent();
                    t_OrdenTrabajoTableAdapter.Update(dSDatos.T_OrdenTrabajo);
                }
            }
            else
            { 
            var frmestado = new FrmObservacionesEstado(Main);
            frmestado.SetTitleInfo((Bitmap)imageCollection1.Images[1], "Cancelar Orden", "Establezca la razón de cancelación de la orden");
            if (frmestado.ShowDialog(this) == DialogResult.OK)
            {
                orden.idestado = 3;
                orden.obsestado = frmestado.memoEdit1.Text;
                t_OrdenTrabajoBindingSource.EndEdit();
                t_OrdenTrabajoTableAdapter.Update(dSDatos.T_OrdenTrabajo);
                //t_OrdenTrabajoTableAdapter.P_OrdenState(orden.idordentrabajo);
            }
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if(e.Column.VisibleIndex==2 &&e.Column.Tag==null)
            {
                var r = (DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox)e.RepositoryItem;
                var i =(DSDatos.T_OrdenTrabajoRow) ((GridView)sender).GetDataRow(e.RowHandle);

                if (i != null)
                {
                    SetCombo( r);
                    e.Column.Tag = 1;
                }
                    

            }
        }

        private void SetCombo(RepositoryItemImageComboBox r)
        {
            
         /*   t_PlanificacionTableAdapter1.FillByOrden(dSDatos.T_Planificacion, i.idequipo);
            var p = dSDatos.T_Planificacion.FindByidplanificacion(i.idtipointervencion);
            if (p == null)
                return;
            t_TipoModeloAccionTableAdapter1.FillBy(dSDatos.T_TipoModeloAccion, p.idmodelomant, "2");*/
            t_PlanificacionTableAdapter1.Fill(dSDatos.T_Planificacion);
            FrmEditOrdenTrabajo.FillCombo(r, dSDatos,-2);
           
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          
          
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {

        }
    }
}