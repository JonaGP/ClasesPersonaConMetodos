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
    public class NegDBarrio
    {
        #region metodos

        DatosBarrio objDatosDBarrio = new DatosBarrio();

        public int abmBarrio(string accion, DBarrio objbarrio)
        {
            return objDatosDBarrio.abmBarrio(accion, objbarrio);
        }
        #endregion
    }
}
