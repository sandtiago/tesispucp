using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsPersonal : clsPersona
    {
        private string strUsuario;

        public string StrUsuario
        {
            get { return strUsuario; }
            set { strUsuario = value; }
        }
        private string strContrasena;

        public string StrContrasena
        {
            get { return strContrasena; }
            set { strContrasena = value; }
        }
        private string strEstado;

        public string StrEstado
        {
            get { return strEstado; }
            set { strEstado = value; }
        }
    }
}
