using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_checar_Click(object sender, EventArgs e)
        {
            if (txt_texto.Text=="hola")
            {
                MessageBox.Show("hola como estas");
            }
            else if (txt_texto.Text == "adios")
            {
                MessageBox.Show("hasta luego");
            }
            else if (txt_texto.Text == "si")
            {
                MessageBox.Show("muy bien");
            }
            else if (txt_texto.Text.All(char.IsDigit))
            {
                if (Convert.ToDouble(txt_texto.Text) >= 5 && Convert.ToDouble(txt_texto.Text) < 10)
                {

                    MessageBox.Show("es mayor o igual");
                }

                else if (Convert.ToDouble(txt_texto.Text) < 5 || Convert.ToDouble(txt_texto.Text) > 10)
                {
                    MessageBox.Show("es menor a 5 o mayor a 10");
                }
            }
            
            
            else
            {
                MessageBox.Show("dijiste: "+txt_texto.Text);
            }
        }
        
    }
}
