using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Net;
namespace UserLog.Conexion
{
    public class Conexiones
    {
        //Bases SQL CONECT
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        //Conexion
        private bool Seguridad;

        //Object Conexion 
        private static Conexiones con = null;

        private Conexiones()
        {
            this.Base = "dataCenterDijecs";
            this.Servidor = "DESKTOP-3HJ08Q0\\SQLEXPRESSCENT";
            this.Usuario = "sa";
            this.Clave = "Dilmag2008$";
            this.Seguridad = false;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server =" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
                //cadena.Open();

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
                //MessageBox.Show("Erro" + ex);
            }



            return cadena;
        }
        public static Conexiones crearInstancia()
        {
            if (con == null)
            {
                con = new Conexiones();
            }
            return con;
        }
    }
}
 
