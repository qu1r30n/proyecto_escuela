using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrada_salida_datos_y_variables
{
    public partial class Form1 : Form
    {
        int resultado_sum;
        double resultado_resta_doble;
        float resultado_multiplicacion_float;
        string resultado_divicion_cadena_de_texto;
        char caracter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resul_suma_Click(object sender, EventArgs e)
        {
            string var1_string;
            string var2_string;
            var1_string = txt_sum_variable1.Text;
            var2_string = txt_sum_variable2.Text;

            int var1_entero = Convert.ToInt32(var1_string);
            int var2_entero = Convert.ToInt32(var2_string);
            resultado_sum = var1_entero + var2_entero;

            lbl_resultado_sum.Text = ""+resultado_sum;

        }

        private void btn_resul_resta_Click(object sender, EventArgs e)
        {
            double var1_double = Convert.ToDouble(txt_res_variable1.Text);
            double var2_double = Convert.ToDouble(txt_res_variable2.Text);

            resultado_resta_doble = var1_double - var2_double;
            lbl_resultado_res.Text = "" + resultado_resta_doble;
            
        }

        private void btn_resul_multiplicacion_Click(object sender, EventArgs e)
        {
            decimal var1_float = Convert.ToDecimal(txt_mul_variable1.Text);
            decimal var2_float = Convert.ToDecimal(txt_mul_variable2.Text);

            resultado_multiplicacion_float = Convert.ToSingle(var1_float * var2_float);
            lbl_resultado_res.Text = "" + resultado_multiplicacion_float;

        }

        private void btn_resul_divicion_Click(object sender, EventArgs e)
        {
            string var1_string = txt_div_variable1.Text;
            string var2_string = txt_div_variable2.Text;

            resultado_divicion_cadena_de_texto = (Convert.ToDecimal(var1_string) / Convert.ToDecimal(var2_string)).ToString();
            lbl_resultado_div.Text = resultado_divicion_cadena_de_texto;
        }
    }
}
