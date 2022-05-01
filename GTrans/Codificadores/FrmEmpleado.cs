using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GTrans.Abstract;
using ACINOX.DBT.DSDllTableAdapters;


namespace GTrans.Codificadores
{
    public partial class FrmEmpleado : SaveableForm
    {
        public FrmEmpleado(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            DefaultText = "Empleados";
        }

        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            var adapter = new AdapterDeletedIncluder();
            adapter.DoAdapter(tableAdapterManager1);
            t_Empleado_FormaTableAdapter.Fill(dSDatos.T_Empleado_Forma);
            this.t_FormaPagoTableAdapter.Fill(this.dSDatos.T_FormaPago);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empleado_Forma' Puede moverla o quitarla según sea necesario.
            this.t_EmpleadoTableAdapter.Fill(this.dSDatos.T_Empleado);
            Loaded();
            t_EmpleadoBindingSource_CurrentChanged(null, null);
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }





        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private DSDatos.T_EmpleadoRow Empleado { get { return ((DSDatos.T_EmpleadoRow)((DataRowView)t_EmpleadoBindingSource.Current).Row); } }




        private void t_EmpleadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            barButtonItem5.Enabled = t_EmpleadoBindingSource.Count > 0;
            barButtonItem6.Enabled = barButtonItem5.Enabled;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var s = new FrmEditPlanitlla(Main);
            s.SetTitleInfo((Bitmap)imageCollection1.Images[e.Item.ImageIndex],"","");
            s.edit = e.Item.Tag == null ? -1 : Empleado.idempleado;
            if (s.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                t_EmpleadoTableAdapter.Fill(dSDatos.T_Empleado);
                t_Empleado_FormaTableAdapter.Fill(dSDatos.T_Empleado_Forma);
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ShowDialog("Esta seguro que desea eliminar este empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
 queriesTableAdapter1.P_DeleteObject("T_Empleado", "idempleado", Empleado.idempleado);
                t_EmpleadoBindingSource.Filter += t_EmpleadoBindingSource.Filter ==null ? "idempleado <> " + Empleado.idempleado : " and idempleado <> " + Empleado.idempleado;

               
            }
        }





    }
}