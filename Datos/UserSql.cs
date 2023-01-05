using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using UserLog.Models;
using UserLog.Conexion;

namespace UserLog.Datos
{
    public class UserSql
    {
        public Collection<Users> Listar()
        {
            SqlDataReader Lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            Collection<Users> UsersRegistrados = new Collection<Users>();
            try
            {
                string sql = "EXECUTE ConsultaUsers";
                con = Conexiones.crearInstancia().crearConexion();//String de Conexion
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                Lista = comando.ExecuteReader();
                //usuariosRegistrados
                while (Lista.Read())
                {
                    //Json
                    Users users = new Users();
                    //users.UsersClient = Lista["Users"].ToString();
                    users.Name = Lista["nombre"].ToString();
                    users.Id = int.Parse(Lista["id"].ToString());
                    users.Contrasenia = "qWERTY";
                    //users.Contrasenia = Lista["Contrasenia"].ToString();
                    //
                    UsersRegistrados.Add(users);
                }
                Lista.Close();
                //Tabla.Load(Lista);


                return UsersRegistrados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        public Users ConsultarId(int id)
        {
            SqlDataReader Lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            Users users = new Users();
            Collection<Users> UsersRegistrados = new Collection<Users>();
            try
            {
                string sql = "EXECUTE ConsultUserId @Id ="+id;
                con = Conexiones.crearInstancia().crearConexion();//String de Conexion
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                Lista = comando.ExecuteReader();
                //usuariosRegistrados
                while (Lista.Read())
                {
               
                    //users.UsersClient = Lista["Users"].ToString();
                    users.Name = Lista["nombre"].ToString();
                    users.Id = int.Parse(Lista["id"].ToString());
                    users.Contrasenia = "QWERTY";
                    //users.Contrasenia = Lista["Contrasenia"].ToString();
                    //// UsersRegistrados.Add(users);
                }
                Lista.Close();
                //Tabla.Load(Lista);


                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
    }
}
