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
    public class NegObraSocial
    {
        #region metodos

        DatosObraSocial objDatosObraSocial = new DatosObraSocial();

        public int abmObraSocial(string accion, ObraSocial objObrasocial)
        {
            return objDatosObrasocial.abmObraSocial(accion, objObrasocial);
        }
        #endregion
    }
}
