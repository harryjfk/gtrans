using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GTrans.Opciones
{
    public partial class FrmReportManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmReportManager()
        {
            InitializeComponent();
        }

        private void FrmReportManager_Load(object sender, EventArgs e)
        {
            ucRepManager1.dataset = dsDatos1;
        }
    }
}