using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ClasesPersona;

namespace DatosClases
{
    public class DatosCalle : DatosConexionDB
    {
        public int abmCalle(string accion, DCalle objcalle)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into";
            if (accion == "Modificar")
                orden = "update";


            MySqlCommand cmd = new MySqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(" Error al tratar de guardar o modificar Calle", e);


            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }
    }
}
