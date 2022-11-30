namespace Hernan_Fiorito.Models
{
    public class ProductoVendido
    {
        public long id { get; set; }
        public int idProducto { get; set; }
        public int stock { get; set; }
        public int idVenta { get; set; }

        public ProductoVendido()
        {
            id = 0;
            idProducto = 0;
            stock = 0;
            idVenta = 0;
        }

        public ProductoVendido(long id, int idProducto, int stock, int idVenta)
        {
            this.id = id;
            this.idProducto = idProducto;
            this.stock = stock;
            this.idVenta = idVenta;
        }

        public override string ToString()
        {
            return id + " " + idProducto + " " + stock + " " + idVenta;
        }
    }
}
