using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GTrans.Abstract;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{

    public enum FormsType  {Surtido, Salario, Contratacion };
  
    public partial class FrmEditRealOrdenTrabajo :CodificadorForm
    {
        public DSDatos DataSet { get { return _dataset; } set { _dataset = value;


        } }
        public FrmEditRealOrdenTrabajo(FrmMain main)
            : base(main)
        {
            InitializeComponent();
      //      tableAdapterManager.T_EmpleadoTableAdapter = t_EmpleadoTableAdapter1;
            HelperAdapter.DoAdapter(t_Empleado1TableAdapter1,"T_Empleado");
        //    t_Empleado1TableAdapter1.Adapter.SelectCommand.CommandText = t_Empleado1TableAdapter1.Adapter.SelectCommand.CommandText.Replace("T_Empleado1", "T_Empleado");
        }
        public bool plan { get; set; }
        public int orden { get; set; }
        public object fechaorden { get; set; }
        public int intervencion { get; set; }
        public FormsType TypeForm{set
        {
            SetTitleInfo((Bitmap)imageCollection1.Images[0],"", "");
            switch (value)
            {
                case FormsType.Surtido:
                    {
                        Text = @"Costo en Material";
                        xtraTabControl1.SelectedTabPageIndex = 0;
                        tOrdenSurtidoBindingSource.DataSource = DataSet;
                        tOrdenSurtidoBindingSource.Filter = "idorden = " + orden + " and plan ="+plan;
                        this.p_OrdenSurtidoTableAdapter.Fill(this.dSDatos.P_OrdenSurtido);
                        t_ProductoGenericoTableAdapter1.Fill(dSDatos.T_ProductoGenerico);
                        t_ClasificacionTableAdapter.Fill(dSDatos.T_Clasificacion);
                        t_UMTableAdapter1.Fill(dSDatos.T_UM);
                        // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Clasificacion' Puede moverla o quitarla según sea necesario.
                        //this.t_ClasificacionTableAdapter.Fill(this.dSDatos.T_Clasificacion);
                        // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Producto' Puede moverla o quitarla según sea necesario.
                        this.t_ProductoTableAdapter.FillBy(this.dSDatos.T_Producto, -1, "-1");
                        gridColumn3.Visible = intervencion == -1|| !plan ;
                        gridColumn6.Visible = gridColumn3.Visible;
                        break;
                    }
               case FormsType.Salario:
                    {
                        Text = @"Costo en Salario";
                        tOrdenSalarioBindingSource.DataSource = DataSet;
                        xtraTabControl1.SelectedTabPageIndex = 1;
                        this.t_Empleado1TableAdapter1.Fill(this.dSDatos.T_Empleado1);
                        tOrdenSalarioBindingSource.Filter = "idorden = " + orden + " and plan =" + plan;
                        gridColumn8.Visible = intervencion == -1 || !plan;
                        gridColumn2.Visible = gridColumn3.Visible;
                        
                        break;
                    }
                

            }
 
            toplabel.Text = Text;
          
        }}

        private void FrmEditRealOrdenTrabajo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.P_OrdenSurtido' Puede moverla o quitarla según sea necesario.
              // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
            this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AlmacenExistencia' Puede moverla o quitarla según sea necesario.
         
           // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenContratacion' Puede moverla o quitarla según sea necesario.
           // this.t_OrdenContratacionTableAdapter.Fill(this.dSDatos.T_OrdenContratacion);
           // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_SubContratacion' Puede moverla o quitarla según sea necesario.
           // this.t_SubContratacionTableAdapter.Fill(this.dSDatos.T_SubContratacion);
           // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empleado1' Puede moverla o quitarla según sea necesario.
         
           // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenSalario' Puede moverla o quitarla según sea necesario.
           // this.t_OrdenSalarioTableAdapter.Fill(this.dSDatos.T_OrdenSalario);
           // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_OrdenSurtido' Puede moverla o quitarla según sea necesario.
            //this.t_OrdenSurtidoTableAdapter.FillBy(this.dSDatos.T_OrdenSurtido);
           // // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empleado' Puede moverla o quitarla según sea necesario.
           //this.t_Empleado1TableAdapter1.Fill(this.dSDatos.T_Empleado1);
           
             SetUpGrid(gridControl1);
            SetUpGrid(gridControl2);
         
            SetUpGrid(t_ProductoGridControl);
            SetUpGrid(t_OrdenSurtidoGridControl);
        }


        public void SetUpGrid(GridControl grid)
        {
            grid.AllowDrop = true;
            grid.DragOver += new DragEventHandler(grid_DragOver);
            grid.DragDrop += new DragEventHandler(grid_DragDrop);
            GridView view = grid.MainView as GridView;
            // view.OptionsBehavior.Editable = false;
            view.MouseMove += new MouseEventHandler(view_MouseMove);
            view.MouseDown += new MouseEventHandler(view_MouseDown);
        }

        GridHitInfo downHitInfo = null;
        private DSDatos _dataset;

        private void view_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;
            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None) return;
            if (e.Button == MouseButtons.Left && hitInfo.RowHandle >= 0 )
                downHitInfo = hitInfo;
        }

        private void view_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2,
                    downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);
                    if (row == null)
                        return;
                    view.GridControl.DoDragDrop(row, DragDropEffects.Copy);
                    downHitInfo = null;
                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            }
        }

        private void grid_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = (e.Data.GetDataPresent(typeof(DSDatos.T_Empleado1Row)) || e.Data.GetDataPresent(typeof(DSDatos.P_OrdenSurtidoRow))) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void grid_DragDrop(object sender, DragEventArgs e)
        {
            var grid = sender as GridControl;
            if (grid.Tag == null)
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        {


                            var row = (DSDatos.P_OrdenSurtidoRow)e.Data.GetData(typeof(DSDatos.P_OrdenSurtidoRow));
                            DataSet.T_OrdenSurtido.DefaultView.RowFilter = String.Format("idproducto = {0} and idorden = {1} and plan = {2}", row.idproducto, orden, plan);
                            if (DataSet.T_OrdenSurtido.DefaultView.Count == 0)
                            {
                                var addsal = new FrmEditRealDropped(Main)
                                                 {
                                                     orden = orden,
                                                     dataSet = DataSet,
                                                     edit = -1,
                                                     plan = plan,
                                                     temp = row, intervencio = intervencion,
                                                     TypeForm = FormsType.Surtido,
                                                     fechaorden = fechaorden,
                                                    
                                                 };


                                if (addsal.ShowDialog(this) == DialogResult.OK)

                                    DataSet.T_OrdenSurtido[DataSet.T_OrdenSurtido.Count - 1].GetImporte();
                                grid.Tag = 1;
                            }
                            else
                            {
                                XtraMessageBox.Show("Ya existe el producto en la orden de trabajo", "Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case 1:
                        {


                            var row = (DSDatos.T_Empleado1Row)e.Data.GetData(typeof(DSDatos.T_Empleado1Row));
                            dSDatos.T_OrdenSalario.DefaultView.RowFilter = String.Format("idempleado = {0} and idforma = {1} and idorden = {2} and plan = {2}", row.idempleado, row.idformapago, orden,plan);
                            if (dSDatos.T_OrdenSalario.DefaultView.Count == 0)
                            {
                                var addsal = new FrmEditRealDropped(Main)
                                                 {
                                                     orden = orden,
                                                     edit = -1,
                                                     dataSet = DataSet,
                                                     plan = plan,
                                                     temp = row,
                                                     TypeForm = FormsType.Salario
                                                     ,
                                                     fechaorden = fechaorden
                                                 };


                                if (addsal.ShowDialog(this) == DialogResult.OK)
                                    DataSet.T_OrdenSalario[DataSet.T_OrdenSalario.Count - 1].GetImporte();
                                grid.Tag = 1;
                            }
                            else
                            {
                                XtraMessageBox.Show("Ya existe la forma de pago de este trabajador en la orden de trabajo", "Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;

                }
            else
                grid.Tag = null;
        }

       

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
               var row = (DSDatos.T_OrdenSalarioRow) ((DataRowView) tOrdenSalarioBindingSource.Current).Row;
               dSDatos.T_Empleado1.DefaultView.RowFilter = String.Format("idempleado = {0} and idformapago = {1} ", row.idempleado, row.idforma);

               var empleado = dSDatos.T_Empleado1.DefaultView[0];
                 var addsal = new FrmEditRealDropped(Main)
                 {
                     intervencio = intervencion,
                     orden = orden,
                     dataSet = DataSet,
                     plan = plan,
                   
                     edit = row.idordensalario,
                     temp = empleado.Row,
                     TypeForm = FormsType.Salario,
                     fechaorden = fechaorden
                 };


                 if (addsal.ShowDialog(this) == DialogResult.OK)
                     DataSet.T_OrdenSalario.FindByidordensalario(row.idordensalario).GetImporte();
            }
            else
            {
               tOrdenSalarioBindingSource.RemoveCurrent();
                //t_OrdenSalarioTableAdapter.Update(dSDatos.T_OrdenSalario);
            }
        }

       

        private void repositoryItemButtonEdit3_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var row = (DSDatos.T_OrdenSurtidoRow)((DataRowView)tOrdenSurtidoBindingSource.Current).Row;
                dSDatos.P_OrdenSurtido.DefaultView.RowFilter = "idproducto = " + row.idproducto;
                var contra = dSDatos.P_OrdenSurtido.DefaultView[0];
                var addsal = new FrmEditRealDropped(Main)
                {
                    intervencio = intervencion,
                    orden = orden,dataSet=DataSet,plan = plan,
                    edit = row.idordensurtido,
                    temp = (DSDatos.P_OrdenSurtidoRow)contra.Row,
                    TypeForm = FormsType.Surtido,
                    fechaorden = fechaorden
                };

                if (addsal.ShowDialog(this) == DialogResult.OK)
                    DataSet.T_OrdenSurtido.FindByidordensurtido(row.idordensurtido).GetImporte(); 
             //   if (addsal.ShowDialog(this) == DialogResult.OK)
                    //this.t_OrdenSurtidoTableAdapter.FillBy(this.dSDatos.T_OrdenSurtido);
            }
            else
            {
                tOrdenSurtidoBindingSource.RemoveCurrent();
                //t_OrdenSurtidoTableAdapter.Update(dSDatos.T_OrdenSurtido);
            }
        }

        private void repositoryItemButtonEdit4_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {

                DataObject w = new DataObject(((GridView)((GridControl)((ButtonEdit)sender).Parent).FocusedView).GetFocusedDataRow());
                var a = new DragEventArgs(w, 0, 0, 0, DragDropEffects.Copy, DragDropEffects.Copy);
                grid_DragDrop(t_OrdenSurtidoGridControl, a);
            }
        }

        private void repositoryItemButtonEdit5_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Plus)
            {
                DataObject w = new DataObject((DSDatos.T_Empleado1Row)(((DataRowView)tEmpleadoBindingSource.Current).Row));
                var a = new DragEventArgs(w, 0, 0, 0, DragDropEffects.Copy, DragDropEffects.Copy);
                grid_DragDrop(gridControl2, a);
            }
        }

        private void FrmEditRealOrdenTrabajo_FormClosed(object sender, FormClosedEventArgs e)
        {
            tOrdenSalarioBindingSource.EndEdit();
            tOrdenSurtidoBindingSource.EndEdit();
            
        }

        

      
    }
}