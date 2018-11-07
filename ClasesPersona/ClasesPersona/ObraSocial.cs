using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class ObraSocial
    {
        #region Atributos
        private string Nombre_ObrSocial;
        private int Telefono;
        private int Persona_id;

        #endregion

        #region Propiedades
        public string _NombreObSocial
        {
            get { return Nombre_ObrSocial; }
            set { Nombre_ObrSocial = value; }
        }
        public int _Tel
        {
            get { return Telefono; }
            set { Telefono = value; }
        }
        public int _PersId
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public ObraSocial()
        {
        }
        #endregion

        #region Constructor
        public ObraSocial(string _NombreObSocial, int _Tel, int _PersId)
        {
            Nombre_ObrSocial = _NombreObSocial;
            Telefono = _Tel;
            Persona_id = _PersId;

        }
        #endregion

     
    }
}
