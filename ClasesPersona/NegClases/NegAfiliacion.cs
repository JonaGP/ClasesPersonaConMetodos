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
    public class NegAfiliacion
    {
        #region metodos

        DatosAfiliacion objDatosAfiliacion = new DatosAfiliacion();

        public int abmAfiliacion(string accion, Afiliacion objafiliacion)
        {
            return objDatosAfiliacion.abmAfiliacion(accion, objafiliacion);
        }
        #endregion
    }
}
