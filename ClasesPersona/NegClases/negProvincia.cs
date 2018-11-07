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
    public class NegProvincia
    {
        #region metodos

        DatosProvincia objDatosProvincia = new DatosProvincia();

        public int abmProvincia(string accion, Provincia objprovincia)
        {
            return objDatosProvincia.abmProvincia(accion, objprovincia);
        }
        #endregion
    }
}
