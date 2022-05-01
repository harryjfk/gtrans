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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraCharts;
using GTrans.Abstract;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmConsumo : SaveableForm
    {
        public FrmConsumo(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
        t.DoAdapter(tableAdapterManager1);
        }

        private void FrmConsumo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Estado' Puede moverla o quitarla según sea necesario.
            this.t_EstadoTableAdapter.Fill(this.dSDatos.T_Estado);

            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Empresa' Puede moverla o quitarla según sea necesario.
            this.t_EmpresaTableAdapter.Fill(this.dSDatos.T_Empresa);
            t_UEBTableAdapter1.Fill(dSDatos.T_UEB);
            t_AreaTableAdapter1.Fill(dSDatos.T_Area);
            t_EquipoTableAdapter1.Fill(dSDatos.T_Equipo);
        }

        private DSDatos.T_ConsumoRow Consumo { get { return (DSDatos.T_ConsumoRow)((DataRowView)tConsumoBindingSource.Current).Row;} }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var edit = new FrmEditConsumo();
            edit.SetTitleInfo((Bitmap)imageCollection1.Images[e.Item.ImageIndex], "", "");

            if ((bool)e.Item.Tag == true)
                edit.edit = -1;
            else
                edit.edit = Consumo.idconsumo;
            if(edit.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            {
                var t = tConsumoBindingSource.Position;
                Focused = _focused;
                tConsumoBindingSource.Position = t;

            }
        }

        private void tConsumoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            barButtonItem2.Enabled =  tConsumoBindingSource.Current !=null;
            barButtonItem3.Enabled = barButtonItem2.Enabled;
            //barButtonItem4.Enabled = barButtonItem2.Enabled;
            if(barButtonItem2.Enabled)
            {
                barButtonItem3.Caption = Consumo.idestado == 1 ? "Eliminar" : "Cancelar";
                barButtonItem3.Enabled = Consumo.idestado != 3;
                //barButtonItem4.Enabled = Consumo.idestado == 2;
            }
               
        }
        private object _focused;
        public object Focused { get { return _focused; } set { _focused = value;
        
            int i =-1;
            string s = "";
            if(_focused is DSDatos.T_EmpresaRow)
            {
                i = ((DSDatos.T_EmpresaRow)_focused).id_empresa;
                s = "0";
            }
            else
                if (_focused is DSDatos.T_UEBRow)
                {
                    i = ((DSDatos.T_UEBRow)_focused).id_ueb;
                    s = "1";
                }
                else
                    if (_focused is DSDatos.T_AreaRow)
                    {
                        i = ((DSDatos.T_AreaRow)_focused).id_area;
                        p_GraficoGastoPorAreaCombTableAdapter.Fill(dSGraficos.P_GraficoGastoPorAreaComb, new DateTime(DateTime.Now.Year, 1, 1), new DateTime(DateTime.Now.Year, 12, 31), i);
                        s = "2";
                    }
                    else
                        if (_focused is DSDatos.T_EquipoRow)
                        {
                            i = ((DSDatos.T_EquipoRow)_focused).idequipo;
                            s = "3";
                        }
            t_ConsumoTableAdapter.FillBy(dSDatos.T_Consumo, i, s);
            t_ConsumoEquipoTableAdapter1.FillByConsumo(dSDatos.T_ConsumoEquipo, i, s);

            //p_YearsConsumnTableAdapter1.Fill(dsReporte1.P_YearsConsumn, DateTime.Now,int.Parse(s), i);
            //chartControl1.Series.Clear();
            //foreach (var t in dsReporte1.P_YearsConsumn)
            //{
            //    var w = chartControl1.Series.Where(p => p.Name == "serie_" + t.year).ToList();
            //    Series serie = null;

            //    if (w.Count == 0)
            //    {
            //        serie = new Series("serie_" + t.year,ViewType.ScatterLine);
            //        serie.LegendText = t.year.ToString();
            //        chartControl1.Series.Add(serie);
            //    }
            //    else
            //        serie = (Series)w[0];
            //    serie.Points.Add(new SeriesPoint(t.mes, t.valor));
            //}
        } }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Focused = ((GridView)sender).GetDataRow(e.RowHandle);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
       
         //   popupMenu1.ShowPopup(barManager1,Screen.);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Consumo.idestado == 1)
            {
                if (XtraMessageBox.Show("Esta seguro que desea eliminar este registro de consumo", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    tConsumoBindingSource.RemoveCurrent();
                    t_ConsumoTableAdapter.Update(dSDatos.T_Consumo);
                }
            }
            else

                if (XtraMessageBox.Show("Esta seguro que desea cancelar este registro de consumo", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var t = new FrmCancelarConsumo();
                    t.SetTitleInfo((Bitmap)imageCollection1.Images[barButtonItem3.ImageIndex], "Cancelar", "Cancelar Consumo");
                    t.edit = Consumo.idconsumo;
                    if (t.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        var w = tConsumoBindingSource.Position;
                        Focused = _focused;
                        tConsumoBindingSource.Position = w;
                    }
                }
        }

        private void tEmpresaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Focused = ((DataRowView)tEmpresaBindingSource.Current).Row;
        }
    }
}