using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class Ciudad
    {
        #region Atributos
        private int Persona_id;
        private string Nombre_Ciudad;
        private int Provincia_Persona_id;
        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public string _NomCiu
        {
            get { return Nombre_Ciudad; }
            set { Nombre_Ciudad = value; }
        }
        public int _ProviPersID
        {
            get { return Provincia_Persona_id; }
            set { Provincia_Persona_id = value; }
        }
        public Ciudad()
        {
        }
        #endregion

        #region Constructor
        public Ciudad(int _PersID, string _NomCiu, int _ProviPersID)
        {
            Persona_id = _PersID;
            Nombre_Ciudad = _NomCiu;
            Provincia_Persona_id = _ProviPersID;
        }
        #endregion

     
    }
}
