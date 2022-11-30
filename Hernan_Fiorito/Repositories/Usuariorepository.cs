using System.Data.SqlClient;
using Hernan_Fiorito.Models;

namespace Hernan_Fiorito.Repositories
{
    public class Usuariorepository
    {
        private SqlConnection? conexion;
        private String cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;Database=harry9110_sistemagestion;User Id=harry9110_sistemagestion;Password=Emma9110..9110;";

        public Usuariorepository() 
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {

            }
        }

        public List<Usuario> ListaUsuarios()
        {
            List<Usuario> listaU = new List<Usuario>();
            if (conexion == null)
            {
                throw new Exception("Conexión no establecida");
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM usuario", conexion))
                {
                    conexion.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                       if(reader.HasRows)
                        {
                            while (reader.Read()) 
                            {
                                Usuario usuario = new Usuario();
                                usuario.id = long.Parse(reader["Id"].ToString());
                                usuario.nombre = reader["Nombre"].ToString();
                                usuario.apellido = reader["Apellido"].ToString();
                                usuario.nombreUsuario = reader["NombreUsuario"].ToString();
                                usuario.contrasenia = reader["Contraseña"].ToString();
                                usuario.mail = reader["Mail"].ToString();
                                listaU.Add(usuario);
                            }
                        }         
                        
                    }
                   
                }
                conexion.Close();
            }
            catch
            {
                throw;
            }

            return listaU;
        }


    }
}
