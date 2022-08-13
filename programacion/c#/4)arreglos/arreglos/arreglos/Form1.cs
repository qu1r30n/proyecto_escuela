using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglos
{
    public partial class Form1 : Form
    {
        string[] datos = new string[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i]==""|| datos[i] == null)
                {
                    datos[i] = txt_datos.Text;
                    bandera = true;
                    break;
                }
            }
            if (bandera==false)
            {
                MessageBox.Show("ya no hay espacio crea otro nuevo arreglo con mayor cantidad");
            }
            
        }

        private void btn_nvo_arreglo_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txt_cantidad_datos.Text);
            datos = new string[cantidad];
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < datos.Length; i++)
            {
                if (datos[i] != "" || datos[i] != null)
                {
                    MessageBox.Show(datos[i]);
                    break;
                }
                
            }
            
        }
    }
}
