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



            int variable_entera = 22;//solo admite numeros enteros
            double variable_con_decimal = 1.5;//admite numeros enteros con decimal
            string variable_texto;//admite texto entre comillas
            char variable_caracter = '|';//solo un caracter lo que esta dentro de las comillas simples

            string[] arreglo = { "celda1", "celda2" };


            string variable_a_convertir_a_entero;//todas las variables son de tipo texto las cual su contenido los convertiremos a otro tipo
            string variable_a_convertir_a_double;//todas las variables son de tipo texto las cual su contenido los convertiremos a otro tipo
            string variable_a_convertir_a_char;//todas las variables son de tipo texto las cual su contenido los convertiremos a otro tipo

            variable_a_convertir_a_entero = txt_edad.Text;//aqui le metemos el contenido del textbox de edad
            variable_entera = Convert.ToInt32(variable_a_convertir_a_entero);//aqui se convierte de tipo texto a entero

            variable_texto = txt_pais.Text;

            variable_a_convertir_a_double = txt_sueldo.Text;//aqui le metemos el contenido del textbox de sueldo
            variable_con_decimal = Convert.ToDouble(txt_sueldo.Text);//aqui se convierte de tipo texto a entero

            variable_a_convertir_a_char = "|";//aqui le metemos el texto para convertilo a caracter
            variable_caracter = variable_a_convertir_a_char[0];//como el texto es un arreglo de caracteres el numero del caracter es numero de la celda del arreglo



            MessageBox.Show("datos de la  persona\nnombre: " + txt_nombre.Text + "\nedad: " + variable_entera + "\npais: " + variable_texto);

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
