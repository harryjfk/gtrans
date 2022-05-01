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
using GTrans.DSDatosTableAdapters;
using DevExpress.XtraGrid.Views.Grid;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmAlmacen : SaveableForm
    {
        public FrmAlmacen(FrmMain Main):base (Main)
        {
            InitializeComponent();
        }

        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            t_MonedaTableAdapter1.Fill(dSDatos.T_Moneda);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoVale' Puede moverla o quitarla según sea necesario.
            this.t_TipoValeTableAdapter.Fill(this.dSDatos.T_TipoVale);
            t_UMTableAdapter1.Fill(dSDatos.T_UM);
            t_ClasificacionTableAdapter1.Fill(dSDatos.T_Clasificacion);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Producto' Puede moverla o quitarla según sea necesario.
            this.t_ProductoTableAdapter.FillBy(this.dSDatos.T_Producto, -1, " ");
         
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AlmacenExistencia' Puede moverla o quitarla según sea necesario.
            this.t_AlmacenTableAdapter.Fill(this.dSDatos.T_Almacen);
            this.t_AlmacenExistenciaTableAdapter.Fill(this.dSDatos.T_AlmacenExistencia);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Almacen' Puede moverla o quitarla según sea necesario.
            t_ValeExistenciaTableAdapter1.Fill(dSDatos.T_ValeExistencia);  
        
        }
        private object _focused;
        public object FocusedData { get{
            return _focused;
        }
            set { _focused = value;

            barButtonItem1.ImageIndex = value is DSDatos.T_AlmacenRow ? 2 : 3;

            barButtonItem2.ImageIndex = value is DSDatos.T_AlmacenRow ? 4 : 5 ;
            barButtonItem3.ImageIndex = value is DSDatos.T_AlmacenRow ? 6 : 7;
  
            
            }
        }
        private GridView focusdgrid;
        public DSDatos.T_AlmacenRow Almacen { get { return (DSDatos.T_AlmacenRow)((DataRowView)tAlmacenBindingSource.Current).Row; } }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var edit = new FrmEditAlmacen(Main);
            edit.SetTitleInfo((Bitmap)imageCollection1.Images[e.Item.ImageIndex], "", "");
            if(e.Item.Tag ==null)
            {
                 edit.almacen =FocusedData is DSDatos.T_AlmacenRow;
                if( FocusedData is DSDatos.T_AlmacenRow)
                    edit.edit = ((DSDatos.T_AlmacenRow)FocusedData).idalmacen;
                else
                    edit.edit = ((DSDatos.T_AlmacenExistenciaRow)FocusedData).idalmacenproducto;
            }
            else
            {
                barButtonItem1.Tag = e.Item.Tag;
                edit.almacen =(bool) e.Item.Tag;
                if (!edit.almacen)
                    edit.idparent = Almacen.idalmacen;
                edit.edit = -1;
            }
           
            if(edit.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            {
                if (edit.almacen)
                    t_AlmacenTableAdapter.Fill(dSDatos.T_Almacen);
                else
                {
                    var t = fKTAlmacenExistenciaTAlmacenBindingSource.Position;
                    t_AlmacenExistenciaTableAdapter.Fill(dSDatos.T_AlmacenExistencia);
                    t_ValeExistenciaTableAdapter1.Fill(dSDatos.T_ValeExistencia);
            
                    fKTAlmacenExistenciaTAlmacenBindingSource.Position = t;
                    FocusedData = ((DataRowView)fKTAlmacenExistenciaTAlmacenBindingSource[t]).Row;
                }
                   
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            FocusedData = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetDataRow(((DevExpress.XtraGrid.Views.Grid.GridView)sender).FocusedRowHandle);
            focusdgrid = ((DevExpress.XtraGrid.Views.Grid.GridView)sender);
        }

        private void tAlmacenBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (tAlmacenBindingSource.Current == null)
                return;
            FocusedData = ((DataRowView)tAlmacenBindingSource.Current).Row;
            focusdgrid = gridView1;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var msg = "Esta seguro que desea eliminar ";

            if (_focused is DSDatos.T_AlmacenRow)
                msg += "este almacen";
            else
                if (_focused is DSDatos.T_AlmacenExistenciaRow)
                    msg += "este producto";
            

            msg += " ?";
            if (XtraMessageBox.Show(msg, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                HelperAdapter.DeleteRow((DataRow)_focused);

                if (_focused is DSDatos.T_AlmacenRow)
                  tAlmacenBindingSource.RemoveCurrent();
               
                else
                    if (_focused is DSDatos.T_AlmacenExistenciaRow)
                        focusdgrid.DeleteSelectedRows();
                    

                 

            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
           // openFileDialog1.FileName = @"D:\Projects\VisualStudio\GTrans\GTrans\bin\Debug\Files\almacen.xlsx";
                dSDatos.T_Almacen.ImportFromFile(openFileDialog1.FileName);
        }
    }
}