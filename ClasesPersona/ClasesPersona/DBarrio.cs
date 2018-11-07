using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class DBarrio
    {
        #region Atributos
        private int Persona_id;
        private string Barrio;
        private string Localidad;
        private int Ciudad_Persona_id;

        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public string _Bar
        {
            get { return Barrio; }
            set { Barrio = value; }
        }
        public string _Local
        {
            get { return Localidad; }
            set { Localidad = value; }
        }
        public int _CiudadPersID
        {
            get { return Ciudad_Persona_id; }
            set { Ciudad_Persona_id = value; }
        }
        public DBarrio()
        {
        }
        #endregion

        #region Constructor
        public DBarrio(int _PersID, string _Bar, string _Local, int _CiudadPersID)
        {
            Persona_id = _PersID;
            Barrio = _Bar;
            Localidad = _Local;
            Ciudad_Persona_id = _CiudadPersID;
        }
        #endregion

     
    }
}
