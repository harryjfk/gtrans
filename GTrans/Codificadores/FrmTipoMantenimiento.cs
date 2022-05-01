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
    public partial class FrmTipoMantenimiento : CodificadorForm
    {
        public FrmTipoMantenimiento (FrmMain main)
         : base(main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Tipo de mantenimiento", "Tipo de mantenimiento");
            gridView1.CellValueChanged += ValidCellValue;
        }
        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        private void FrmTipoMantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoMantenimiento' Puede moverla o quitarla según sea necesario.
            this.t_TipoMantenimientoTableAdapter.Fill(this.dSDatos.T_TipoMantenimiento);

        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Update();

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }
        protected override void DoUpdate()
        {
            t_TipoMantenimientoTableAdapter.Update(dSDatos.T_TipoMantenimiento);
 
        }

    }
}