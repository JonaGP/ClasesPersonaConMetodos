using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class Provincia
    {
        #region Atributos
        private int Persona_id;
        private string Prov_Residencia;
        private int CodigoPostal;
        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public string _ProvResi
        {
            get { return Prov_Residencia; }
            set { Prov_Residencia = value; }
        }
        public int _CodPost
        {
            get { return CodigoPostal; }
            set { CodigoPostal = value; }
        }
        public Provincia()
        {
        }
        #endregion

        #region Constructor
        public Provincia(int _PersID, string _ProvResi, int _CodPost)
        {
            Persona_id = _PersID;
            Prov_Residencia = _ProvResi;
            CodigoPostal = _CodPost;
        }
        #endregion

    }
}
