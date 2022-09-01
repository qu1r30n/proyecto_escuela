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
            //creamos un arreglo de nombres y en la primera celda le ponemos el nombre
            string[] nombres = { txt_nombre.Text,"barbara","victor","daniel","juan" };
            //lo mismo que en el arreglo de nombres solo que esta es de edades
            string[] edad = { txt_edad.Text,"14", "33", "24", "26" };
            string[] pais = { txt_pais.Text, "cl", "mx", "mx", "mx" };//lo mismo que los de arriba solo que paises
            string[] sueldo = { txt_sueldo.Text, "0.00", "5600.50", "1000", "1000" };//arreglo de sueldos

            /*
            esun ciclo que mientras i sea menor que el total de nombres//se pone cero por que la primera celda de un arreglo es 0
            el sueldo lo cambia de tipo de dato texto a tipo de dato double // que es un numero que tiene decimales
            luego llama a la funcion funsion_procesar  y le manda el nombre y edad
            luego llama a la funcion imprimir_pais_sueldo_mas_propinas y le pone el pais y los sueldos
            */

            //ciclo: i=0 mientras i sea menor a cantidad has lo de dentr de las llaves y cada ciclo sumale 1 a i
            for (int i = 0; i < nombres.Length; i++) 
            {

                //llama a la funcion funsion_procesar y pasale los valores de nombre y edada de la celda indice i
                //i = 0//si es la primera vuelta del ciclo
                funsion_procesar(nombres[i],edad[i]);

                //la celda con el indice "i" del arreglo sueldos su contenido conviertelo en tipo de dato double
                //y metelo  en la variable sueldo_double
                Double sueldo_double = Convert.ToDouble(sueldo[i]);
                imprimir_pais_sueldo_mas_propinas(pais[i], sueldo_double);//lo mismo que la funcion de arriba pero con parametros pais y sueldo

            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        //funcion
        //funcion publica, regresara un valor tipo texto, el nombre de la  funcion, (parametro tipo texto,parametro tipo texto)
        public string funsion_procesar(string nombre,string edad_a_convertir)//resibe los parametros nombre y edad
        {
            int edad_usuario;//crea la variable edad_usuario y acepta tipo de dato numeros enteros 
            edad_usuario = Convert.ToInt32(edad_a_convertir);//la variable edad_a_convertir de tipo texto lo convierte en entero y lo mente a edad_usuario

            string mensaje_a_regresar="";//la variable mensaje_a_regresar sedeclara y se le mete el valor 
            int[] edades = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }; //se crea arreglo tipo entero con esos valores
            
            for (int i = 0; i < edades.Length; i++)//i=0 mientras i sea menor cantidad total de elementos del arreglo edades haces lo de dentro de las llaves
            {
                if (edad_usuario==edades[i])//si edad_usuario es igual a el valor de la celda i del arreglo edades[i] hace lo de las llaves
                {
                    mensaje_a_regresar = "es_menor_de_edad";//mete en la variable mensaje_a_regresar  es_menor de edad
                    break;//detiene el ciclo
                }
                else//si no se cumplio la condicion if entonces has lo de dentro de las llaves
                {
                    mensaje_a_regresar = "es mayor de edad";//mete en la variable mensaje_a_regresar es mayor de edad
                }
            }
            return mensaje_a_regresar;//regresa el valor de la variable mensaje_a_regresar
        }

        //funcion
        //funcion privada, no regresara un valor,nombre de la funcion,parametros pais tipo texto y sueldo tipo double
        private void  imprimir_pais_sueldo_mas_propinas(string pais,double sueldo)
        {
            MessageBox.Show("pais: " +pais);//abre una ventana y pone el mensaje pais y concatena la el valor de la variable pais
            double propina = 10;//crea variable propina tipo double y le agrega el valor 10
            double resultado;//crea variable resultado tipo double que no contiene algun valor
            resultado = sueldo + propina;//la variable sueldo suma con variable propinas y la mete en resultados
            MessageBox.Show("sueldo: " + resultado);//crea una ventana y muestra resultado
        }
    }//fin
}
