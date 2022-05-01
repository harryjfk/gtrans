using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GTrans.Abstract;

namespace GTrans.Codificadores
{
    public partial class FrmFormaPago : CodificadorForm
    {
        public FrmFormaPago(FrmMain main)
         : base(main)
        {
            InitializeComponent();
            gridView1.CellValueChanged += ValidCellValue;
        }

        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_FormaPago' Puede moverla o quitarla según sea necesario.
            this.t_FormaPagoTableAdapter.Fill(this.dSDatos.T_FormaPago);
            Loaded();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void FrmFormaPago_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
        }
        protected override void DoUpdate()
        {
            t_FormaPagoTableAdapter.Update(dSDatos.T_FormaPago);
          
        }

    }
}