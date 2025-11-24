using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDescuentos.Clases
{
	public class General : Producto
	{
		public General(string nombre, decimal precio)
			: base(nombre, precio) { }

		public override decimal CalcularDescuento()
		{
			return Precio - (Precio * 0.05m); // 5%
		}
	}
}
