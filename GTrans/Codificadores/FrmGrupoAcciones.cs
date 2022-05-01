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

namespace GTrans.Codificadores
{
    public partial class FrmGrupoAcciones : CodificadorForm
    {
        public FrmGrupoAcciones(FrmMain main):base (main)
        {
            InitializeComponent();
            SetTitleInfo((Bitmap)imageCollection1.Images[0], "Grupo de acciones", "Grupo de acciones");
        }

        private void FrmGrupoAcciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_GrupoAccion' Puede moverla o quitarla según sea necesario.
            this.t_GrupoAccionTableAdapter.Fill(this.dSDatos.T_GrupoAccion);
        //    dSDatos.T_GrupoAccion.namegrupoaccionColumn.DefaultValue = "";
         //   dSDatos.T_GrupoAccion.codigogrupoaccionColumn.DefaultValue = "";
        }

        private void treeList1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void controlNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if(e.Button.ButtonType==NavigatorButtonType.Append)
            {
                e.Handled = true;
                var n= new FrmNewAccion(Main);
                
                if(n.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
                {
                    tGrupoAccionBindingSource.AddNew();
                    tGrupoAccionBindingSource.MoveLast();
                    var d = n.Data;
                    if (d != null)
                        GrupoAccion.idparent = (int)d;
                }
                
            }
            else
                if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = true;
                tGrupoAccionBindingSource.RemoveCurrent();
                    try
                    {



                        t_GrupoAccionTableAdapter.Update(dSDatos.T_GrupoAccion);
                    }
                    catch(Exception w)
                    {
                        MessageBox.Show("No se puede eliminar este dato porque es usado en el sistema.");
                        t_GrupoAccionTableAdapter.Fill(dSDatos.T_GrupoAccion);
                    }
             
                }
        }
        public DSDatos.T_GrupoAccionRow GrupoAccion { get { return (DSDatos.T_GrupoAccionRow)((DataRowView)tGrupoAccionBindingSource.Current).Row; } }

        private void treeList1_ValidateNode(object sender, DevExpress.XtraTreeList.ValidateNodeEventArgs e)
        {
            try
            {
                DoUpdate();
                e.Valid = true;
            }
            catch (Exception) { e.Valid = false; }
            
        }
          protected override void DoUpdate()
        {
            tGrupoAccionBindingSource.EndEdit();
            t_GrupoAccionTableAdapter.Update(dSDatos.T_GrupoAccion);
        }

    }
}