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
    public partial class FrmTipoCombustible : CodificadorForm
    {
        public FrmTipoCombustible(FrmMain main)
         : base(main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Tipo de combustible", "Tipo de combustible");
            gridView2.CellValueChanged += ValidCellValue;
        }

        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
    
 
        private void FrmTipoOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoCombustible' Puede moverla o quitarla según sea necesario.
            this.t_TipoCombustibleTableAdapter.Fill(this.dSDatos.T_TipoCombustible);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoOrden' Puede moverla o quitarla según sea necesario.
           Loaded();

        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Update();
        }

        private void FrmTipoOrden_FormClosed(object sender, FormClosedEventArgs e)
        {
            Update();
          
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
        
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        protected override void DoUpdate()
        {
            t_TipoCombustibleTableAdapter.Update(dSDatos.T_TipoCombustible);
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DSDatos.T_TipoCombustibleRow row = (DSDatos.T_TipoCombustibleRow)((DataRowView)e.Row).Row;

            if (row.precio < 0)
            {
                e.Valid = false;

                e.ErrorText += "Debe entrar un valor válido para el campo precio.\n";
            }
        }

    }
}