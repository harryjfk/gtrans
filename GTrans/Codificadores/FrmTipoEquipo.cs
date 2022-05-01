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
    public partial class FrmTipoEquipo : CodificadorForm
    {
        public FrmTipoEquipo(FrmMain Main):base(Main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Tipos de equipo", "Tipos de equipo");
            gridView1.CellValueChanged += ValidCellValue;
            gridView2.CellValueChanged += ValidCellValue;
          
        }

        private void FrmTipoEquipo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Equipo' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_EquipoTableAdapter.Fill(this.dSDatos.T_Tipo_Equipo);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Categoria' Puede moverla o quitarla según sea necesario.
            this.t_CategoriaTableAdapter.Fill(this.dSDatos.T_Categoria);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void FrmTipoEquipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
        }
        protected override void DoUpdate()
        {
            t_CategoriaTableAdapter.Update(dSDatos.T_Categoria);
            t_Tipo_EquipoTableAdapter.Update(dSDatos.T_Tipo_Equipo);
        }

    }
}