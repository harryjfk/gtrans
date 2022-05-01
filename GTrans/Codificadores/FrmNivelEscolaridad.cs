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
    public partial class FrmNivelEscolaridad : CodificadorForm
    {
        public FrmNivelEscolaridad(FrmMain main)
           : base(main)
        {
            InitializeComponent();
            gridView1.CellValueChanged += ValidCellValue;
        }
        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        private void t_NivelEscolaridadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_NivelEscolaridadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmNivelEscolaridad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_NivelEscolaridad' Puede moverla o quitarla según sea necesario.
            this.t_NivelEscolaridadTableAdapter.Fill(this.dSDatos.T_NivelEscolaridad);
            Loaded();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();

        }

        private void FrmNivelEscolaridad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
        }
        protected override void DoUpdate()
        {
            this.t_NivelEscolaridadTableAdapter.Update(this.dSDatos.T_NivelEscolaridad);
        }

    }
}