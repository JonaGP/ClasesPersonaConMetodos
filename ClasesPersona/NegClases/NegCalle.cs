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
    public class NegCalle
    {
        #region metodos

        DatosCalle objDatosCalle = new DatosCalle();

        public int abmCalle(string accion, Calle objcalle)
        {
            return objDatosCalle.abmCalle(accion, objcalle);
        }
        #endregion
    }
}
