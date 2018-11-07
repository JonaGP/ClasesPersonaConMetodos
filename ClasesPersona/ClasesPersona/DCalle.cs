using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class DCalle
    {
        #region Atributos
        private int Persona_id;
        private string Calle;
        private int Numero;
        private int Persona_Persona_id;
        private int Barrio_Persona_id;
        private int Barrio_Persona_Persona_id;
        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public string _Calle
        {
            get { return Calle; }
            set { Calle = value; }
        }
        public int _Num
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public int _PersPersID
        {
            get { return Persona_Persona_id; }
            set { Persona_Persona_id = value; }
        }
        public int _BarPersID
        {
            get { return Barrio_Persona_id; }
            set { Barrio_Persona_id = value; }
        }
        public int _BarPersPersID
        {
            get { return Barrio_Persona_Persona_id; }
            set { Barrio_Persona_Persona_id = value; }
        }
        public DCalle()
        {
        }
        #endregion

        #region Constructor
        public DCalle(int _PersID,string _Calle, int _Num, int _PersPersID, int _BarPersID, int _BarPersPersID)
        {
            Persona_id = _PersID;
            Calle = _Calle;
            Numero = _Num;
            Persona_Persona_id = _PersPersID;
            Barrio_Persona_id = _BarPersPersID;
            Barrio_Persona_Persona_id = _BarPersPersID;
        }
        #endregion

      
    }
}
