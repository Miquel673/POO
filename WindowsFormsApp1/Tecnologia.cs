using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDescuentos.Clases
{
	public class Tecnologia : Producto
	{
		public Tecnologia(string nombre, decimal precio)
			: base(nombre, precio) { }

		public override decimal CalcularDescuento()
		{
			return Precio - (Precio * 0.10m); // 10%
		}
	}
}
