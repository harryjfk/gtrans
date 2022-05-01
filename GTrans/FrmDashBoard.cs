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
using GTrans.Graficos;
using DevExpress.XtraCharts;

namespace GTrans
{
    public partial class FrmDashBoard : DevExpress.XtraEditors.XtraForm
    {
        public FrmDashBoard()
        {
            InitializeComponent();
            p_GraficoEquiposMedianosTableAdapter.Fill(dSGraficos.P_GraficoEquiposMedianos,DateTime.Now, 2);
            p_GraficoEquiposMedianosTableAdapter.Fill(dsGraficos1.P_GraficoEquiposMedianos,DateTime.Now, 1);
            SetGraph(chartControl1,dSGraficos.P_GraficoEquiposMedianos);
            SetGraph(chartControl2,dsGraficos1.P_GraficoEquiposMedianos);

        }
        private void SetGraph(ChartControl chartControl, DSGraficos.P_GraficoEquiposMedianosDataTable equipos)
        {
            chartControl.Series.Clear();
            foreach (var item in equipos)
            {

                Series serie = (Series)chartControl.Series.Where(p => p.Name == item.name).FirstOrDefault();
                if (serie == null)
                {

                    serie = new Series(item.name, ViewType.Line);
                    chartControl.Series.Add(serie);
                    serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                }
                serie.Points.Add(new SeriesPoint(item.trimestre, item.valor));


            }

           }
    }
}