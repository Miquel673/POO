using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Tienda
    {
        public List<Categoria> Categorias { get; set; }

        public Tienda()
        {
            Categorias = new List<Categoria>();

            // Crear categorías
            Categoria tecnologia = new Categoria("Tecnología", 0.12);
            Categoria alimentos = new Categoria("Alimentos", 0.23);

            // Agregar productos
            tecnologia.Productos.Add(new Producto("Celular MOTOROLA G15 256GB 4G Gris", 1245000, tecnologia.Nombre));
            tecnologia.Productos.Add(new Producto("Computador Portátil LENOVO 15.3 Pulgadas IdeaPad Slim 3 Táctil - Intel Core i5 - RAM 24GB - Disco SSD 512GB - Gris", 2700560, tecnologia.Nombre));
            tecnologia.Productos.Add(new Producto("TV KALLEY 60 Pulgadas 152.4 cm 60GQ400 4K UHD QLED Smart TV Google", 2670866, tecnologia.Nombre));

            alimentos.Productos.Add(new Producto("Manzana fresca", 2100, alimentos.Nombre));
            alimentos.Productos.Add(new Producto("Pan Tajado Bimbo", 3200, alimentos.Nombre));
            alimentos.Productos.Add(new Producto("Carton de Leche Alqueria", 3450, alimentos.Nombre));

            Categorias.Add(tecnologia);
            Categorias.Add(alimentos);
        }

        // Buscar un producto por nombre
        public Producto BuscarProducto(string nombre)
        {
            return Categorias
                .SelectMany(c => c.Productos)
                .FirstOrDefault(p => p.Nombre == nombre);
        }

        // Obtener descuento de su categoría
        public double ObtenerDescuento(string categoria)
        {
            return Categorias.First(c => c.Nombre == categoria).Descuento;
        }
    }

}
