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
    public class NegEmergencia
    {
        #region metodos

        DatosEmergencia objDatosEmergencia = new DatosEmergencia();

        public int abmEmergencia(string accion, Emergencia objEmergencia)
        {
            return objDatosEmergencia.abmEmergencia(accion, objEmergencia);
        }
        #endregion
    }
}
