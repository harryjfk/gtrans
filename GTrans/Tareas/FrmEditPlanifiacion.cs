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
using DevExpress.XtraScheduler;
using DevExpress.Utils.Menu;
using DevExpress.XtraScheduler.UI;
using GTrans.Codificadores;
using ACINOX.DBT.DSDllTableAdapters;
using DevExpress.XtraLayout.Utils;

namespace GTrans.Tareas
{
    public partial class FrmEditPlanifiacion : SaveableForm
    {
        SchedulerControl control;
        Appointment apt;
        bool openRecurrenceForm = false;
        int suspendUpdateCount;
        IDXMenuManager menuManager;
        EditPlanificacionController controller;

        public FrmEditPlanifiacion(FrmMain Main):base(Main)
        {
            InitializeComponent();
            var t = new AdapterDeletedIncluder();
            t.DoAdapter(tableAdapterManager1);
        }
        public FrmEditPlanifiacion(FrmMain aMain,SchedulerControl control, Appointment apt, bool openRecurrenceForm)
        {
            Main = aMain;
			this.openRecurrenceForm = openRecurrenceForm;
            this.controller = new EditPlanificacionController(control, apt);
			this.apt = apt;
			this.control = control;
			//
			// Required for Windows Form Designer support
			//
			SuspendUpdate();
			InitializeComponent();
			ResumeUpdate();

			UpdateForm();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        public EditPlanificacionController Controller { get { return controller; } }
        void UpdateForm()
        {
            SuspendUpdate();
            try
            {
                this.t_EquipoTableAdapter.Planificacion(this.dSDatos.T_Equipo);
                idequipoSpinEdit.EditValue = controller.ResourceId;
                fechaDateEdit.EditValue = controller.Start;
                fechafinDateEdit.EditValue = controller.End;
                simpleButton1.Visible = !controller.IsNewAppointment;
                DSDatos.T_OrdenTrabajoDataTable t = null;
                try
                {
                  t= t_OrdenTrabajoTableAdapter1.GetDataByPLan(controller.idPlanificacion);
                    simpleButton1.Text = t.Count == 0 ? "Generar Orden" : "Ver Orden";
          
                }
                catch (Exception e) { t = new DSDatos.T_OrdenTrabajoDataTable(); }
                   var s = controller.IsNewAppointment?"Añadir nueva planificación":"Editar planificación";
                SetTitleInfo((Bitmap)imageCollection1.Images[controller.IsNewAppointment ? 0 : 1], s, s);
                if( !controller.IsNewAppointment)
                idmodelomantSpinEdit.EditValue = controller.idModeloMant;

                layoutControlItem2.Visibility = controller.IsNewAppointment ? LayoutVisibility.Never : LayoutVisibility.Always;
                idequipoSpinEdit.Enabled =  t.Count == 0 || controller.IsNewAppointment;
                idmodelomantSpinEdit.Enabled = idequipoSpinEdit.Enabled;
                fechaDateEdit.Enabled = idequipoSpinEdit.Enabled;
                fechafinDateEdit.Enabled = idequipoSpinEdit.Enabled;
            }
            finally
            {
                ResumeUpdate();
            }
        }
        public void SetMenuManager(IDXMenuManager menuManager)
        {
            SetMenuManagerCore(Controls, menuManager);
            this.menuManager = menuManager;
        }
        void SetMenuManagerCore(Control.ControlCollection controls, IDXMenuManager menuManager)
        {
            int count = controls.Count;
            for (int i = 0; i < count; i++)
            {
                Control control = controls[i];
                SetMenuManagerCore(control.Controls, menuManager);
                BaseEdit baseEdit = control as BaseEdit;
                if (baseEdit == null)
                    continue;
                baseEdit.MenuManager = menuManager;
            }
        }
        protected void SuspendUpdate()
        {
            suspendUpdateCount++;
        }
        protected void ResumeUpdate()
        {
            if (suspendUpdateCount > 0)
                suspendUpdateCount--;
        }
        private void FrmEditPlanifiacion_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoModeloAccion' Puede moverla o quitarla según sea necesario.
            //this.t_TipoModeloAccionTableAdapter.Fill(this.dSDatos.T_TipoModeloAccion);
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Equipo' Puede moverla o quitarla según sea necesario.
           
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoModeloMant' Puede moverla o quitarla según sea necesario.
            //this.t_TipoModeloMantTableAdapter.Fill(this.dSDatos.T_TipoModeloMant);
            //// TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Planificacion' Puede moverla o quitarla según sea necesario.
            //this.t_PlanificacionTableAdapter.Fill(this.dSDatos.T_Planificacion);

        }

        protected AppointmentStorage Appointments { get { return control.Storage.Appointments; } }
        protected internal bool IsNewAppointment { get { return controller != null ? controller.IsNewAppointment : true; } }
        protected bool IsUpdateSuspended { get { return suspendUpdateCount > 0; } }
        public IDXMenuManager MenuManager { get { return menuManager; } }

        public DSDatos.T_TipoModeloMantRow TipoMantimiento { get { return (DSDatos.T_TipoModeloMantRow)((DataRowView)tTipoModeloMantBindingSource.Current).Row; } }
      
        public DSDatos.T_EquipoRow Equipo { get { return (DSDatos.T_EquipoRow)((DataRowView)tEquipoBindingSource.Current).Row; } }
        private void idequipoSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(idequipoSpinEdit.EditValue is int)
            {
                tEquipoBindingSource.Position = tEquipoBindingSource.Find("idequipo", idequipoSpinEdit.EditValue);
                t_TipoModeloMantTableAdapter.FillBy1(dSDatos.T_TipoModeloMant, Equipo.idmodelo);
                var s =  dSDatos.T_TipoModeloMant.Where(p => p.nametipomantenimiento == controller.GetLabel().DisplayName).ToList();
                if (s.Count > 0)
                    idmodelomantSpinEdit.EditValue = s[0].idtipomodelomant;
                else
                    idmodelomantSpinEdit.EditValue = dSDatos.T_TipoModeloMant[0].idtipomodelomant;
              }
        }

        private void idmodelomantSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (idmodelomantSpinEdit.EditValue is int)
            {
                t_TipoModeloAccionTableAdapter.FillBy(dSDatos.T_TipoModeloAccion, (int)idmodelomantSpinEdit.EditValue, "2");
                tTipoModeloMantBindingSource.Position = tTipoModeloMantBindingSource.Find("idtipomodelomant", idmodelomantSpinEdit.EditValue);
                Controller.idModeloMant = TipoMantimiento.idtipomodelomant;
                controller.End = controller.Start.AddDays(TipoMantimiento.cantdays);
                fechafinDateEdit.EditValue = controller.End;
            }
             
        }
        
        private void ucPieFormulario1_Aceptar(object sender)
        {
            

            if(dxValidationProvider1.Validate())
            {
                if ((int)t_PlanificacionTableAdapter.ScalarQuery((int)idequipoSpinEdit.EditValue, (DateTime)fechaDateEdit.EditValue, (DateTime)fechafinDateEdit.EditValue) !=0 && controller.IsNewAppointment)
                {
                    MessageBox.Show("No se puede establecer una nueva planificación en un mismo dia para un mismo equipo");
                    return;
                }
                controller.LabelId = TipoMantimiento.idtipomant - 1;
                 
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void fechafinDateEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
            if (fechaDateEdit.EditValue is DateTime)
            {
                e.Cancel = (DateTime)fechaDateEdit.EditValue > (DateTime)fechafinDateEdit.EditValue;
                fechafinDateEdit.ErrorText = e.Cancel ? "La fecha final de la planificación no puede ser menor que la inicial" : "";
            }
            else
            {
                if (fechafinDateEdit.EditValue is DateTime)
                {
                    e.Cancel = true;
                    fechafinDateEdit.ErrorText = "Por favor defina la fecha inicial antes de la final";
                }
            }
               

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
            FrmPlanificar.GenerateOrden(Main, (int)controller.ResourceId,controller.idPlanificacion);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var t = new FrmTipoMantenimiento(Main);
                t.ShowDialog(this);
                t.Dispose();
            }
        }

        private void FrmEditPlanifiacion_Shown(object sender, EventArgs e)
        {

            
        }

    }
    public class EditPlanificacionController : AppointmentFormController
    {

        public int idPlanificacion { get {


                return (int)EditedAppointmentCopy.CustomFields["Idplanificacion"];
          
            
            } set { EditedAppointmentCopy.CustomFields["Idmodelomant"] = value; } }
        //  public string CustomStatus { get { return (string)EditedAppointmentCopy.CustomFields["CustomStatus"]; } set { EditedAppointmentCopy.CustomFields["CustomStatus"] = value; } }

        public int SourceidPlanificacion
        {
            get
            {
                try
                { return (int)SourceAppointment.CustomFields["Idplanificacion"]; }
                catch (Exception) { return 1; }
            }
            set { SourceAppointment.CustomFields["Idplanificacion"] = value; }
        }
        public int idModeloMant { get { return (int)EditedAppointmentCopy.CustomFields["Idmodelomant"]; } set { EditedAppointmentCopy.CustomFields["Idmodelomant"] = value; } }
      //  public string CustomStatus { get { return (string)EditedAppointmentCopy.CustomFields["CustomStatus"]; } set { EditedAppointmentCopy.CustomFields["CustomStatus"] = value; } }

        public int SourceidModeloMant { get {
            try
            { return (int)SourceAppointment.CustomFields["Idmodelomant"]; }
            catch (Exception) { return 1; }
        }
            set { SourceAppointment.CustomFields["Idmodelomant"] = value; }
        }
       // string SourceCustomStatus { get { return (string)SourceAppointment.CustomFields["CustomStatus"]; } set { SourceAppointment.CustomFields["CustomStatus"] = value; } }

        public EditPlanificacionController(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
        }

        public override bool IsAppointmentChanged()
        {
            if (base.IsAppointmentChanged())
                return true;
            return idModeloMant != SourceidModeloMant 
                ;
        }

        protected override void ApplyCustomFieldsValues()
        {
            SourceidModeloMant = idModeloMant;
        
        }
    }
}