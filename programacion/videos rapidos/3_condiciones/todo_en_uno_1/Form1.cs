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
            int edad = Convert.ToInt32(txt_edad.Text);

            if (edad<18)
            {
                MessageBox.Show("es menor de edad \n le daremos propina para motivarlo");//se habre una ventana diciendo que es menor de edad
                double sueldo = Convert.ToDouble(txt_sueldo.Text);//convierte lo del texbox sueldo a double y lo mente en la variable sueldos
                double propina = 10;//le mete el numero 10 en la variable propina del tipo numero con decimal
                sueldo = sueldo + propina;//aqui se suma la variable sueldo y la variable propina y se le mete a la variable sueldo

                MessageBox.Show(txt_nombre.Text + "\nsu pago sera de: " + sueldo);//sale una ventana poniendo el nombre y su pago

            }
            else
            {
                double sueldo = Convert.ToDouble(txt_sueldo.Text);//convierte lo del texbox sueldo a double y lo mente en la variable sueldos
                MessageBox.Show("es mayor de edad");//se habre una ventana diciendo que es mayor de edad
                MessageBox.Show(txt_nombre.Text + "\nsu pago sera de: " + sueldo);//sale una ventana poniendo el nombre y su pago
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
