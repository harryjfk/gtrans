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
    public partial class FrmPais : CodificadorForm
    {
        public FrmPais(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Países", "Países");
            gridView1.CellValueChanged += ValidCellValue;
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Pais' Puede moverla o quitarla según sea necesario.
            this.t_PaisTableAdapter.Fill(this.dSDatos.T_Pais);
            //dsDatos1.T_Pais
            Loaded();
        }
        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
        private void t_PaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_PaisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void FrmPais_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
    
        }

        protected override void DoUpdate()
        {
            t_PaisTableAdapter.Update(dSDatos.T_Pais);
        }

    }
}