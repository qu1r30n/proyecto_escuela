using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// aqui vamos a llamar a la clase
//usaremos el nombre del programa o namespace
//y nos dirigiremos a la carpeta si es que hay si no no sera nesesaria de clarar la clase por que ya estara hecho
using todo_en_uno_1.carpeta_clases;

//-----------------------------------


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
            //aqui declaramos una variable de tipo clase el nombre de la clase es  el tipo
            //el new es porque generara una copia de la clase para ser usada
            clase_1 variable_tipo_clase = new clase_1();

            //y al igual que llamamos una funcion solo que la diferencia pondremos la variable tipo clase y le pondremos un punto y despues la funcion


            /* //ejemplo1
            int edad = Convert.ToInt32(txt_edad.Text);
            Double sueldo = Convert.ToDouble(txt_sueldo.Text);
            variable_tipo_clase.nombre_de_la_funcion(txt_nombre.Text, edad, txt_pais.Text, sueldo);
            */
            variable_tipo_clase.nombre_de_la_funcion_mejorada(txt_nombre.Text, txt_edad.Text, txt_pais.Text, txt_sueldo.Text);

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
