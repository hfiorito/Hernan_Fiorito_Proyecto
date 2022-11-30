﻿namespace Hernan_Fiorito.Models
{
    public class Venta
    {
        public long id { get; set; }
        public string comentarios { get; set; }
        public int idUsuario { get; set; }


        public Venta()
        {
            id = 0;
            comentarios = "";
            idUsuario = 0;

        }

        public Venta(long id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }


        public override string ToString()
        {
            return id + " " + comentarios;
        }

    }
}
