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

namespace GTrans.Graficos
{
    public partial class FrmGraficos : SaveableForm
    {
        public FrmGraficos(FrmMain main):base(main)
        {
            InitializeComponent();
        }
    }
}