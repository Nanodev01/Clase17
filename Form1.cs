using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using System.Collections;
using System.IO;

namespace clase17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Animal> listaAnimales = new List<Animal>(); 

        private void button1_Click(object sender, EventArgs e)
        {
            listaAnimales.Add(new Perro("Toby", new DateTime(2010,09,04), "medio"));
            listaAnimales.Add(new Perro("Sultan", new DateTime(2015, 12, 22), "fuerte"));
            listaAnimales.Add(new Gato("Manchitas", new DateTime(2018, 05, 23), "bajo"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal.TipoOrden(1);
            listaAnimales.Sort();
            foreach (Animal a in listaAnimales)
            {
                listBox1.Items.Add(a.LineaCSV());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Animal buscado = new Perro(tbAnimales.Text, DateTime.Now, "");
            
            int orden = listaAnimales.BinarySearch(buscado);

            if (orden > -1)
            {
                MessageBox.Show(listaAnimales[orden].LineaCSV());

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("texto.csv", FileMode.Open, FileAccess.Read);

        }
    }
}
