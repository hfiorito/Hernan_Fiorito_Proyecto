using Hernan_Fiorito.Models;
using System.Data.SqlClient;

namespace Hernan_Fiorito.Repositories
{
    public class ProductoVendidoRepository
    {
        private SqlConnection? conexion;
        private String cadenaConexion = "Server=sql.bsite.net\\MSSQL2016;Database=harry9110_sistemagestion;User Id=harry9110_sistemagestion;Password=Emma9110..9110;";

        public ProductoVendidoRepository()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {

            }
        }

        public List<ProductoVendido> listaProductosVendidos()
        {
            List<ProductoVendido> listaPV = new List<ProductoVendido>();
            if(conexion == null)
            {
                throw new Exception("Conexión no establecida");
            }
            try
            {
                using(SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido",conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ProductoVendido pv = new ProductoVendido();
                                pv.id = long.Parse(reader["Id"].ToString());
                                pv.idProducto = int.Parse(reader["IdProducto"].ToString());
                                pv.stock = int.Parse(reader["Stock"].ToString());
                                pv.idVenta = int.Parse(reader["IdVenta"].ToString());
                                listaPV.Add(pv);
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
            
            
            return listaPV;
        }
    }
}
