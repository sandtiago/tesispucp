using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Control
{
    public class clsGestorBD
    {
        public static DataTable consultarStoredProcedure(String strNombreStoredProcedure, params object[] prmParametros)
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public static void ejecutarStoredProcedure(String strNombreStoredProcedure, params object[] prmParametros)
        {
            //foreach (object obj in prmParametros)
            //{
                
            //}
        }

        public static DataTable consultarSentencia(String strSentenciaSQL)
        {
            DataTable dt = new DataTable();

            return dt;
        }

        public static void ejecutarSentencia(String strSentenciaSQL)
        {

        }
    }
}
