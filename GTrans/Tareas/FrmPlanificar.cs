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
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using GTrans.Abstract;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Tareas
{
    public partial class FrmPlanificar : SaveableForm
    {
        public FrmPlanificar(FrmMain main)
            : base(main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPlanificar_Load(object sender, EventArgs e)
        {
            t_TipoMantenimientoTableAdapter1.Fill(dsDatos1.T_TipoMantenimiento);
            t_EquipoTableAdapter1.Planificacion(dsDatos1.T_Equipo);
            t_TipoModeloMantTableAdapter1.FillFull(dsDatos1.T_TipoModeloMant);
            t_ModeloTableAdapter1.Fill(dsDatos1.T_Modelo);
            schedulerControl1.Storage.Appointments.Labels.Clear();
            foreach (var t in dsDatos1.T_TipoMantenimiento)
            {
                var w = new AppointmentLabel(t.nametipomantenimiento);
                w.Color = Color.FromArgb(t.color);
                schedulerControl1.Storage.Appointments.Labels.Add(w);
            }
            // TODO: esta línea de código carga datos en la tabla 'dsDatos1.T_Planificacion' Puede moverla o quitarla según sea necesario.
            this.t_PlanificacionTableAdapter.FillBy1(this.dsDatos1.T_Planificacion);
            UpdateLabels();
               
        }
        private void UpdateLabels()
        {
            var q = new TimeInterval();
            q.Start = DateTime.MinValue;
            q.End = DateTime.MaxValue;

            foreach (var v in schedulerStorage1.GetAppointments(q))
            {
                var t = (DSDatos.T_PlanificacionRow)((DataRowView)schedulerStorage1.GetObjectRow(v)).Row;
                var s = schedulerStorage1.Appointments.Labels.Where(d => d.DisplayName == t.T_TipoModeloMantRow.nametipomantenimiento).ToList()[0];
                s.Color =Color.FromArgb( t.T_TipoModeloMantRow.T_TipoMantenimientoRow.color);
                v.LabelId = schedulerStorage1.Appointments.Labels.IndexOf(s);

            }

        }

       

        private void schedulerControl1_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e)
        {
            if (schedulerControl1.SelectedAppointments.Count == 0)
                return;
            if(e.Menu.Items.Count==6)
            {
                e.Menu.Items[3].Visible = false;
                e.Menu.Items[4].Caption = "Cambiar tipo de mantenimiento";
            }
            else
                e.Menu.Items[1].Visible = false;

            var t = t_OrdenTrabajoTableAdapter1.GetDataByPLan(SelectedPlanificacion.idplanificacion);
        
            var s = new DevExpress.Utils.Menu.DXMenuItem(t.Count==0? "Generar Orden de Trabajo":"Ver Orden Trabajo");
            e.Menu.Items[4].Visible = e.Menu.Items[4].Visible && t.Count == 0;
            e.Menu.Items[5].Visible = e.Menu.Items[4].Visible;
            s.BeginGroup = true;
            e.Menu.Items.Insert(2, s);
            s.Click += s_Click;
        }
        
        private int GetMantenimientoID(int label, int  idequipo)
        {
            var equipo = dsDatos1.T_Equipo.FindByidequipo(idequipo);
            var t = dsDatos1.T_TipoModeloMant.Where(p => p.idmodelo == equipo.idmodelo).ToList();
            return t[label].idtipomodelomant;
        }
        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            foreach (DevExpress.XtraScheduler.Appointment t in e.Objects)
              
                t.CustomFields["Idmodelomant"] = GetMantenimientoID(t.LabelId, (int)t.ResourceId);
            t_PlanificacionTableAdapter.Update(dsDatos1.T_Planificacion);
            dsDatos1.AcceptChanges();
        }
        public static void GenerateOrden(FrmMain Main,int equipo, int planificacion)
        {
               var t = (FrmOrdenTrabajo)Main.ShowForm(new FrmOrdenTrabajo(Main), false, Main.barButtonItem4);
            t.CreateNewOrden(equipo, planificacion);
     
        }

        void s_Click(object sender, EventArgs e)
        {

         //   if ((int)schedulerControl1.SelectedAppointments[0].CustomFields["Idplanificacion"] < 0)
              //(int)schedulerControl1.SelectedAppointments[0].GetRow().
            GenerateOrden(Main,SelectedPlanificacion.idequipo,SelectedPlanificacion .idplanificacion);

        }
        private DSDatos.T_PlanificacionRow SelectedPlanificacion { get { return ((DSDatos.T_PlanificacionRow)((DataRowView)schedulerStorage1.GetObjectRow(schedulerControl1.SelectedAppointments[0])).Row); } }
        private void schedulerControl1_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {
            Appointment apt = e.Appointment;
            bool openRecurrenceForm = apt.IsRecurring && schedulerStorage1.Appointments.IsNewAppointment(apt);

            var f = new FrmEditPlanifiacion(Main,(SchedulerControl)sender, apt, openRecurrenceForm);
            f.SetMenuManager(this.schedulerControl1.MenuManager);
            f.LookAndFeel.ParentLookAndFeel = this.LookAndFeel.ParentLookAndFeel;
            e.DialogResult = f.ShowDialog(this);
            e.Handled = true;

            if (e.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                f.Controller.ApplyChanges();
                if (apt.Type == AppointmentType.Pattern && schedulerControl1.SelectedAppointments.Contains(apt))
                    schedulerControl1.SelectedAppointments.Remove(apt);

              
                schedulerControl1.RefreshData();
                UpdateLabels();
            }
     
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var t = new FrmPlanificarRange(Main);
            if(t.ShowDialog(this)==System.Windows.Forms.DialogResult.OK)
            {
                dsDatos1.T_Planificacion.Generate((DateTime)t.startedit.EditValue, (DateTime)t.endedit.EditValue,t.equipo);
                schedulerControl1.RefreshData();
                UpdateLabels();
            }
            t.Dispose();
           
        }

     
    }
}