using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public double Descuento { get; set; }   // ejemplo: 0.12 = 12%
        public List<Producto> Productos { get; set; }

        public Categoria(string nombreProducto, double descuentoProducto)
        {
            Nombre = nombreProducto;
            Descuento = descuentoProducto;
            Productos = new List<Producto>();
        }
    }

}
