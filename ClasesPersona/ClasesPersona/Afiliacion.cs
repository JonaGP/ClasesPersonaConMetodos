using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class Afiliacion
    {
        #region Atributos
        private int Persona_id;
        private DateTime FechaVencimiento;
        private string NumAfiliado;
        private int ObraSocialID;
        private int PersonaPersonaID;
        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public DateTime _FechaVEnci
        {
            get { return FechaVencimiento; }
            set { FechaVencimiento = value; }
        }
        public string _NumAfi
        {
            get { return NumAfiliado; }
            set { NumAfiliado = value; }
        }
        public int _ObraSocioID
        {
            get { return ObraSocialID; }
            set { ObraSocialID = value; }
        }
        public int _PersonaPerID
        {
            get { return PersonaPersonaID; }
            set { PersonaPersonaID = value; }
        }

        public Afiliacion()
        {
        }
        #endregion

        #region Constructor
        public Afiliacion(int _PersID, DateTime _FechaVenci, string _NumAfi, int _ObraSocioID, int _PersonaPerID)
        {
            Persona_id = _PersID;
            FechaVencimiento = _FechaVenci;
            NumAfiliado = _NumAfi;
            ObraSocialID = _ObraSocioID;
            PersonaPersonaID = _PersonaPerID;
           
        }
        #endregion

      
    }
}
