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
            /*
            int edad = Convert.ToInt32(txt_edad.Text);
            Double sueldo = Convert.ToDouble(txt_sueldo.Text);
            nombre_de_la_funcion(txt_nombre.Text, edad, txt_pais.Text, sueldo);
            */
            nombre_de_la_funcion_mejorada(txt_nombre.Text, txt_edad.Text, txt_pais.Text, txt_sueldo.Text);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        //explicacin de la estructura
        //public quiere decir que desde otro archivo lo podras llamar a la funcion
        //el string que le sigue significa que la funcion devolvera un valor de tipo texto
        //nombre_de_la_funcion creo que es ovio lo que significa
        //lo que esta dentro de parentesis son los parametros o variables que le van a llegar al ser llamada la funcion
        public string nombre_de_la_funcion(string parametro_string,int parametro_edad,string pais,double sueldo)
        {
            string texto_a_devolver = "";
            if (parametro_edad < 18)
            {
                texto_a_devolver = "es mayor de edad";
            }
            string solo_con_fines_didacticos;
            solo_con_fines_didacticos = texto_a_devolver;
            return texto_a_devolver;
        }

        public string nombre_de_la_funcion_mejorada(string parametro_string_st, string parametro_edad_st, string pais_st, string sueldo_st)
        {
            string parametro_string = parametro_string_st;
            int parametro_edad = Convert.ToInt32(parametro_edad_st);
            string pais = pais_st;
            double sueldo = Convert.ToDouble(sueldo_st);
        
            string texto_a_devolver = "";
            if (parametro_edad < 18)
            {
                texto_a_devolver = "es mayor de edad";
            }
            string solo_con_fines_didacticos;
            solo_con_fines_didacticos = texto_a_devolver;
            return texto_a_devolver;
        }

    }
}
