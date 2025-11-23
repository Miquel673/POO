using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Categoria { get; set; }

        public Producto(string nombre, int precio, string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
    }

}
