﻿using System;
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
    public partial class FrmTipoTrabajo : CodificadorForm
    {
        public FrmTipoTrabajo(FrmMain main)
         : base(main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Tipo de trabajo", "Tipo de trabajo");
            gridView2.CellValueChanged += ValidCellValue;
        }

        public override void FillList()
        {
            DataSets.Add(dSDatos);
        }
    
 
        private void FrmTipoOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoTrabajo' Puede moverla o quitarla según sea necesario.
            this.t_TipoTrabajoTableAdapter.Fill(this.dSDatos.T_TipoTrabajo);
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
            Update();
        }

        private void CodifcadorPieFormulario_Aceptar(object sender)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        protected override void DoUpdate()
        {
            t_TipoTrabajoTableAdapter.Update(dSDatos.T_TipoTrabajo);
        }

    }
}