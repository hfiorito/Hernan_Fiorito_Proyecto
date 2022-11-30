using System.Data.SqlClient;
using Hernan_Fiorito.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hernan_Fiorito.Repositories
{
    public class VentasRepository
    {
        private SqlConnection? conexion;
        private String cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;Database=harry9110_sistemagestion;User Id=harry9110_sistemagestion;Password=Emma9110..9110;";

        public VentasRepository()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {

            }
        }

        public List<Venta> listaVentas()
        {
            List<Venta> lista = new List<Venta>();
            if (conexion == null)
            {
                throw new Exception("Conexión no establecida");
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Venta", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Venta ventas = new Venta();
                                ventas.id = long.Parse(reader["Id"].ToString());
                                ventas.comentarios = reader["Comentarios"].ToString();
                                ventas.idUsuario = int.Parse(reader["IdUsuario"].ToString());
                                lista.Add(ventas);
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return lista;
        }
    }
}
