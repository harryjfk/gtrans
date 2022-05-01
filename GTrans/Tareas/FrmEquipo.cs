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
using DevExpress.XtraGrid.Views.Grid;
using GTrans.Abstract;
using GTrans.DSDatosTableAdapters;
using System.IO;
using System.Drawing.Imaging;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmEquipo : SaveableForm
    {
        public FrmEquipo(FrmMain main)
            : base(main)
        {
            InitializeComponent();
      
        }
        private bool edited;
        private object _focuseddata;
        public object FocusedData
        {
            get { return _focuseddata; }
            set
            {
                barButtonItem1.Tag = value is DSDatos.T_EmpresaRow ? 0 : value is DSDatos.T_UEBRow ? 1 : value is DSDatos.T_AreaRow ? 2: 3;

               
                barButtonItem1.ImageIndex = value is DSDatos.T_EmpresaRow ? 4 : value is DSDatos.T_UEBRow ? 5 : value is DSDatos.T_AreaRow ? 6 : 7;

                barButtonItem2.ImageIndex = value is DSDatos.T_EmpresaRow ? 8 : value is DSDatos.T_UEBRow ? 9 : value is DSDatos.T_AreaRow ? 10 : 11;
                barButtonItem3.ImageIndex = value is DSDatos.T_EmpresaRow ? 12 : value is DSDatos.T_UEBRow ? 13 : value is DSDatos.T_AreaRow ? 14 : 15;
                barButtonItem3.Caption = value is DSDatos.T_EquipoRow ? "Dar Baja" : "Eliminar";
                barButtonItem2.Enabled = value != null;
                barButtonItem3.Enabled = barButtonItem2.Enabled;
                barButtonItem8.Enabled = value is DSDatos.T_EquipoRow;
                if (value is DSDatos.T_EquipoRow)
                {
                    if (Tag == null && (!(_focuseddata is DSDatos.T_EquipoRow)))
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
                {
                    _focuseddata = value;

                }
                if (!(_focuseddata is DSDatos.T_EmpresaRow))
                {
                    //colnamemodelo1.Visible = _focuseddata is DSDatos.T_MarcaRow;
                    //colnametipomantenimiento1.Visible = _focuseddata is DSDatos.T_ModeloRow || colnamemodelo1.Visible;
                }

                if (_focuseddata is DSDatos.T_EmpresaRow)
                    t_EquipoTableAdapter.FillBy(dSDatos.T_Equipo, ((DSDatos.T_EmpresaRow)_focuseddata).id_empresa, "0",barEditItem1.EditValue.ToString());
                else
                    if (_focuseddata is DSDatos.T_UEBRow)
                        t_EquipoTableAdapter.FillBy(dSDatos.T_Equipo, ((DSDatos.T_UEBRow)_focuseddata).id_ueb, "1", barEditItem1.EditValue.ToString());
                    else
                        if (_focuseddata is DSDatos.T_AreaRow)
                            t_EquipoTableAdapter.FillBy(dSDatos.T_Equipo, ((DSDatos.T_AreaRow)_focuseddata).id_area, "2",barEditItem1.EditValue.ToString());
                        else if (_focuseddata is DSDatos.T_EquipoRow)

                            barButtonItem3.Enabled = !Equipo.baja;
                       
            }
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            var t = new AdapterDeletedIncluder();
           t.DoAdapter(tableAdapterManager1);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Estado_Tecnico' Puede moverla o quitarla según sea necesario.
            this.t_Estado_TecnicoTableAdapter.Fill(this.dSDatos.T_Estado_Tecnico);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_EquipoTableAdapter.Fill(this.dSDatos.T_Tipo_Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Modelo' Puede moverla o quitarla según sea necesario.
            this.t_ModeloTableAdapter.Fill(this.dSDatos.T_Modelo);
            t_EmpresaTableAdapter.Fill(dSDatos.T_Empresa);
            t_UEBTableAdapter1.Fill(dSDatos.T_UEB);
            t_AreaTableAdapter1.Fill(dSDatos.T_Area);
            t_EquipoTableAdapter.Fill(dSDatos.T_Equipo);
            //imageCollection1.Images[0].Save("C:\\empresa.png", ImageFormat.Bmp);
            //imageCollection1.Images[1].Save("C:\\UEB.png", ImageFormat.Bmp);
            //imageCollection1.Images[2].Save("C:\\area.png", ImageFormat.Bmp);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var edit = new FrmEditEquipo();
            edit.SetTitleInfo((Bitmap)imageCollection1.Images[e.Item.ImageIndex], "", "");

            if (e.Item.Tag == null)
                edit.type = _focuseddata is DSDatos.T_EmpresaRow ? 0 : _focuseddata is DSDatos.T_UEBRow ? 1 : _focuseddata is DSDatos.T_AreaRow ? 2 : 3;
            else
            {
                barButtonItem1.Tag = e.Item.Tag;
                barButtonItem1.ImageIndex = e.Item.ImageIndex;
                edit.type = (int)e.Item.Tag;
            }
              


            switch (edit.type)
            {
                case 1:
                    {
                        if (_focuseddata != null)
                            if (_focuseddata is DSDatos.T_EmpresaRow)
                                edit.idparent = ((DSDatos.T_EmpresaRow)_focuseddata).id_empresa;
                            else
                                if (_focuseddata is DSDatos.T_UEBRow)
                                    edit.idparent = ((DSDatos.T_UEBRow)_focuseddata).id_empresa;
                                else
                                    if (_focuseddata is DSDatos.T_AreaRow)
                                        edit.idparent = ((DSDatos.T_AreaRow)_focuseddata).T_UEBRow.id_empresa;
                                    else
                                        edit.idparent = ((DSDatos.T_EquipoRow)_focuseddata).T_AreaRowByFK_T_Equipo_T_Area.T_UEBRow.id_empresa;
                        break;
                    }
                case 2:
                    {
                        if (_focuseddata != null)
                            if (_focuseddata is DSDatos.T_EmpresaRow) 
                              edit.idparent = -1;
                            else
                                if (_focuseddata is DSDatos.T_UEBRow)
                                    edit.idparent = ((DSDatos.T_UEBRow)_focuseddata).id_empresa;
                                else
                                    if (_focuseddata is DSDatos.T_AreaRow)
                                        edit.idparent = ((DSDatos.T_AreaRow)_focuseddata).T_UEBRow.id_empresa;
                                    else
                                        edit.idparent = ((DSDatos.T_EquipoRow)_focuseddata).T_AreaRowByFK_T_Equipo_T_Area.T_UEBRow.id_empresa;
                        break;
                    }
                case 3:
                    {
                        try
                        {
                            if (_focuseddata != null)
                                if (_focuseddata is DSDatos.T_EmpresaRow)
                                    edit.idparent = -1;
                                else
                                    if (_focuseddata is DSDatos.T_UEBRow)
                                        edit.idparent = -1;
                                    else
                                        if (_focuseddata is DSDatos.T_AreaRow)
                                            edit.idparent = ((DSDatos.T_AreaRow)_focuseddata).id_area;
                                        else
                                            edit.idparent = ((DSDatos.T_EquipoRow)_focuseddata).T_AreaRowByFK_T_Equipo_T_Area.id_area;
  
                        }
                        catch (Exception) { }
                        break;
                    }
                default: break;

            }
            if (e.Item.Tag == null)

                edit.edit = _focuseddata is DSDatos.T_EmpresaRow ? ((DSDatos.T_EmpresaRow)_focuseddata).id_empresa : _focuseddata is DSDatos.T_UEBRow ? ((DSDatos.T_UEBRow)_focuseddata).id_ueb : _focuseddata is DSDatos.T_AreaRow ? ((DSDatos.T_AreaRow)_focuseddata).id_area : ((DSDatos.T_EquipoRow)_focuseddata).idequipo;

            else
                edit.edit = -1;

            if (edit.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                switch (edit.type)
                {
                    case 0: { t_EmpresaTableAdapter.Fill(dSDatos.T_Empresa); break; }
                    case 1: { t_UEBTableAdapter1.Fill(dSDatos.T_UEB); break; }
                    case 2: { t_AreaTableAdapter1.Fill(dSDatos.T_Area); break; }
                    case 3:
                        {
                            var w = tEquipoBindingSource.Position;
                            edited = true;
                            var t = FocusedData;
                            FocusedData = Tag; FocusedData = t;
                            tEquipoBindingSource.Position = w;
                            break;
                        }
                    default: break;
                }
            }
        }
        private object focusdgrid;
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            FocusedData = ((DevExpress.XtraGrid.Views.Grid.GridView)sender).GetDataRow(((DevExpress.XtraGrid.Views.Grid.GridView)sender).FocusedRowHandle);
            focusdgrid = sender;
        }


        private void layoutView1_CardClick(object sender, DevExpress.XtraGrid.Views.Layout.Events.CardClickEventArgs e)
        {
            edited= false;
            FocusedData = ((DevExpress.XtraGrid.Views.Layout.LayoutView)sender).GetDataRow(((DevExpress.XtraGrid.Views.Layout.LayoutView)sender).FocusedRowHandle);
        focusdgrid = sender;
        
        }

        private void tEquipoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
           
        }

        private void tEquipoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //barButtonItem8.Enabled = tEquipoBindingSource.Current != null;
        }
        public DSDatos.T_EquipoRow Equipo { get { return (DSDatos.T_EquipoRow)_focuseddata; } }
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        

        }

        private void tEmpresaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (tEmpresaBindingSource.Current == null)
                return;
            FocusedData = ((DataRowView) tEmpresaBindingSource.Current).Row;
            focusdgrid = sender;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var msg = "Esta seguro que desea  ";

            if (_focuseddata is DSDatos.T_EmpresaRow)
                msg += "eliminar esta empresa";
            else
                if (_focuseddata is DSDatos.T_UEBRow)
                    msg += " eliminar esta ueb";
                else
                    if (_focuseddata is DSDatos.T_AreaRow)
                        msg += "eliminar esta area";
                    else
                        if (_focuseddata is DSDatos.T_EquipoRow)
                            msg += "dar baja este equipo";

            msg += " ?";
            if (XtraMessageBox.Show(msg,  _focuseddata is DSDatos.T_EquipoRow ?"Dar Baja":"Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                if (_focuseddata is DSDatos.T_EmpresaRow)
                {
                    HelperAdapter.DeleteRow((DataRow)_focuseddata);
                    tEmpresaBindingSource.RemoveCurrent();
                }
                else
                    if (_focuseddata is DSDatos.T_UEBRow)
                    {
                        HelperAdapter.DeleteRow((DataRow)_focuseddata);

                        ((GridView)focusdgrid).DeleteSelectedRows();
                    }

                    else
                        if (_focuseddata is DSDatos.T_AreaRow)
                        {
                            HelperAdapter.DeleteRow((DataRow)_focuseddata);
                            ((GridView)focusdgrid).DeleteSelectedRows();
                        }
                        else
                            if (_focuseddata is DSDatos.T_EquipoRow)
                            {
                                var t = new FrmBajaEquipo();
                                //t.SetTitleInfo((Bitmap)imageCollection1.Images[e.Item.ImageIndex], "", "");

                                t.idequipo = Equipo.idequipo;
                                if (t.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                                {
                                    Equipo.baja = true;
                                    barButtonItem3.Enabled = false;
                           
                                   
                                }
                                //queriesTableAdapter1.P_DeleteObject("T_TipoModeloAccion", "idaccionmant", ((DSDatos.T_TipoModeloAccionRow)_focuseddata).idaccionmant);
                                //tTipoModeloAccionBindingSource.RemoveCurrent();
                            }

            }


            //if (XtraMessageBox.Show("Esta seguro que desea ?", "Dar Baja?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            //{
           
            //}
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            FocusedData = FocusedData;
        }
    }
}