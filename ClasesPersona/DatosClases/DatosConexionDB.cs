using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ClasesPersona;


namespace DatosConexion
{
    public class DatosConexionDB
    {
        public MySqlConnection conexion;

        public string cadenadeconexion = "datasource=localhost;port=3306;username=root;password=lleicoms123"; 

        public DatosConexionDB()
        {
            conexion = new MySqlConnection(cadenadeconexion);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexion ", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexion ", e);

            }
        }
    }
}
