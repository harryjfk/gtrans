using ACINOX.Components;
using ACINOX.Components.Forms;
using ACINOX.DBT;
using ACINOX.DBT.DSDllTableAdapters;
using ACINOX.Forms;
using ACINOX.Functions;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraReports.UI;
using GMI.Forms.Opciones;
using GTrans.Abstract;
using GTrans.Codificadores;
using GTrans.Graficos;
using GTrans.Graficos.DSGraficosTableAdapters;
using GTrans.Opciones;
using GTrans.Reportes;
using GTrans.Reportes.DSReporteTableAdapters;
using GTrans.Tareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTrans
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
          private DSDll.T_AccUsuarioRow user;
        public DSDll.T_AccUsuarioRow AuthenticatedUser
        {
            get { return user; }
            set
            {
                user = value;
                UserLabel.Caption = value.Nombre;
               // barStaticItem1.Caption = value.Nombre;
                UCRepManager.FillGroup(ribbonPageGroup9, Properties.Settings.Default.GTransConnectionString, value.idusuario,12,CustomReportClick);
                new Controls.RestrictAccess(this,value.idusuario,Properties.Settings.Default.GTransConnectionString);
                

            }
        }
         private void CustomReportClick(object sender, ItemClickEventArgs e)
        {

            var dataset = new DSDatos();
            UCRepManager.CreateReport(dataset,(int)e.Item.Tag, Properties.Settings.Default.GTransConnectionString.ToString());
            //CreateForm(new FrmEmpresa(), e.Item);
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        public Form ShowForm(Form form, bool dialog = false, BarItem item = null)
        {
            Form s = null;

            if (form is SaveableForm || form is FrmUserManager || form is FrmReportManager || form is FrmDashBoard)
            {
                var t = MdiChildren.Where(p => p.GetType() == form.GetType()).ToList();
                if (t.Count > 0)
                    s = t[0];

                if (s == null)
                {
                    form.MdiParent = this;
                    s = form;
                }
            }
            else

                s = form;
            s.FormClosed += ChildClosed;
            if (s is CaptionWindow)
                if(item!=null)
                ((CaptionWindow)s).SetTitleInfo((Bitmap)imageCollection1.Images[item.LargeImageIndex],item.Caption ,item.Hint);
            if (s is SaveableForm || form is FrmUserManager || form is FrmReportManager || form is FrmDashBoard|| form is FrmReportes /* || form is FrmIncidenciasEquipo*/)
            {
                s.Show();
                s.BringToFront();
                CheckPageChanged();
            }
            else


                s.ShowDialog(this);
            return s;
        }
        private void ChildClosed(object sender, FormClosedEventArgs e)
        {
            CheckPageChanged(true);
        }
        private void CheckPageChanged(bool resta=false)
        {
            //GraphControl.Visible = MdiChildren.Length == 0 && barButtonItem76.Down;
            backgroundimg.Visible = resta ? MdiChildren.Length == 1: MdiChildren.Length == 0;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new FrmEstructura(this),false,e.Item);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new FrmEquipo(this),false,e.Item);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new FrmEmpleado(this), false, e.Item);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new FrmConsumo(this), false, e.Item);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new FrmPlanificar(this), false, e.Item);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowForm(new FrmOrdenTrabajo(this), false, e.Item);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(new FrmAlmacen(this), false, e.Item);
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(new FrmProductos(this), false, e.Item);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(new FrmTrazas(this), false, e.Item);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var save = new FSave { Save = true, Connection = Properties.Settings.Default.GTransConnectionString };
            save.ShowDialog(this);
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            var save = new FSave { Save = false, Connection = Properties.Settings.Default.GTransConnectionString };
            save.ShowDialog(this);
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            var repman = new FrmReportManager();
            repman.ucRepManager1.ConnectionString = Properties.Settings.Default.GTransConnectionString;
            repman.ucRepManager1.User = AuthenticatedUser.idusuario;
            ShowForm(repman);
          
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  var conn = new ConnectionString();
            var frmuser = new FrmUserManager { ucUser1 = {  /*User = AuthenticatedUser,*/  } };
            //ACINOX.ConnectionUpdate.UpdateConnection(Properties.Settings.Default.GMIConnectionString);
            frmuser = ((FrmUserManager)ShowForm(frmuser));
            frmuser.ucUser1.FormName = Name;
            frmuser.ucUser1.Connection.Connection = Properties.Settings.Default.GTransConnectionString;
            frmuser.ucUser1.Logging = LogType.UserGroup;
            frmuser.Text = "Grupo de usuario";
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            //  var conn = new ConnectionString(Properties.Settings.Default.GMIConnectionString);
            var frmuser = new FrmUserManager { ucUser1 = { /*User = AuthenticatedUser,*/  } };
            frmuser.ucUser1.FormName = Name;
            frmuser = ((FrmUserManager)ShowForm(frmuser));
            frmuser.ucUser1.Connection.Connection = Properties.Settings.Default.GTransConnectionString;
            frmuser.ucUser1.Logging = LogType.UsersMg;
            frmuser.Text = "Rol Usuario";
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCUser.ChangePass(AuthenticatedUser, Properties.Settings.Default.GTransConnectionString);
        }

        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Properties.Settings.Default.Skin = e.Item.Caption;
            Properties.Settings.Default.Save();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep = new FrmDateRangeForm(this);
            patrep.TypeReport = (int)e.Item.Tag;
            ShowForm(patrep, true, e.Item);
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                var graficos = (FrmGraficos)ShowForm(new FrmGraficos(this),false, e.Item);
                var dsgrafico = new DSGraficos();

                switch (patrep.TypeReport)
                {
                    case 0:
                        {
                            var local = new P_GraficoEquiposEstadoTableAdapter();
                            local.Fill(dsgrafico.P_GraficoEquiposEstado, patrep.FechaInicial, patrep.FechaFinal, 1);
                            if (dsgrafico.P_GraficoEquiposEstado.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");

                                return;
                            }

                            graficos.chartControl.Series.Clear();
                            foreach (var item in dsgrafico.P_GraficoEquiposEstado)
                                if (item.estado == "Baja" || item.estado == "Paralizado")
                            {

                                Series serie = (Series)graficos.chartControl.Series.Where(p => p.Name == item.estado).FirstOrDefault();
                                if (serie == null)
                                {

                                    serie = new Series(item.estado, ViewType.Line);
                                    //serie.ArgumentScaleType = ScaleType.Numerical;
                                    graficos.chartControl.Series.Add(serie);
                                    serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                                }
                                serie.Points.Add(new SeriesPoint(item.namemes, item.c));


                            }

                            graficos.chartControl.Titles.Clear();
                        //    graficos.chartControl.Titles.Add(new ChartTitle() { Text = "Variación de los elementos de costo" });


                            break;
                        }
                    case 1:
                        {
                            var local = new P_GraficoEquiposEstadoTableAdapter();
                            local.Fill(dsgrafico.P_GraficoEquiposEstado, patrep.FechaInicial, patrep.FechaFinal,2);
                            if (dsgrafico.P_GraficoEquiposEstado.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");

                                return;
                            }

                            graficos.chartControl.Series.Clear();
                            foreach (var item in dsgrafico.P_GraficoEquiposEstado)
                                if (item.estado == "Avería")
                            {

                                Series serie = (Series)graficos.chartControl.Series.Where(p => p.Name == item.estado).FirstOrDefault();
                                if (serie == null)
                                {

                                    serie = new Series(item.estado, ViewType.Line);
                                    graficos.chartControl.Series.Add(serie);
                                    serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                                }
                                serie.Points.Add(new SeriesPoint(item.namemes, item.c));


                            }

                            graficos.chartControl.Titles.Clear();
                        //    graficos.chartControl.Titles.Add(new ChartTitle() { Text = "Variación de los elementos de costo" });
                            break;
                        }
                    case 2:
                        {
                            var local = new P_GraficoEquiposEstadoTableAdapter();
                            local.Fill(dsgrafico.P_GraficoEquiposEstado, patrep.FechaInicial, patrep.FechaFinal, 3);
                            if (dsgrafico.P_GraficoEquiposEstado.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");

                                return;
                            }

                            graficos.chartControl.Series.Clear();
                            foreach (var item in dsgrafico.P_GraficoEquiposEstado)
                            {

                                Series serie = (Series)graficos.chartControl.Series.Where(p => p.Name == item.estado).FirstOrDefault();
                                if (serie == null)
                                {

                                    serie = new Series(item.estado, ViewType.Line);
                                    graficos.chartControl.Series.Add(serie);
                                    serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                                }
                                serie.Points.Add(new SeriesPoint(item.namemes, item.c));


                            }

                            graficos.chartControl.Titles.Clear();
                      //      graficos.chartControl.Titles.Add(new ChartTitle() { Text = "Variación de los elementos de costo" });
                            break;

                        }
                    case 3:
                        {
                            var local = new P_GraficoGastoPorAreaCombTableAdapter();
                            local.Fill(dsgrafico.P_GraficoGastoPorAreaComb, patrep.FechaInicial, patrep.FechaFinal,null);
                            if (dsgrafico.P_GraficoGastoPorAreaComb.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");
                                return;
                            }
                            graficos.chartControl.Series.Clear();
                            foreach (var item in dsgrafico.P_GraficoGastoPorAreaComb)
                            {

                                Series serie = (Series)graficos.chartControl.Series.Where(p => p.Name == item.nombre_area).FirstOrDefault();
                                if (serie == null)
                                {

                                    serie = new Series(item.nombre_area, ViewType.Line);
                                    graficos.chartControl.Series.Add(serie);
                                    serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                                }
                                serie.Points.Add(new SeriesPoint(item.namemes, item.cantidad));


                            }


                            break;
                        }
                    case 4:
                        {
                            var local = new P_GraficoExistenciaProductosTableAdapter();
                            local.Fill(dsgrafico.P_GraficoExistenciaProductos, patrep.FechaInicial, patrep.FechaFinal);
                            if (dsgrafico.P_GraficoExistenciaProductos.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");
                                return;
                            }
                            graficos.chartControl.Series.Clear();
                            foreach (var item in dsgrafico.P_GraficoExistenciaProductos)
                            {

                                Series serie = (Series)graficos.chartControl.Series.Where(p => p.Name == item.prod).FirstOrDefault();
                                if (serie == null)
                                {

                                    serie = new Series(item.prod, ViewType.Line);
                                    graficos.chartControl.Series.Add(serie);
                                    serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                                }
                                serie.Points.Add(new SeriesPoint(item.mes, item.valor));


                            }


                            break;
                        }
                    case 5:
                        {
                            var local = new P_GraficoEstadoOrdensTableAdapter();
                            local.Fill(dsgrafico.P_GraficoEstadoOrdens, patrep.FechaInicial, patrep.FechaFinal);
                            if (dsgrafico.P_GraficoEstadoOrdens.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");
                                return;
                            }
                            graficos.chartControl.Series.Clear();
                            Series serie = new Series("", ViewType.Pie);
                            graficos.chartControl.Series.Add(serie);
                            serie.DataSource = dsgrafico.P_GraficoEstadoOrdens;
                            serie.ValueScaleType = ScaleType.Numerical;
                            serie.ArgumentDataMember = "estado";
                            serie.ValueDataMembers.AddRange(new string[] { "valor" });

                            ((PiePointOptions)((PieSeriesLabel)serie.Label).PointOptions).ValueNumericOptions.Format = NumericFormat.Percent;
                            ((PiePointOptions)serie.LegendPointOptions).PercentOptions.ValueAsPercent = false;
                            ((PiePointOptions)serie.LegendPointOptions).ValueNumericOptions.Format = NumericFormat.Number;
                            serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                            break;
                        }
                    case 6:
                        {
                            var local = new P_GraficoGastoOrdenTableAdapter();
                            local.Fill(dsgrafico.P_GraficoGastoOrden, patrep.FechaInicial, patrep.FechaFinal);
                            if (dsgrafico.P_GraficoGastoOrden.Count == 0)
                            {
                                graficos.Close();
                                XtraMessageBox.Show("No existen datos para mostrar");
                                return;
                            }
                            graficos.chartControl.Series.Clear();
                            Series serie = new Series("", ViewType.Pie);
                            graficos.chartControl.Series.Add(serie);
                            serie.DataSource = dsgrafico.P_GraficoGastoOrden;
                            serie.ValueScaleType = ScaleType.Numerical;
                            serie.ArgumentDataMember = "Tipo";
                            serie.ValueDataMembers.AddRange(new string[] { "gasto" });
                            ((PiePointOptions)((PieSeriesLabel)serie.Label).PointOptions).ValueNumericOptions.Format = NumericFormat.Percent;
                            ((PiePointOptions)serie.LegendPointOptions).PercentOptions.ValueAsPercent = false;
                            ((PiePointOptions)serie.LegendPointOptions).ValueNumericOptions.Format = NumericFormat.Currency;
                            serie.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                            break;
                        }

                }
            

            

            }
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep = (FrmEquiposReport)ShowForm(new FrmEquiposReport(this), true, e.Item);
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var dsReport = new DSReporte();
                var local = new P_ReporteEquiposTableAdapter();
                //var t = new AdapterDeletedIncluder();
                //var l = new List<Component>();
                //l.Add(local);
                //t.DoAdapterList(l);

                local.Fill(dsReport.P_ReporteEquipos, patrep.Area, patrep.UEB, patrep.Empresa);

                var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\FichaEquipos.repx", dsReport.P_ReporteEquipos, null);
         
            }
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep = (FrmEquipoConsumo)ShowForm(new FrmEquipoConsumo(this), true, e.Item);
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var dsReport = new DSReporte();
                var local = new P_ReporteHistorialConsumoTableAdapter();
                local.Fill(dsReport.P_ReporteHistorialConsumo,  patrep.Equipo);

                var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\HistorialConsumo.repx", dsReport.P_ReporteHistorialConsumo, null);

            }
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep = (FrmDateRangeForm)ShowForm(new FrmDateRangeForm(this), true, e.Item);
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var dsReport = new DSReporte();
                var local = new P_ReporteGastoPorAreaCombTableAdapter();
                local.Fill(dsReport.P_ReporteGastoPorAreaComb, patrep.FechaInicial, patrep.FechaFinal);

                var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\GastoPorAreaComb.repx", dsReport.P_ReporteGastoPorAreaComb, null);

            }
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep = new FrmPlantillaReport(this);
            if (!(bool)e.Item.Tag)
           ShowForm(patrep, true, e.Item);
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK || (bool)e.Item.Tag)
            {
                var dsReport = new DSReporte();
                var local = new P_ReportePlantillaTableAdapter();
                local.Fill(dsReport.P_ReportePlantilla, patrep.Oficio, patrep.NivelEscolaridad);

                var report = (FrmReportes)ShowForm(new FrmReportes(this), false,e.Item);
             report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Plantilla.repx", dsReport.P_ReportePlantilla, null);

            }
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dsReport = new DSReporte();
            var local = new P_ReporteProductosTableAdapter();
            local.Fill(dsReport.P_ReporteProductos);

            var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Producto.repx", dsReport.P_ReporteProductos, null);

        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep = new FrmAlmacenReport(this);
            patrep.value = (bool)e.Item.Tag;
            ShowForm(patrep, true, e.Item);
            
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var dsReport = new DSReporte();
                if (patrep.value)
                {
                    var local = new P_ReporteAlmacenProductosTableAdapter();
                    local.Fill(dsReport.P_ReporteAlmacenProductos, patrep.TipoVale);

                    var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                    report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Almacen.repx", dsReport.P_ReporteAlmacenProductos, null);
                }
                else
                {
                    var local = new P_ReporteHistorialProductosTableAdapter();
                    local.Fill(dsReport.P_ReporteHistorialProductos, patrep.Producto);

                    var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                    report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\HistorialProducto.repx", dsReport.P_ReporteHistorialProductos, null);
     
                }

            }
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            var patrep =new FrmOrdenReport(this);
          //  patrep.layoutControlItem3.Visibility=(bool)e.Item.Tag ==false?LayoutVisibility.Always:LayoutVisibility.Never;
            ShowForm(patrep, true, e.Item);
            if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var encabezado = new DSReporte();
                var plansu = new DSReporte();
                var plansa = new DSReporte();
                var realsu = new DSReporte();
                var realsa = new DSReporte();
                var local = new P_ReporteOrdenTrabajoTableAdapter();
            
                local.Fill(encabezado.P_ReporteOrdenTrabajo, patrep.Orden,null,0);
                local.Fill(plansa.P_ReporteOrdenTrabajo, patrep.Orden, null, 1);
                local.Fill(realsa.P_ReporteOrdenTrabajo, patrep.Orden, null, 2);
                local.Fill(plansu.P_ReporteOrdenTrabajo, patrep.Orden, null, 3);
                local.Fill(realsu.P_ReporteOrdenTrabajo, patrep.Orden, null, 4);
                encabezado.P_ReporteOrdenTrabajo.ReplaceActivitades();
                var plansurtido = new RepOrdenSurtido();
                plansurtido.DataSource = plansu.P_ReporteOrdenTrabajo;
                plansurtido.DataMember = "P_ReporteOrdenTrabajo";
                var realsurtido = new RepOrdenSurtido();
                realsurtido.DataSource = realsu.P_ReporteOrdenTrabajo;
                realsurtido.DataMember = "P_ReporteOrdenTrabajo";
                var plansalario = new RepOrdenSalario();
                plansalario.DataSource = plansa.P_ReporteOrdenTrabajo;
                plansalario.DataMember = "P_ReporteOrdenTrabajo";
                var realsalario = new RepOrdenSalario();
                realsalario.DataSource = realsa.P_ReporteOrdenTrabajo;
                realsalario.DataMember = "P_ReporteOrdenTrabajo";

                var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\OrdenTrabajo.repx", encabezado.P_ReporteOrdenTrabajo, null);

                ((XRSubreport)report.ucReport1.FReport.Bands[BandKind.Detail].Controls["xrSubreport1"]).ReportSource = plansurtido;
                ((XRSubreport)report.ucReport1.FReport.Bands[BandKind.Detail].Controls["xrSubreport2"]).ReportSource = realsurtido;
                ((XRSubreport)report.ucReport1.FReport.Bands[BandKind.Detail].Controls["xrSubreport3"]).ReportSource = plansalario;
                ((XRSubreport)report.ucReport1.FReport.Bands[BandKind.Detail].Controls["xrSubreport4"]).ReportSource = realsalario;


            }
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmPlanificarRange(this);
            if (t.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var w = new DSDatos();
                var equipos = new DSDatosTableAdapters.T_EquipoTableAdapter();
                var tipomant = new DSDatosTableAdapters.T_TipoMantenimientoTableAdapter();
                var tipomodelomant = new DSDatosTableAdapters.T_TipoModeloMantTableAdapter();
                equipos.Fill(w.T_Equipo);
                tipomant.Fill(w.T_TipoMantenimiento);
                tipomodelomant.Fill(w.T_TipoModeloMant);
                w.T_Planificacion.Generate((DateTime)t.startedit.EditValue, (DateTime)t.endedit.EditValue, t.equipo);
                var p = new DSReporte();
                foreach (var item in w.T_Planificacion)
                {
                    var q = p.P_Planificacion.NewP_PlanificacionRow();
                    q.color = item.T_TipoModeloMantRow.T_TipoMantenimientoRow.color;
                    q.equipo = item.T_EquipoRow.matricula;
                    q.fecha = item.fecha;
                    q.fechafin = item.fechafin;
                    q.nametipomantenimiento = item.T_TipoModeloMantRow.T_TipoMantenimientoRow.nametipomantenimiento;
                    p.P_Planificacion.AddP_PlanificacionRow(q);
                }
                var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
                report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\Planificacion.repx", p.P_Planificacion, null);

            }
            t.Dispose();
           
            //var patrep = new FrmDateRangeForm(this);
            //patrep.layoutControlItem3.Visibility = (bool)e.Item.Tag == false ? LayoutVisibility.Always : LayoutVisibility.Never;
            //ShowForm(patrep, true, e.Item);
            //if (patrep.DialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    var dsReport = new DSReporte();
            //    var local = new P_ReporteOrdenTrabajoTableAdapter();
            //    local.Fill(dsReport.P_ReporteOrdenTrabajo, patrep.FechaInicial, patrep.FechaFinal, patrep.TipoOrden);

            //    var report = (FrmReportes)ShowForm(new FrmReportes(this), true);
            //    report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\OrdenTrabajo.repx", dsReport.P_ReporteOrdenTrabajo, null);

            //}
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(new FrmAbout());
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Estadistica)
                barButtonItem28_ItemClick(sender, null);
            CheckForUpdate();
            var t = new FrmNeed();
            if (t.CanShow())
                t.ShowDialog(this);
        }
        private void NeedUpdate(DateTime date,String Msg)
        {
            var r = DateTime.Now.Subtract(date).Days > 7;
            if (r)
                MessageBox.Show(Msg);
        }
        private void CheckForUpdate()
        {
            NeedUpdate(Properties.Settings.Default.LastImportedTrab, "Se recomienda volver a importar los trabajadores ya que se encuentran desactualizados los registros.");
            NeedUpdate(Properties.Settings.Default.LastImportedProds, "Se recomienda volver a importar los productos ya que se encuentran desactualizados los registros.");
            NeedUpdate(Properties.Settings.Default.LastImportedAlmacen, "Se recomienda volver a importar los almacenes ya que se encuentran desactualizados los registros.");

        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = MdiChildren.Where(p=> p is FrmDashBoard).ToList();
            Properties.Settings.Default.Estadistica = t.Count == 0;
            Properties.Settings.Default.Save();
            if (t.Count > 0)
                t[0].Close();
            else
            {


                var d = new FrmDashBoard();

                ShowForm(d, false);
            }
            CheckPageChanged();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start(Application.StartupPath + @"\help.chm");
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmTipoTrabajo(this);
            t.ShowDialog(this);
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmTipoMantenimiento(this);
            t.ShowDialog(this);
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmTipoCombustible(this);
            t.ShowDialog(this);
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmParalizado(this);
            t.ShowDialog(this);
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmNivelEscolaridad(this);
            t.ShowDialog(this);
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmMarca();
            t.ShowDialog(this);
        }

        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmFormaPago(this);
            t.ShowDialog(this);
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmProductoCodif(this);
            t.ShowDialog(this);
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmTipoEquipo(this);
            t.ShowDialog(this);
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmGrupoAcciones(this);
            t.ShowDialog(this);
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            var t = new FrmPais(this);
            t.ShowDialog(this);
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            var encabezado = new DSReporte();
    
            var local = new P_ReporteOrdenTrabajoTableAdapter();
            local.Fill(encabezado.P_ReporteOrdenTrabajo,0, null, 5);
            var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\OrdenTrabajoS.repx", encabezado.P_ReporteOrdenTrabajo, null);

        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            var encabezado = new DSReporte();

            var local = new P_GrupoAccionesTableAdapter();
            local.Fill(encabezado.P_GrupoAcciones);
            var report = (FrmReportes)ShowForm(new FrmReportes(this), false, e.Item);
            report.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\GrupoAcciones.repx", encabezado.P_GrupoAcciones, null);

        }

    }
}
