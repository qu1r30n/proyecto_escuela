using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_datos_Click(object sender, EventArgs e)
        {
            string info = nombre_funcion(txt_datos.Text, "yo_muy_bien");
            MessageBox.Show(info);
        }

        public string nombre_funcion(string parametro1,string parametro2="hola")
        {
            MessageBox.Show(parametro1);

            return parametro2;
        }
    }
}
