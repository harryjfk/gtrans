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
using DevExpress.XtraGrid.Views.Grid;

namespace GTrans.Tareas
{
    public partial class FrmEditAlmacen : CodificadorForm
    {
        public FrmEditAlmacen(FrmMain Main):base(Main)
        {
            InitializeComponent();
            dateEdit1.Validating += ValidFechaDateEdit_Validating;
        }
        public int idparent;
        private int _edit;
        public int edit { get { return _edit; } set { _edit = value;
        
            if(_edit==-1)
            {
                Text = "Añadir ";
                if (almacen)
                    tAlmacenBindingSource.AddNew();
                else
                {
                    this.t_ProductoTableAdapter.FillBy(this.dSDatos.T_Producto, -1, " ");
                    this.t_AlmacenTableAdapter.Fill(this.dSDatos.T_Almacen);
                    dSDatos.T_AlmacenExistencia.idalmacenColumn.DefaultValue = idparent;
                    dSDatos.T_AlmacenExistencia.idtipovaleColumn.DefaultValue = 1;
                    tAlmacenExistenciaBindingSource.AddNew();
                    idalmacenSpinEdit.EditValue = idparent;
                }
                   
            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Producto' Puede moverla o quitarla según sea necesario.
              
                Text = "Editar ";
                if (almacen)
                {
                    t_AlmacenTableAdapter.FillBy(dSDatos.T_Almacen, edit);
                }
                    
                else
                {
                    this.t_ProductoTableAdapter.FillBy(this.dSDatos.T_Producto, -1, " ");
                    this.t_AlmacenTableAdapter.Fill(this.dSDatos.T_Almacen);
                 
                    t_AlmacenExistenciaTableAdapter.FillBy(dSDatos.T_AlmacenExistencia, edit);
                    this.t_ValeExistenciaTableAdapter.FillBy(this.dSDatos.T_ValeExistencia,edit);
                    this.t_ValeExistenciaMonedaTableAdapter.FillBy(this.dSDatos.T_ValeExistenciaMoneda, edit);
        
                }
                  
            }
            if (almacen)
                Text += "Almacen";
            else
                Text += "Producto";
            toplabel.Text = Text;
        
        } }

        private bool _almacen;
        public bool almacen { get { return _almacen; } set { _almacen = value;

        almacenlayout.Visible = value;
        productolayout.Visible = !value;
        if (almacen)
            Height = 154;
        else
            Height = 370;
        } }

        private double Existencia=0;
        private void FrmEditAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
            this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ValeExistenciaMoneda' Puede moverla o quitarla según sea necesario.
             // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoVale' Puede moverla o quitarla según sea necesario.
            this.t_TipoValeTableAdapter.Fill(this.dSDatos.T_TipoVale);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ValeExistencia' Puede moverla o quitarla según sea necesario.
        
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AlmacenExistencia' Puede moverla o quitarla según sea necesario.
      
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Almacen' Puede moverla o quitarla según sea necesario.
       

        }

        public DSDatos.T_AlmacenExistenciaRow Vale { get { return (DSDatos.T_AlmacenExistenciaRow) ((DataRowView)tAlmacenExistenciaBindingSource.Current).Row;} }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
               
                if (almacen)
                {
                    tAlmacenBindingSource.EndEdit();
                    t_AlmacenTableAdapter.Update(dSDatos.T_Almacen);
                }
                else
                {
                    if (dSDatos.T_ValeExistencia.Count == 0)
                    {
                        XtraMessageBox.Show("Debe introducir al menos un producto en el vale");
                        return;

                    }

                   tAlmacenExistenciaBindingSource.EndEdit();
                    t_AlmacenExistenciaTableAdapter.Update(dSDatos.T_AlmacenExistencia);
                    var t = new List<int>();
                    if(edit==-1 && !almacen)
                        foreach (var item in dSDatos.T_ValeExistencia)
                        {
                            t.Add(item.idvaleproducto);
                            item.idvale = Vale.idalmacenproducto;
                        }
                    tableAdapterManager1.UpdateAll(dSDatos);
                           
                    //t_ValeExistenciaTableAdapter.Update(dSDatos.T_ValeExistencia);
                    //t_ValeExistenciaMonedaTableAdapter.Update(dSDatos.T_ValeExistenciaMoneda);
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void repositoryItemGridLookUpEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmProductoCodif(Main);
                t.ShowDialog(this);
                t_MonedaTableAdapter.Fill(dSDatos.T_Moneda);

            }
        }

        private void valeentTextEdit_Validating(object sender, CancelEventArgs e)
        {
              e.Cancel =(int) t_AlmacenExistenciaTableAdapter.ScalarQuery(valeentTextEdit.EditValue.ToString(), Vale.idalmacenproducto)>0;
              valeentTextEdit.ErrorText = e.Cancel?"El código del vale debe ser unico":"";
         

        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
          
            
            
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DSDatos.T_ValeExistenciaRow row = (DSDatos.T_ValeExistenciaRow)((DataRowView)e.Row).Row;
            if (row.existencia < 0)
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo cantidad.\n";
            }
            
            if (gridLookUpEdit1.EditValue.ToString() != "2")
                return;

            var grid = (GridView)sender;
            var producto = (DSDatos.T_ValeExistenciaRow)((DataRowView)e.Row).Row;
            var Existencia = (double)t_AlmacenExistenciaTableAdapter.Existencia(producto.idproducto, Vale.idalmacen);
            try
            {

                e.Valid = Existencia >= Convert.ToDouble(producto.existencia);
                if (!e.Valid)
                    e.ErrorText = "La Existencia de este producto no puede ser menor de 0";
            }
            catch (Exception)
            { }


            

          
        }

        private void CodifcadorPieFormulario_Load(object sender, EventArgs e)
        {

        }

        private void gridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DSDatos.T_ValeExistenciaMonedaRow row = (DSDatos.T_ValeExistenciaMonedaRow)((DataRowView)e.Row).Row;
            if (row.precio < 0)
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo precio.\n";
            }
        }
    }
}