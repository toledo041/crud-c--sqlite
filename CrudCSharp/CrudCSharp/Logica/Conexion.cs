using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace CrudCSharp.Logica
{
    public class Conexion
    {
        private String BaseDatos;
        private static Conexion con = null;

        private Conexion() 
        {
            this.BaseDatos = "./Logica/escuela.db";
        }

        public SQLiteConnection crearConexion()
        {
            SQLiteConnection cadena = new SQLiteConnection();

            try {
                cadena.ConnectionString = "Data Source"+this.BaseDatos;
            } 
            catch (Exception e)
            {
                cadena = null;
                throw e;
            }
            return cadena;

        }

        public static Conexion getInstancia()
        {
            if(con ==null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
