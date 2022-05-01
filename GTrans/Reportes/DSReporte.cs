namespace GTrans.Reportes {
    
    
    public partial class DSReporte {
        partial class P_ReporteOrdenTrabajoDataTable
        {
            private string getReplace(string str)
            {
               return  str.Replace("\r\n", " , ");
            }

            public void ReplaceActivitades()
            {
                foreach (var s in this)
                {
                    s.actividades =getReplace( s.actividades) ;
                    s.actividadesreal = getReplace(s.actividadesreal);
                }


            }
        }
    }
}
