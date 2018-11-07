using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersona
{
    public class Persona
    {
        #region Atributos
        private int Persona_id;
        private int DNI;
        private string Nombre;
        private string Apellido;
        private int Edad;
        private string Sexo;
        private string EstadoCivil;
        private string EMail;
        private int Celular;
        private int TelFijo;
        private DateTime FechaNacimiento;
        private string Nacionalidad;
        private string ProvNacimiento;
        #endregion

        #region Propiedades
        public int _PersID
        {
            get { return Persona_id; }
            set { Persona_id = value; }
        }
        public int _Dni
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public string _Nom
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string _Apelli
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public int _Eda
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public string _Sex
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public string _EstadoCi
        {
            get { return EstadoCivil; }
            set { EstadoCivil = value; }
        }
        public string _EMai
        {
            get { return EMail; }
            set { EMail = value; }
        }
        public int _Celu
        {
            get { return Celular; }
            set { Celular = value; }
        }
        public int _TelFij
        {
            get { return TelFijo; }
            set { TelFijo = value; }
        }
        public DateTime _FechaNac
        {
            get { return FechaNacimiento; }
            set { FechaNacimiento = value; }
        }
        public string _Nacio
        {
            get { return Nacionalidad; }
            set { Nacionalidad = value; }
        }
        public string _ProvNac
        {
            get { return ProvNacimiento; }
            set { ProvNacimiento = value; }
        }
        public Persona()
        {
        }
        #endregion

        #region Constructor
        public Persona(int _PersID, int _Dni,string _Nom, string _Apelli, int _Eda, string _Sex, string _EstadoCi, string _EMai, int _Celu, int _TelFij, DateTime _FechaNac, string _Nacio, string _ProvNac)
        {
            Persona_id = _PersID;
            DNI = _Dni;
            Nombre = _Nom;
            Apellido = _Apelli;
            Edad = _Eda;
            Sexo = _Sex;
            EstadoCivil = _EstadoCi;
            EMail = _EMai;
            Celular = _Celu;
            TelFijo = _TelFij;
            FechaNacimiento = _FechaNac;
            Nacionalidad = _Nacio;
            ProvNacimiento = _ProvNac;
        }
        #endregion

        
    }
}
