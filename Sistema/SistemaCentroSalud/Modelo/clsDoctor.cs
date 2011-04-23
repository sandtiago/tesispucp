using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class clsDoctor : clsPersonal
    {
        private string strCMP;

        public string StrCMP
        {
            get { return strCMP; }
            set { strCMP = value; }
        }
        private int numIndicadorHP; //0: Indica que el Dr. va a ver la ventana Historia Clínica con todos los campos
                                    //1: Indica que el Dr. va a ver la ventana Historia Clínica con campos mínimos

        public int NumIndicadorHP
        {
            get { return numIndicadorHP; }
            set { numIndicadorHP = value; }
        }
    }
}
