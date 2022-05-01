using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GTrans.Abstract;

namespace GTrans.Opciones
{
    public partial class FrmTrazas : SaveableForm
    {
        public FrmTrazas(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            ucTraceControl1.ConnectionString = Properties.Settings
                .Default.GTransConnectionString;
        }
        
    }
}