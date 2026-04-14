using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_8A
{
    internal class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca IdMarca { get; set; }
        //public Categoria IdCategoria { get; set; }
        public decimal Precio { get; set; }

        /*
        public Articulo(string codigo, string nombre, string descripcion, Marca idMarca, Categoria idCategoria, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            IdMarca = idMarca;
            IdCategoria = idCategoria;
            Precio = precio;
        }
        */
    }
}
    