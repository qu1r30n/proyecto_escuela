using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo_en_uno_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(txt_sueldo.Text);
            double[] sueldos_a_sumar = { sueldo, 2.5, 3.5 };

            double total_a_pagar=0;
            for (int i = 0; i < sueldos_a_sumar.Length; i++)
            {
                total_a_pagar = total_a_pagar + sueldos_a_sumar[i];
            }

            MessageBox.Show("total a pagar: " + total_a_pagar);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
