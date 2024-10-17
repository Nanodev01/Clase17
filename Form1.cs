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

namespace ejemploPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList listaAnimales = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            listaAnimales.Add(new Perro("Toby", new DateTime(2010,09,04), "medio"));
            listaAnimales.Add(new Perro("Sultan", new DateTime(2015, 12, 22), "fuerte"));
            listaAnimales.Add(new Gato("Manchitas", new DateTime(2018, 05, 23), "bajo"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Animal a in listaAnimales)
            {
                
                {
                    listBox1.Items.Add(a.Datos());
                    listBox1.Items.Add(" edad:" + a.Edad(DateTime.Today));
                }


            }
        }
    }
}
