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

namespace GTrans
{
    public partial class FrmNeed : CodificadorForm
    {
        public FrmNeed()
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Recursos necesarios", "Estos son los recursos necesarios para el dia de hoy y el de mañana ");
            p_GetResourcesTableAdapter.Fill(dSReporte.P_GetResources, DateTime.Now);
            p_GetResourcesTableAdapter.Fill(dsReporte1.P_GetResources, DateTime.Now.AddDays(1));
           
        }
        public bool CanShow()
        {
            return dSReporte.P_GetResources.Count > 0 || dsReporte1.P_GetResources.Count > 0;
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
    }
}