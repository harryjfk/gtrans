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
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Codificadores
{
    public partial class FrmProductos : SaveableForm
    {
        public FrmProductos (FrmMain main)
         : base(main)
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            var adapter = new AdapterDeletedIncluder();
            adapter.DoAdapter(tableAdapterManager1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ProductoGenerico' Puede moverla o quitarla según sea necesario.
            this.t_ProductoGenericoTableAdapter.Fill(this.dSDatos.T_ProductoGenerico);
            //var t = new AdapterDeletedIncluder();
            //t.DoAdapter(tableAdapterManager1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Clasificacion' Puede moverla o quitarla según sea necesario.
            this.t_ClasificacionTableAdapter.Fill(this.dSDatos.T_Clasificacion);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_UM' Puede moverla o quitarla según sea necesario.
            this.t_UMTableAdapter.Fill(this.dSDatos.T_UM);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
            this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Producto' Puede moverla o quitarla según sea necesario.
            //this.t_ProductoTableAdapter.Fill(this.dSDatos.T_Producto);
            if (tProductoGenericoBindingSource.Count > 0)
                FocusedData = ((DataRowView)tProductoGenericoBindingSource[0]).Row;
            var i =  0;
            while (i < dSDatos.T_ProductoGenerico.Count)
                if (dSDatos.T_ProductoGenerico[i].idparent != null)
                    if (dSDatos.T_ProductoGenerico.FindByidproductogen((int)dSDatos.T_ProductoGenerico[i].idparent) == null)
                        dSDatos.T_ProductoGenerico.RemoveT_ProductoGenericoRow(dSDatos.T_ProductoGenerico[i]);
                    else i++;
                else
                    i++;

        }
        private bool edited;
        private object _focuseddata;
        public object FocusedData
        {
            get { return _focuseddata; }
            set
            {
                if (value == null)
                {
                    while (tProductoBindingSource.Count > 0)
                        tProductoBindingSource.RemoveCurrent();
                }

                barButtonItem1.ImageIndex = value is DSDatos.T_ProductoGenericoRow ? ((DSDatos.T_ProductoGenericoRow)value).idparent == null ? 0 : 1 : 2;

                barButtonItem2.ImageIndex = value is DSDatos.T_ProductoGenericoRow ? ((DSDatos.T_ProductoGenericoRow)value).idparent == null ? 3 : 4 : 5;
                barButtonItem3.ImageIndex = value is DSDatos.T_ProductoGenericoRow ? ((DSDatos.T_ProductoGenericoRow)value).idparent == null ? 6 : 7 : 8;
                if (value is DSDatos.T_ProductoRow)
                {
                    if (Tag == null && (!(_focuseddata is DSDatos.T_ProductoRow)))
                    {
                        Tag = _focuseddata;
                        _focuseddata = value;
                    }
                    else
                        if (edited)
                        {
                            _focuseddata = Tag;
                            Tag = null;
                        }
                        else _focuseddata = value;
                }
                else
                    _focuseddata = value;
                //if (!(_focuseddata is DSDatos.T_TipoModeloAccionRow))
                //{
                //    colnamemodelo1.Visible = _focuseddata is DSDatos.T_MarcaRow;
                //    colnametipomantenimiento1.Visible = _focuseddata is DSDatos.T_ModeloRow || colnamemodelo1.Visible;
                //}

                if (_focuseddata is DSDatos.T_ProductoGenericoRow)
                    if (((DSDatos.T_ProductoGenericoRow)_focuseddata).idparent == null)
                        t_ProductoTableAdapter.FillBy(dSDatos.T_Producto, ((DSDatos.T_ProductoGenericoRow)_focuseddata).idproductogen, "1");
                    else
                        t_ProductoTableAdapter.FillBy(dSDatos.T_Producto, ((DSDatos.T_ProductoGenericoRow)_focuseddata).idproductogen, "0");
                //else
                //    if (_focuseddata is DSDatos.T_ProductoRow)
                //        t_ProductoTableAdapter.FillBy(dSDatos.T_Producto, ((DSDatos.T_ProductoRow)_focuseddata).idproducto, "-1");


            }
        }
        public DSDatos.T_ProductoRow Producto { get { return (DSDatos.T_ProductoRow)((DataRowView)tProductoBindingSource.Current).Row; } }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var t = new FrmEditProductos(Main);
            t.SetTitleInfo((Bitmap)imageCollection1.Images[e.Item.ImageIndex], "", "");
            if (e.Item.Tag == null)
            {
                t.type = _focuseddata is DSDatos.T_ProductoGenericoRow ? 0 : 2;
                if (t.type == 0)
                    t.type = ((DSDatos.T_ProductoGenericoRow)_focuseddata).idparent == null ? 0 : 1;
            }

            else
            {
                t.type = (int)e.Item.Tag;
                barButtonItem1.Tag = e.Item.Tag;
                barButtonItem1.ImageIndex = e.Item.ImageIndex;
            }

            if (_focuseddata != null)
                if (_focuseddata is DSDatos.T_ProductoGenericoRow)
                {
                    if (((DSDatos.T_ProductoGenericoRow)_focuseddata).idparent == null || t.type==2)
                        t.idparent = ((DSDatos.T_ProductoGenericoRow)_focuseddata).idproductogen;
                    else
                        t.idparent = (int)((DSDatos.T_ProductoGenericoRow)_focuseddata).idparent;

                }
                else
                    if (_focuseddata is DSDatos.T_ProductoRow)
                        t.idparent = ((DSDatos.T_ProductoRow)_focuseddata).idgenerico;


            if (e.Item.Tag == null)
                t.edit = _focuseddata is DSDatos.T_ProductoGenericoRow ? ((DSDatos.T_ProductoGenericoRow)_focuseddata).idproductogen : ((DSDatos.T_ProductoRow)_focuseddata).idproducto;

            else
                t.edit = -1;
            if (t.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                if (t.type == 0 || t.type == 1)
                    t_ProductoGenericoTableAdapter.Fill(dSDatos.T_ProductoGenerico);
                else
                if (t.type == 2)
                {

                    t_UMTableAdapter.Fill(dSDatos.T_UM); t_MonedaTableAdapter.Fill(dSDatos.T_Moneda);
                    var w = tProductoBindingSource.Position;
                    edited = true;
                    var s= FocusedData;
                    FocusedData = Tag; FocusedData = s;
                    tProductoBindingSource.Position = w;
                 
                }

            }
                

            t.Dispose();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var msg = "Esta seguro que desea eliminar ";

            if (_focuseddata is DSDatos.T_ProductoGenericoRow)
              if(  ((DSDatos.T_ProductoGenericoRow)_focuseddata).idparent==null)
                msg += "este genérico";
              else
                  msg += "este subgenérico";
            else
                if (_focuseddata is DSDatos.T_ProductoRow)
                    msg += "este producto";


            msg += " ?";
            if (XtraMessageBox.Show(msg, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                HelperAdapter.DeleteRow((DataRow)_focuseddata);

                if (_focuseddata is DSDatos.T_ProductoGenericoRow)
                {
                    treeList1.DeleteNode(treeList1.FocusedNode);
                    //tProductoGenericoBindingSource.RemoveCurrent();
                }
                else

                    if (_focuseddata is DSDatos.T_ProductoRow)

                        tProductoBindingSource.RemoveCurrent();


            }

        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            FocusedData = ((DataRowView)tProductoGenericoBindingSource[tProductoGenericoBindingSource.Find("idproductogen", treeList1.FocusedNode.GetValue(0))]).Row;
            //
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            FocusedData = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetDataRow(e.RowHandle);
        }

        private void tProductoGenericoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void tProductoGenericoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        //    openFileDialog1.FileName = @"D:\Projects\VisualStudio\GTrans\GTrans\bin\Debug\Files\productos.xlsx";
                dSDatos.T_Producto.ImportFromFile(openFileDialog1.FileName);
        }
    }
}