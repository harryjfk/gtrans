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
    public partial class FrmProductoCodif : CodificadorForm
    {
        public FrmProductoCodif (FrmMain main)
         : base(main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Codificador UM y monedas", "Permite gestionar las monedas y unidades de medidas de los productos");
        }

        private void FrmProductoCodif_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_UM' Puede moverla o quitarla según sea necesario.
            this.t_UMTableAdapter.Fill(this.dSDatos.T_UM);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Moneda' Puede moverla o quitarla según sea necesario.
            this.t_MonedaTableAdapter.Fill(this.dSDatos.T_Moneda);

        }

        private void gridView1_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Update();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void gridView2_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Update();
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }
        protected override void DoUpdate()
        {
            t_UMTableAdapter.Update(dSDatos.T_UM); t_MonedaTableAdapter.Update(dSDatos.T_Moneda);
        }
    }
}