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
    public class NegCiudad
    {
        #region metodos

        DatosCiudad objDatosCiudad = new DatosCiudad();

        public int abmCiudad(string accion, Ciudad objciudad)
        {
            return objDatosCiudad.abmCiudad(accion, objciudad);
        }
        #endregion
    }
}
