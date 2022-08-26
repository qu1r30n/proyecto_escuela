using System;

namespace operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valor_verdadero = true;
            bool valor_falso = false;
            bool resultado;

            resultado = valor_verdadero && valor_verdadero;
            Console.WriteLine("valor_verdadero && valor_verdadero \nResultado: " + resultado);
            resultado = valor_verdadero && valor_falso;
            Console.WriteLine("valor_verdadero && valor_falso \nResultado: " + resultado);
            resultado = valor_verdadero || valor_verdadero;
            Console.WriteLine("valor_verdadero || valor_verdadero \nResultado: " + resultado);
            resultado = valor_verdadero || valor_falso;
            Console.WriteLine("valor_verdadero || valor_falso \nResultado: " + resultado);
            resultado = valor_falso || valor_falso;
            Console.WriteLine("valor_falso || valor_falso \nResultado: " + resultado);
        }
    }
}
