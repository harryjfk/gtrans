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
    public partial class FrmMarca : CodificadorForm
    {
        public FrmMarca()
        {
            InitializeComponent();
            gridView1.CellValueChanged += ValidCellValue;
            gridView2.CellValueChanged += ValidCellValue;
            gridView3.CellValueChanged += ValidCellValue;
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Marca' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_MarcaTableAdapter.Fill(this.dSDatos.T_Tipo_Marca);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.Fill(this.dSDatos.T_Marca);
            t_ModeloTableAdapter1.Fill(dSDatos.T_Modelo);
            tTipoMarcaBindingSource.Filter = "id_tipo_marca <> 1";
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update(); 
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void FrmMarca_Shown(object sender, EventArgs e)
        {
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Marcas y modelos", "Marcas y modelos");
        }

        private void FrmMarca_FormClosed(object sender, FormClosedEventArgs e)
        {
            //t_ModeloTableAdapter1.Update(dSDatos.T_Modelo); t_MarcaTableAdapter.Update(dSDatos.T_Marca); t_Tipo_MarcaTableAdapter.Update(dSDatos.T_Tipo_Marca);
        }
        protected override void DoUpdate()
        {
            t_Tipo_MarcaTableAdapter.Update(dSDatos.T_Tipo_Marca);
            t_MarcaTableAdapter.Update(dSDatos.T_Marca);
            t_ModeloTableAdapter1.Update(dSDatos.T_Modelo);
        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Update();
        }

    }
}