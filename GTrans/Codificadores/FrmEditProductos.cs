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
    public partial class FrmEditProductos : CodificadorForm
    {
        public FrmEditProductos  (FrmMain main)
         : base(main)
        {
            InitializeComponent();
        }
        private int _edit;
        private int _idparent = -1;
        public int idparent { get { return _idparent; } set { _idparent = value; } }
        public int edit { get { return _edit; } set { _edit = value;

        this.t_ProductoGenericoTableAdapter.Fill(this.dsDatos1.T_ProductoGenerico);


        if (_edit == -1)
        {
            Text = "Añadir ";
          
            if(_type ==0 ||_type ==1 )
            {
                Text += _type == 0 ? "Genérico" : "SubGenérico";
                tProductoGenericoBindingSource.AddNew();
                tProductoGenericoBindingSource.MoveLast();
                if (_type == 0)
                    Generico.idparent = null;
                else
                if (idparent != -1)
                    Generico.idparent = idparent;
                ItemForidparent.Visibility = type == 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {
              
                this.t_ClasificacionTableAdapter.Fill(this.dSDatos.T_Clasificacion);
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
                this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_UM' Puede moverla o quitarla según sea necesario.
                this.t_UMTableAdapter.Fill(this.dSDatos.T_UM);
                Text += " Producto";
                tProductoBindingSource.AddNew();
                tProductoBindingSource.MoveLast();
                if (idparent != -1)
                    Producto.idgenerico = idparent;
            }
            
        }
        else
        {
            Text = "Editar ";
            if (_type == 0 || _type == 1)
            {
                Text += _type == 0 ? "Genérico" : "SubGenérico";
                t_ProductoGenericoTableAdapter.FillBy(dSDatos.T_ProductoGenerico, edit);
             
                //if (_type == 0)
                //    Generico.idparent = null;
                //else
                //    if (idparent != -1)
                //        Generico.idparent = idparent;
                ItemForidparent.Visibility = type == 0 ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
            {

                this.t_ClasificacionTableAdapter.Fill(this.dSDatos.T_Clasificacion);
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
                this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_UM' Puede moverla o quitarla según sea necesario.
                this.t_UMTableAdapter.Fill(this.dSDatos.T_UM);
                Text += " Producto";
                t_ProductoTableAdapter.FillBy(dSDatos.T_Producto, edit,"-1");
            }
           
        }
             toplabel.Text = Text;
        } 
        
        }
        private DSDatos.T_ProductoRow Producto { get { return (DSDatos.T_ProductoRow)((DataRowView)tProductoBindingSource.Current).Row; } }
    
        private DSDatos.T_ProductoGenericoRow Generico { get { return (DSDatos.T_ProductoGenericoRow)((DataRowView)tProductoGenericoBindingSource.Current).Row;} }
        private int _type;
        public int type
        {
            get { return _type; }
            set
            {
                _type = value;

                genericolayout.Visible = value==0 || value==1;
                productolayout.Visible = value == 2;
                if (value == 0 || value == 1)
                    Height = 154;
                else
                    Height = 226;
            }
        }
        private void FrmEditProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ProductoGenerico' Puede moverla o quitarla según sea necesario.
            
        }
        private void idumSpinEdit_Properties_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmProductoCodif(Main);

                t.ShowDialog(this);
                t.Dispose();
                //  if((bool)e.Button.Tag ==true)
                t_UMTableAdapter.Fill(dSDatos.T_UM);
                //else
                t_MonedaTableAdapter.Fill(dSDatos.T_Moneda);
            }
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                if(type==2)
                { 
                tProductoBindingSource.EndEdit();
                t_ProductoTableAdapter.Update(dSDatos.T_Producto);
                }
                else
                {
                    tProductoGenericoBindingSource.EndEdit();
                    t_ProductoGenericoTableAdapter.Update(dSDatos.T_ProductoGenerico);
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void idparentSpinEdit_Validating(object sender, CancelEventArgs e)
        {
            if(idparentSpinEdit.EditValue is int)
            {
                var t = dsDatos1.T_ProductoGenerico.FindByidproductogen((int)idparentSpinEdit.EditValue);
                if(t!=null)
                e.Cancel = t.idparent != null;
                
                    idparentSpinEdit.ErrorText = e.Cancel?"Se tiene que elegir un genérico":"";

            }
            
        }

        private void codigoTextEdit_Validated(object sender, EventArgs e)
        {

        }

        public String GetValue()
        {
            var w = "";
            if (type == 0)
                return codigoTextEdit.EditValue.ToString();
            else
                if(type==1)
                {
                    if(idparentSpinEdit.EditValue is int )
                    {
                        var t = t_ProductoGenericoTableAdapter.GetDataBy((int)idparentSpinEdit.EditValue);
                        if(t.Count>0)
                            return t[0].codigo + codigoTextEdit.EditValue.ToString();
                    }
                    else
                        return codigoTextEdit.EditValue.ToString(); 
                   
                }else
                {
                    if(gridLookUpEdit1.EditValue is int)
                    {

                        var t = t_ProductoGenericoTableAdapter.GetDataBy((int)gridLookUpEdit1.EditValue);
                        if (t.Count > 0)
                        {
                            var f = t_ProductoGenericoTableAdapter.GetDataBy((int)t[0].idparent);

                            if (f.Count > 0)
                                return f[0].codigo+ t[0].codigo + codproductoTextEdit.EditValue.ToString();
                            else

                            return t[0].codigo + codproductoTextEdit.EditValue.ToString();
                        }
                            

                    }
                    else
                        return codproductoTextEdit.EditValue.ToString();

                }
            return codproductoTextEdit.EditValue.ToString();
         //   type == 2 ? Producto.codcomplete : Generico.codcomplete;
        }
        private void codigoTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var edit = (TextEdit)sender;
            if (!(edit.EditValue is String))
                return;
            var validat = 0;

            var id = type == 2 ? Producto.idproducto : Generico.idproductogen;
            var w = GetValue();
     

            validat = (int)t_ProductoTableAdapter.ScalarQuery(w, (type+1).ToString(),id);


            var s = "";
            if (validat != 0)
                switch (type)
                {

                    case 0: { s = "generico"; break; }
                    case 1: { s = "subgenerico"; break; }
                    case 2: { s = "producto"; break; }
                           default: break;
                }

            e.Cancel = s != "";
            if (s != "")
                edit.ErrorText = "El código "+s + " tiene que ser unico";
        }

        private void gridLookUpEdit1_Validating(object sender, CancelEventArgs e)
        {
            if (gridLookUpEdit1.EditValue is int)
            {
                var t = dsDatos1.T_ProductoGenerico.FindByidproductogen((int)gridLookUpEdit1.EditValue);
                if (t != null)
                    e.Cancel = t.idparent == null;

                gridLookUpEdit1.ErrorText = e.Cancel ? "Se tiene que elegir un subgenérico" : "";

            }
        }
    }
}