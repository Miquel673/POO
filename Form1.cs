using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Tienda tienda;

        public Form1()
        {
            InitializeComponent();
            tienda = new Tienda();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar ComboBox con nombres de productos
            comboBox1.Items.AddRange(
                tienda.Categorias.SelectMany(c => c.Productos)
                .Select(p => p.Nombre)
                .ToArray()
            );
        }

        private void Ejecutarbtn_Click(object sender, EventArgs e)
        {
            string seleccionado = comboBox1.SelectedItem.ToString();
            Producto p = tienda.BuscarProducto(seleccionado);

            if (p == null)
            {
                label1.Text = "Producto no encontrado";
                return;
            }

            label1.Text = p.Categoria;

            double descuento = tienda.ObtenerDescuento(p.Categoria);
            int precioFinal = (int)(p.Precio * (1 - descuento));

            MessageBox.Show(
                $"Producto: \"{p.Nombre}\"\n" +
                $"Categoría: {p.Categoria}\n" +
                $"Precio original: {p.Precio:C0}\n" +
                $"Descuento: {descuento:P0}\n" +
                $"Precio final: {precioFinal:C0}"
            );


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccionado = comboBox1.SelectedItem.ToString();
            Producto p = tienda.BuscarProducto(seleccionado);

            if (p == null)
            {
                label1.Text = "Producto no encontrado";
                return;
            }

            label1.Text = p.Categoria;

        }

    }

}
