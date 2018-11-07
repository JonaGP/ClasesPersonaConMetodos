using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DatosClases;
using ClasesPersona;


namespace NegClases
{
     public class negPersona
     {
        #region metodos

        DatosPersona objDatosPersona = new DatosPersona();

        public int abmPersona(string accion, Persona objpersona)
        {
            return objDatosPersona.abmPersona(accion, objpersona);
        }
        #endregion

     }
}
