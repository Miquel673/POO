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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[]
            {
                "Celular MOTOROLA G15 256GB 4G Gris", "Computador Portátil LENOVO 15.3 Pulgadas IdeaPad Slim 3 Táctil - Intel Core i5 - RAM 24GB - Disco SSD 512GB - Gris", "TV KALLEY 60 Pulgadas 152.4 cm 60GQ400 4K UHD QLED Smart TV Google",
                "Manzana fresca", "Pan Tajado Bimbo", "Carton de Leche Alqueria"

            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboBox1.SelectedItem.ToString();
            string Descuento = "";

            // Listas de categorías
            string[] tecnologia = { "Celular MOTOROLA G15 256GB 4G Gris", "Computador Portátil LENOVO 15.3 Pulgadas IdeaPad Slim 3 Táctil - Intel Core i5 - RAM 24GB - Disco SSD 512GB - Gris", "TV KALLEY 60 Pulgadas 152.4 cm 60GQ400 4K UHD QLED Smart TV Google" };
            string[] alimento = { "Manzana fresca", "Pan Tajado Bimbo", "Carton de Leche Alqueria"};

            if (tecnologia.Contains(seleccion))
            {

                Descuento = "Descuento del: 12%";
                label1.Text = "Tecnología";
                MessageBox.Show("El producto Tecnologico: " + $"\"{seleccion}\"" + " cuenta con un " + Descuento);

            }
            else if (alimento.Contains(seleccion))
            {
                Descuento = "Descuento del: 23%";
                label1.Text = "Alimento";
                MessageBox.Show("El producto Alimenticio: " + $"\"{seleccion}\"" + " cuenta con un " + Descuento);

            }
            else
            {
                label1.Text = "Categoría desconocida";
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Descuento_Click(object sender, EventArgs e)
        {

        }
    }
}
