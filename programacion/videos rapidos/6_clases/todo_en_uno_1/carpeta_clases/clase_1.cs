using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_en_uno_1.carpeta_clases
{
    class clase_1
    {
        public string nombre_de_la_funcion(string parametro_string, int parametro_edad, string pais, double sueldo)
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
