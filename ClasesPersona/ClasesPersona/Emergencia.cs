using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class Emergencia
    {
        #region Atributos
        private int Persona_id;
        private string Nombre;
        private int Tel_Emergencia;
        private string Nombre_Emergencia;
        private string Apellido_Emerg;
        private string Direccion_Emerg;
        private int Persona_Persona_id;
        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public string _Nom
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int _TelEmerg
        {
            get { return Tel_Emergencia; }
            set { Tel_Emergencia = value; }
        }
        public string _NombreEmerg
        {
            get { return Nombre_Emergencia; }
            set { Nombre_Emergencia = value; }
        }
        public string _ApellidoEmerg
        {
            get { return Apellido_Emerg; }
            set { Apellido_Emerg = value; }
        }
        public string _DireccionEmerg
        {
            get { return Direccion_Emerg; }
            set { Direccion_Emerg = value; }
        }
        public int _PersonaPerID
        {
            get { return Persona_Persona_id; }
            set { Persona_Persona_id = value; }
        }
        public Emergencia()
        {
        }
        #endregion

        #region Constructor
        public Emergencia(int _PersID, string _Nom, int _TelEmerg, string _NombreEmerg, string _ApellidoEmerg, string _DireccionEmerg, int PersonaPerID)
        {
            Persona_id = _PersID;
            Nombre = _Nom;
            Tel_Emergencia = _TelEmerg;
            Nombre_Emergencia = _NombreEmerg;
            Apellido_Emerg = _ApellidoEmerg;
            Direccion_Emerg = _DireccionEmerg;
            Persona_Persona_id = _PersonaPerID;

        }
        #endregion

      
    }
}
