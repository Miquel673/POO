using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDescuentos.Clases;

namespace ProyectoDescuentos
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			cmbTipo.Items.Add("Tecnología");
			cmbTipo.Items.Add("Alimento");
			cmbTipo.Items.Add("General");
			cmbTipo.SelectedIndex = 0;
		}

		private void btnCalcular_Click(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text;

			if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
			{
				MessageBox.Show("Ingrese un valor numerico");
				return;
			}

			Producto producto;

			switch (cmbTipo.SelectedItem.ToString())
			{
				case "Tecnología":
					producto = new Tecnologia(nombre, precio);
					break;

				case "Alimento":
					producto = new Alimento(nombre, precio);
					break;

				default:
					producto = new General(nombre, precio);
					break;
			}

			decimal precioFinal = producto.CalcularDescuento();

			lblResultado.Text = $"Precio final: {precioFinal:C}";
		}
	}
}
