using System;
using System.Drawing;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using ACINOX.DBT.DSDllTableAdapters;

namespace GTrans.Abstract
{
    public partial class CaptionWindow : DevExpress.XtraEditors.XtraForm
    {
        public CaptionWindow()
        {
            InitializeComponent();
        }
        protected AdapterDeletedIncluder HelperAdapter = new AdapterDeletedIncluder();
        protected void ValidFechaDateEdit_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = (((DevExpress.XtraEditors.DateEdit)sender).DateTime.Year < 1900) || (((DevExpress.XtraEditors.DateEdit)sender).DateTime.Year > DateTime.Now.Year);
        }
        public CaptionWindow(FrmMain main)
        {
            InitializeComponent();
            Main = main;
            traceComponent1.ConnectionString = Properties.Settings.Default.GTransConnectionString;
            traceComponent1.User = Main.AuthenticatedUser.idusuario;
            traceComponent1.Acciones.Add(DataRowAction.Add, "Adicionó");
            traceComponent1.Acciones.Add(DataRowAction.Change, "Cambió");
            traceComponent1.Acciones.Add(DataRowAction.Delete, "Eliminó");
            traceComponent1.Tablas.Add("T_AccGrupoOperaciones", "grupo de operaciones");
            traceComponent1.Tablas.Add("T_AccOperaciones", "operación");
            traceComponent1.Tablas.Add("T_AccRol", "rol");
            traceComponent1.Tablas.Add("T_AccRolOperaciones", "operación de rol");
            traceComponent1.Tablas.Add("T_AccUsuario", "usuario");
            traceComponent1.Tablas.Add("T_AccUsuarioRol", "rol de usuario");
            traceComponent1.Tablas.Add("T_Almacen", "almacen");
            traceComponent1.Tablas.Add("T_AlmacenExistencia", "existencia de producto en almacen");
            traceComponent1.Tablas.Add("T_Pais", "pais");
            traceComponent1.Tablas.Add("T_Area", "área");
            traceComponent1.Tablas.Add("T_Categoria", "categoria");
            traceComponent1.Tablas.Add("T_Clasificacion", "clasificación");
            traceComponent1.Tablas.Add("T_Consumo", "registro de consumo");
            traceComponent1.Tablas.Add("T_ConsumoEquipo", "registro de consumo de equipo");
            traceComponent1.Tablas.Add("T_Empleado", "empleado");
            traceComponent1.Tablas.Add("T_Empleado_Forma", "forma de empleado");
            traceComponent1.Tablas.Add("T_Equipo", "equipo");
            traceComponent1.Tablas.Add("T_Empresa", "datos de la empresa");
            traceComponent1.Tablas.Add("T_Estado", "estado");
            traceComponent1.Tablas.Add("T_EstadoOrden", "estado de orden");
            traceComponent1.Tablas.Add("T_Estado_Tecnico", "estado técnico");
            traceComponent1.Tablas.Add("T_FormaPago", "forma de pago");
            traceComponent1.Tablas.Add("T_Generico", "genérico");
            traceComponent1.Tablas.Add("T_Marca", "marca");
            traceComponent1.Tablas.Add("T_Modelo", "modelo");
            traceComponent1.Tablas.Add("T_Moneda", "moneda");
            traceComponent1.Tablas.Add("T_NivelEscolaridad", "nivel de escolaridad");
            traceComponent1.Tablas.Add("T_OrdenSalario", "salario de orden de trabajo");
            traceComponent1.Tablas.Add("T_OrdenSurtido", "surtido de orden de trabajo");
            traceComponent1.Tablas.Add("T_OrdenTrabajo", "orden de trabajo");
            traceComponent1.Tablas.Add("T_Planificacion", "planificación");
            traceComponent1.Tablas.Add("T_Paralizado", "paralizado");
            traceComponent1.Tablas.Add("T_Producto", "producto");
            traceComponent1.Tablas.Add("T_Report", "reporte");
            traceComponent1.Tablas.Add("T_Trace", "trace");
            traceComponent1.Tablas.Add("T_UM", "unidad de medida");
            traceComponent1.Tablas.Add("T_Tipo_Equipo", "tipo de equipo");
            traceComponent1.Tablas.Add("T_Tipo_Marca", "tipo de marca");
            traceComponent1.Tablas.Add("T_Tipo_Matricula", "tipo de matrícula");
            traceComponent1.Tablas.Add("T_Tipo_Paralizado", "tipo de paralizado");
            traceComponent1.Tablas.Add("T_TipoCombustible", "tipo de combustible");
            traceComponent1.Tablas.Add("T_TipoMantenimiento", "tipo de mantenimiento");
            traceComponent1.Tablas.Add("T_TipoModeloAccion", "acción por modelo");
            traceComponent1.Tablas.Add("T_TipoModeloMant", "tipo de mantenimiento por modelo");
            traceComponent1.Tablas.Add("T_TipoTrabajo", "tipo de trabajo");
            traceComponent1.Tablas.Add("T_UEB", "UEB");
            traceComponent1.Tablas.Add("T_TipoVale", "tipo de vale");  
            traceComponent1.Tablas.Add("T_OrdenSurtidoMoneda", "Moneda de productos");
            traceComponent1.Tablas.Add("T_ValeExistencia", "Existencia de vales");
  
         }
        public void Loaded()
        {
            FillList();
           
            traceComponent1.LoadList();
        }

        public virtual void
        FillList()
        {
        }
        public List<DataSet> DataSets { get { return traceComponent1.DataSets; } }


        public FrmMain Main { get; set; }
        public void SetTitleInfo(Bitmap graph, String title,String text)
        {
            toppicture.Image = graph;
            toplabel.Text = text;
            Text = title;
        }

        private void CaptionWindow_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
           traceComponent1.Update();
        }

    }
}