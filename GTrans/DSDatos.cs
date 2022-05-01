using DevExpress.Spreadsheet;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet;
using GTrans.Tareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
namespace GTrans {
    
  
    public partial class DSDatos   {
        partial class T_ProductoGenericoDataTable
        {
            public void UpdateAll()
            {
                var almacen = new DSDatosTableAdapters.T_ProductoGenericoTableAdapter();
                var producs = new DSDatosTableAdapters.T_ProductoTableAdapter();
                var updated = new List<DSDatos.T_ProductoGenericoRow>();

                foreach(var item in this)
                    
                        if (item.idparent == null)
                        {
                            var t = updated.Where(p => p == item).ToList();
                            if (t.Count == 0)
                            {
                                var w = 0;
                                var c = getchilds(item.idproductogen);
                                if (item.RowState == DataRowState.Added)
                                {
                                    almacen.Insert(item.codigo, null);
                                    w = (int)almacen.Max();
                                }
                                else w = item.idproductogen;
                                updated.Add(item);
                                foreach (var item2 in c)
                                {
                                          item2.idparent = w;
                                          int w1 = 0;
                                          if (item2.RowState == DataRowState.Added)
                                          {
                                              almacen.Insert(item2.codigo, w);
                                              w1 = (int)almacen.Max();
                                          }
                                          else w1 = item2.idproductogen;
                                    
                                      
                                        updated.Add(item2);

                                        var prods = item2.GetT_ProductoRows();
                                        foreach (var p in prods)
                                            if (p.RowState == DataRowState.Added)
                                                if (producs.ScalarQuery1(p.descproducto, item.codigo + item2.codigo + p.codproducto) == 0)
                                                    producs.Insert(p.codproducto, p.descproducto, p.idum, p.idclasificacion, w1);
                                                else
                                                    p.Delete();
                                }
                            }
                      


                    }
              


            }
            public List<DSDatos.T_ProductoGenericoRow> getchilds(int p)
            {
                var t = new List<DSDatos.T_ProductoGenericoRow>() ;
                foreach (var item in this)
                    if(item.idparent!=null)
                        if (item.idparent is DSDatos.T_ProductoGenericoRow)
                        {
                            if (((DSDatos.T_ProductoGenericoRow)item.idparent).idproductogen == p)
                                t.Add(item);
                        }
                        else

                            if (item.idparent is Int32)
                                if (((int)item.idparent) == p)
                                    t.Add(item);
                return t;
            }

            
        }
         partial class T_ProductoGenericoRow
         {
             public T_ProductoGenericoRow Parent
             {
             get{
                 try
             {
               return   ((DSDatos)Table.DataSet).T_ProductoGenerico.Where(p => (p.idproductogen == (int)idparent)).ToList()[0];
             }
                 catch (Exception e) { return null; }
              
             }
             }
         }

        partial class T_ProductoDataTable
        {
            
            private DSDatos.T_ProductoGenericoRow getgrupo (string value2,string parent = null)
            {
                DSDatos.T_ProductoGenericoRow formapago = null;
                List<T_ProductoGenericoRow> e = null;
             DSDatos.T_ProductoGenericoRow    w = null;
             if (parent == null)
                 e = ((DSDatos)DataSet).T_ProductoGenerico.Where(p => (p.codigo == value2 && parent == null)).ToList();
             else
             {
                 e = new List<T_ProductoGenericoRow>();
                 foreach (var item in ((DSDatos)DataSet).T_ProductoGenerico)
                     if (item.Parent != null)
                         if (item.Parent.codigo == parent && item.codigo == value2)
                         {
                             e.Add(item);
                         }
                 if (e.Count == 0)

                     foreach (var item in ((DSDatos)DataSet).T_ProductoGenerico)
                         if (item.Parent == null)
                             if (item.codigo == parent)
                             {
                             w =item;
                                 break;
                             }

             
                  
             }
                if (parent==null)
                {
                    if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_ProductoGenerico.AddT_ProductoGenericoRow(value2, 0, null, "");
                else

             formapago = e[0];

                }
                else

                {
                if (e.Count == 0)
                       formapago = ((DSDatos)DataSet).T_ProductoGenerico.AddT_ProductoGenericoRow(value2, 0, w, "");
        else

             formapago = e[0];


                }



        
                return formapago;
            }
       
            private DSDatos.T_ClasificacionRow getClasificacion(String tipovale)
            {
                DSDatos.T_ClasificacionRow formapago = null;
                var e = ((DSDatos)DataSet).T_Clasificacion.Where(p => p.nameclasificacion == tipovale).ToList();

                if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_Clasificacion.AddT_ClasificacionRow(tipovale);
                else formapago = e[0];
                return formapago;
            }
            private DSDatos.T_UMRow getUm(String tipovale)
            {
                DSDatos.T_UMRow formapago = null;
                var e = ((DSDatos)DataSet).T_UM.Where(p => p.codum.Trim() == tipovale).ToList();

                if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_UM.AddT_UMRow("","",tipovale);
                else formapago = e[0];
                return formapago;
            }
            private bool ImportRow(Row row)
            {
                try
                {
                    if (row[0].Value.IsEmpty)
                        return true;
                    var t = this.Where(p => p.codcomplete == row[0].Value.ToString()).ToList();
                    DSDatos.T_UMRow um = getUm(row[2].Value.ToString());
                    DSDatos.T_ClasificacionRow tipovalue = getClasificacion(row[3].Value.ToString());
                    DSDatos.T_ProductoRow producto = null;
                    if(t.Count==0)
                    {
                        var gen1 = row[0].Value.ToString().Substring(0, 3);
                        var esp = row[0].Value.ToString().Substring(3, 3);
                        DSDatos.T_ProductoGenericoRow gen = getgrupo(gen1);
                        gen = getgrupo(esp,gen1);
                        producto = AddT_ProductoRow(row[0].Value.ToString().Substring(6), row[1].Value.ToString(), um, tipovalue, gen, "");
                    }
                    else
                    {
                        producto = t[0];
                        producto.idclasificacion = tipovalue.idclasificacion;
                        producto.descproducto = row[1].Value.ToString();
                        producto.idum = um.idum;
                    }


                  

                }
                catch (Exception e) { return false; }
                return true;
            }
            public bool ImportFromFile(String Filename)
            {
                var c = new SpreadsheetControl();
                c.LoadDocument(Filename);


                var ok = true;

                for (int i = 1; i <=c.Document.Worksheets[0].Rows.LastUsedIndex; i++)
                {
                    try
                    {
                        ok = ImportRow(c.Document.Worksheets[0].Rows[i]);
                    }
                    catch (Exception e) { ok = false; }

                    if (!ok)
                        break;
                }

                if (ok)
                {
                    Properties.Settings.Default.LastImportedProds = DateTime.Now;
                    Properties.Settings.Default.Save();
                    var adapters = new DSDatosTableAdapters.TableAdapterManager();

                    //var almacen = new DSDatosTableAdapters.T_ProductoGenericoTableAdapter();
                    //adapters.T_ProductoGenericoTableAdapter = almacen;
                    ((DSDatos)this.DataSet).T_ProductoGenerico.UpdateAll();
                    //var producto = new DSDatosTableAdapters.T_ProductoTableAdapter();
                    //adapters.T_ProductoTableAdapter = producto;
                    //var um = new DSDatosTableAdapters.T_UMTableAdapter();
                    //adapters.T_UMTableAdapter = um;
                    //var cl = new DSDatosTableAdapters.T_ClasificacionTableAdapter();
                    //adapters.T_ClasificacionTableAdapter = cl;
                 
                    ////almacen.Update((DSDatos)this.DataSet);
                    //adapters.UpdateAll((DSDatos)this.DataSet);
                    XtraMessageBox.Show("Se realizó la importación de manera satisfactoria.", "Importar", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);


                }
                else
                    XtraMessageBox.Show("Existen errores en el archivo de importación", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return ok;
            }
        }
    
        partial class T_AlmacenDataTable
        {

            private DSDatos.T_TipoValeRow getTipoVale(String tipovale)
            {
                DSDatos.T_TipoValeRow formapago = null;
                var e = ((DSDatos)DataSet).T_TipoVale.Where(p => p.nametipovale == tipovale).ToList();

                if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_TipoVale.AddT_TipoValeRow(tipovale);
                else formapago = e[0];
                return formapago;
            }
            private bool ImportRow(Row row)
            {
                try
                {
                    var t = this.Where(p => p.namealmacen == row[0].Value.TextValue).ToList();
                    //var f = getFormaPago(row[3].Value.TextValue);
                    //var tp = getTipotrabajo(row[2].Value.TextValue);
                    DSDatos.T_AlmacenRow empleado = null;
                    if (t.Count == 0)
                        empleado = AddT_AlmacenRow(row[0].Value.TextValue);
                    else
                    {
                        empleado = t[0];
                        empleado.namealmacen = row[0].Value.TextValue;
                    }
                    var fs = empleado.GetT_AlmacenExistenciaRows().Where(p => p.vale ==row[1].Value.TextValue).ToList();
                    DSDatos.T_TipoValeRow tipovalue = getTipoVale(row[3].Value.TextValue);
                    DSDatos.T_AlmacenExistenciaRow almacenexistencia = null;
                    if (fs.Count == 0)
                    {
                        almacenexistencia=((DSDatos)DataSet).T_AlmacenExistencia.AddT_AlmacenExistenciaRow(empleado, row[1].Value.TextValue, tipovalue, row[2].Value.DateTimeValue);
                    }
                    else
                    {
                        almacenexistencia = fs[0];
                    }
                    DSDatos.T_ProductoRow productorow = getProducto(row[4].Value.NumericValue.ToString());
             
                    var fs1 = almacenexistencia.GetT_ValeExistenciaRows().Where(p => p.idproducto == productorow.idproducto).ToList();
                       DSDatos.T_ValeExistenciaRow prodexest = null;
                    if (fs1.Count == 0)
                    {
                        prodexest = ((DSDatos)DataSet).T_ValeExistencia.AddT_ValeExistenciaRow(productorow, row[5].Value.NumericValue,almacenexistencia);
                    }
                    else
                    {
                        prodexest = fs1[0];
                    }
                    DSDatos.T_MonedaRow monedarow = getMoneda(row[6].Value.TextValue);
                    var fs2 = prodexest.GetT_ValeExistenciaMonedaRows().Where(p => p.idmoneda == monedarow.idmoneda).ToList();
                    DSDatos.T_ValeExistenciaMonedaRow valemon = null;
                    if (fs2.Count == 0)
                    {
                      ((DSDatos)DataSet).T_ValeExistenciaMoneda.AddT_ValeExistenciaMonedaRow(prodexest, row[7].Value.NumericValue, monedarow);
                    }
                    //else
                    //{
                    //    prodexest = fs2[0];
                    //}
                       
                }
                catch (Exception e) { return false; }
                return true;
            }


            private DSDatos.T_ProductoRow getProducto(String producto)
            {
                DSDatos.T_ProductoRow formapago = null;
                var e = ((DSDatos)DataSet).T_Producto.Where(p => p.codcomplete == producto).ToList();

                //if (e.Count == 0)
                //    formapago = ((DSDatos)DataSet).T_TipoTrabajo.AddT_TipoTrabajoRow(nametipo);
                //else 
                formapago = e[0];
                return formapago;
            }
            private DSDatos.T_MonedaRow getMoneda(String moneda)
            {
                DSDatos.T_MonedaRow formapago = null;
                var e = ((DSDatos)DataSet).T_Moneda.Where(p => p.namemoneda == moneda).ToList();

                if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_Moneda.AddT_MonedaRow(moneda);
                else formapago = e[0];
                return formapago;
            }

            public bool ImportFromFile(String Filename)
            {
                var c = new SpreadsheetControl();
                c.LoadDocument(Filename);


                var ok = true;

                for (int i = 1; i <= c.Document.Worksheets[0].Rows.LastUsedIndex; i++)
                {
                    try
                    {
                        ok = ImportRow(c.Document.Worksheets[0].Rows[i]);
                    }
                    catch (Exception e) { ok = false; }

                    if (!ok)
                        break;
                }
             
                if (ok)
                {
                    Properties.Settings.Default.LastImportedAlmacen = DateTime.Now;
                    Properties.Settings.Default.Save();
                    var adapters = new DSDatosTableAdapters.TableAdapterManager();
                    adapters.UpdateOrder = DSDatosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
                    var almacen = new DSDatosTableAdapters.T_AlmacenTableAdapter();
                    adapters.T_AlmacenTableAdapter = almacen;
                    var almacenexistencia = new DSDatosTableAdapters.T_AlmacenExistenciaTableAdapter();
                    adapters.T_AlmacenExistenciaTableAdapter = almacenexistencia;
               
                    adapters.UpdateAll((DSDatos)this.DataSet);

                    var valeexist = new DSDatosTableAdapters.T_ValeExistenciaTableAdapter();

                    adapters.T_ValeExistenciaTableAdapter = valeexist;
                    foreach (var item in ((DSDatos)this.DataSet).T_ValeExistencia)
                        if(item.idvaleproducto<0)
                    {
                        item.SetAdded();
                    }
                  adapters.UpdateAll((DSDatos)this.DataSet);   var valeexistm = new DSDatosTableAdapters.T_ValeExistenciaMonedaTableAdapter();
                    adapters.T_ValeExistenciaMonedaTableAdapter = valeexistm;
                    adapters.UpdateAll((DSDatos)this.DataSet);
                    XtraMessageBox.Show("Se realizó la importación de manera satisfactoria.", "Importar", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
                else
                    XtraMessageBox.Show("Existen errores en el archivo de importación", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return ok;
            }
        }
    
        partial class F_GetPossibleWorkersDataTable
        {
            public bool HasSelected(int idorden)
            {
                return this.Where(p => p.idorden == idorden && p._checked).ToList().Count == 0;

            }
            public void Update()
            {
                var t = new DSDatosTableAdapters.F_GetPossibleWorkersTableAdapter();
                foreach (var item in this)
                    if (item._checked)
                        t.P_UpdateWork(item.idempleado, item.idempleadoposs, item.idorden);
            }

            internal bool IsComplete()
            {
             var ordenes =    this.GroupBy(p => p.idorden).ToList();
             foreach (var item in ordenes)
                 if (HasSelected(item.Key))
                     return false;
             return true;
            }
        }
    
        partial class T_EmpleadoDataTable
        {
            
            private DSDatos.T_FormaPagoRow getFormaPago(String nameforma)
            {
                DSDatos.T_FormaPagoRow formapago = null;
                var e = ((DSDatos)DataSet).T_FormaPago.Where(p => p.nameformapago == nameforma).ToList();
      
                if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_FormaPago.AddT_FormaPagoRow(nameforma);
                else formapago = e[0];
                return formapago;
            }
            private bool ImportRow(Row row)
            {
                try
                {
                    if (row[0].Value.ToString().Trim() == "")
                        return true;
                    var n = row[0].Value.ToString();
                var t = this.Where(p => p.codempleado == n).ToList();
                  var f= getFormaPago(row[3].Value.ToString());
                  var tp = getTipotrabajo(row[2].Value.ToString());
                  DSDatos.T_EmpleadoRow empleado = null;
                  if (t.Count == 0)
                      empleado = AddT_EmpleadoRow(row[1].Value.ToString(), null, null, null, "", row[0].Value.ToString(), tp);
                  else
                  {
                      empleado = t[0];
                      empleado.nameempleado = row[1].Value.ToString();
                    }
              var fs= empleado.GetT_Empleado_FormaRows().Where(p=>p.idforma==f.idformapago).ToList();
                if(fs.Count==0)
                {
                    ((DSDatos)DataSet).T_Empleado_Forma.AddT_Empleado_FormaRow(empleado, f, double.Parse(row[4].Value.ToString()));
                }
                else
                    fs[0].tarifa = double.Parse( row[4].Value.ToString());
                }
                catch (Exception e) { return false; }
            return true;
            }

 
          private DSDatos.T_TipoTrabajoRow getTipotrabajo(String nametipo)
            {
                DSDatos.T_TipoTrabajoRow formapago = null;
                var e = ((DSDatos)DataSet).T_TipoTrabajo.Where(p => p.nametipotrabajo == nametipo).ToList();
      
                if (e.Count == 0)
                    formapago = ((DSDatos)DataSet).T_TipoTrabajo.AddT_TipoTrabajoRow(nametipo);
                else formapago = e[0];
                return formapago;
            }

            public bool ImportFromFile(String Filename)
            {
                var c = new SpreadsheetControl();
                c.LoadDocument(Filename);


                var ok = true;

                for (int i = 1; i < c.Document.Worksheets[0].Rows.LastUsedIndex; i++)
                {
                    try
                    {
                        ok = ImportRow(c.Document.Worksheets[0].Rows[i]);
                    }
                    catch (Exception e) { ok = false; }

                    if (!ok)
                        break;
                }
                var employerased = new List<DSDatos.T_EmpleadoRow>();

                if(ok)
                foreach (var item in this)
                {
                    var mising = c.Document.Worksheets[0].Search(item.codempleado, new SearchOptions() { SearchIn = SearchIn.Values, SearchBy = SearchBy.Rows }).ToList().Where(p => p.DisplayText == item.codempleado).ToList();
                  if (mising.Count == 0)
              //     if(item.idempleado==3)
                      employerased.Add(item);
                
                }
                DSDatos.F_GetPossibleWorkersDataTable up =null;
               if(employerased.Count>0)
               {
                //   employerased.Add()
                   var deleted = new FrmDeletedWorker();
                   deleted.List = employerased;
                   if(deleted.NeedShow())
                   {
                   ok = (deleted.ShowDialog() == System.Windows.Forms.DialogResult.OK);
                       up =deleted.dSDatos.F_GetPossibleWorkers;
                       }

               }
                if (ok)
                {
                    Properties.Settings.Default.LastImportedTrab = DateTime.Now;
                    Properties.Settings.Default.Save();
                    var adapters = new DSDatosTableAdapters.TableAdapterManager();

                    var empleados = new DSDatosTableAdapters.T_EmpleadoTableAdapter();
                    adapters.T_EmpleadoTableAdapter = empleados;
                    var empleadosforma = new DSDatosTableAdapters.T_Empleado_FormaTableAdapter();
                    adapters.T_Empleado_FormaTableAdapter = empleadosforma;
                    var formas = new DSDatosTableAdapters.T_FormaPagoTableAdapter();
                    adapters.T_FormaPagoTableAdapter = formas;
                    var trabajos = new DSDatosTableAdapters.T_TipoTrabajoTableAdapter();
                    adapters.T_TipoTrabajoTableAdapter = trabajos;
                    adapters.UpdateAll((DSDatos)this.DataSet);
                    if (up != null)
                        up.Update();
                        var delet = new DSDatosTableAdapters.QueriesTableAdapter();
                        foreach (var item in employerased)
                            delet.P_DeleteObject("T_Empleado", "idempleado", item.idempleado);
                   
                    XtraMessageBox.Show("Se realizó la importación de manera satisfactoria.", "Importar", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                }
                else
                    XtraMessageBox.Show("Existen errores en el archivo de importación", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return ok;
            }
         
        }


        public  Dictionary<String, Component> GetAdapters(List<string> Tables)
        {
            var s = GetType().Namespace+"."+DataSetName + "TableAdapters";
            var r = new Dictionary<string, Component>();
            foreach (var item in Tables)
            {
                var adapter = Type.GetType(s + "." + item + "TableAdapter");
                if (adapter!=null)
                {
                    var cs= adapter.GetConstructors();
                 var t=  (Component) cs[0].Invoke(new object[]{});
                 r.Add(item, t);

                }
            }
            return r;
        }
        partial class T_OrdenSurtidoDataTable
        {
        }
        partial class T_AlmacenExistenciaRow
        {
            public double Existencia()
            {
                double r = 0.0;
                foreach (var i in GetT_ValeExistenciaRows())
                    r += i.existencia;

                return r;
            }

        }
        partial class T_OrdenSurtidoRow
        {
            public void GetImporte()
            {
                importe = 0;
                foreach (var item in GetT_OrdenSurtidoMonedaRows())
                    importe += unidades * item.precio;
           
            }
        }
        partial class T_OrdenSalarioRow
        {
            public void GetImporte()
            {

                importe = tarifa * horasorden;
            }
        }
        partial class T_OrdenTrabajoDataTable
        {
           public int LastNoOrden()
            {
           
                int r = 0;
                foreach (T_OrdenTrabajoRow row in Rows)
                    if (r < row.noorden)
                        r = row.noorden;
                return r + 1;
            }
        }
        partial class T_PlanificacionDataTable
        {
       
            public void Generate(DateTime inicio ,DateTime fin, int? idEquipo = null)
            {
                var mantenimientos = new DSDatosTableAdapters.T_TipoModeloMantTableAdapter();
                mantenimientos.FillFull(((DSDatos)DataSet).T_TipoModeloMant);
                var medias = new DSDatosTableAdapters.F_EquiposAvGTableAdapter();
                medias.Fill(((DSDatos)DataSet).F_EquiposAvG,inicio.Date,fin.Date,idEquipo);
                var planificacionadapter= new DSDatosTableAdapters.T_PlanificacionTableAdapter();

                var lastorden = planificacionadapter.FechaOrdenes();
                DateTime fstarts = lastorden==null? inicio:lastorden<inicio?inicio:(DateTime)lastorden;
               
               var delete= this.Where(p => p.fecha > fstarts || p.fechafin > fstarts).ToList();
               foreach (var item in delete)
               {
                   planificacionadapter.Delete(item.idplanificacion);
                   Rows.Remove(item);
               }
           

               DateTime fstart = fstarts;
             
                               foreach (var t in ((DSDatos)DataSet).F_EquiposAvG)
                               {

                                   fstart = fstarts;
                                   var w = ((DSDatos)DataSet).T_TipoModeloMant.Where(q => q.idmodelo == t.T_EquipoRow.idmodelo).OrderByDescending(q => q.valor).ToList();
                                   var it = t.consumototal / w[w.Count - 1].valor;
                                   var consumovirtual = 0.0;
                                   while (fstart < fin)

                                       for (int i = 0; i < it; i++)
                                       {
                                           consumovirtual += w[w.Count - 1].valor;
                                           foreach (var s in w)
                                               if (consumovirtual % s.valor == 0)
                                               {
                                                   var row = NewT_PlanificacionRow();
                                                   row.idequipo = t.idequipo;
                                                   row.idmodelomant = s.idtipomodelomant;
                                                   row.fecha = fstart.AddDays(consumovirtual / t.media);
                                                   row.fechafin = row.fecha.AddDays(s.cantdays);
                                                  
                                                   AddT_PlanificacionRow(row);
                                                   fstart = row.fechafin;
                                                   if (fstart > fin)
                                                       break;
                                               }
                                       }
                               }

            }

        }
    }
}

namespace GTrans.DSDatosTableAdapters {
    partial class T_MarcaTableAdapter
    {
      
    }
    
    
    public partial class T_TipoMantenimientoTableAdapter {
    }
}
