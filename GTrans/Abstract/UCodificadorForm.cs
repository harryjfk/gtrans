using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace GTrans.Abstract
{
    public partial class CodificadorForm : CaptionWindow
    {
        public CodificadorForm(FrmMain main)
            : base(main)
        {
            InitializeComponent();
        }

        public CodificadorForm() 
        {
            InitializeComponent();
        }
        protected void ValidCellValue(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Value.ToString() == "")
                ((DataRow)((GridView)sender).GetDataRow(e.RowHandle))[e.Column.FieldName] = null;

        }
        protected  virtual void DoUpdate()
        {

        }
        protected void Update()
        {
            try
            {
                DoUpdate();
            }
            catch (Exception e) { 
                
                if(e.Message.IndexOf("insert duplicate key")>0)
                    XtraMessageBox.Show("No puede insertar un dato duplicado");
                else
                XtraMessageBox.Show("No puede eliminar un dato que es usado en otro lugar"); }

        }
        private void CodificadorForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
     

    }
}