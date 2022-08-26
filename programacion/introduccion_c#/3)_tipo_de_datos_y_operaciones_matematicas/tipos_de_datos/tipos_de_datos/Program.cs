using System;

namespace tipos_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cual es tu nombre? escribe tu nombre");
            string texto_escrito = Console.ReadLine();

            Console.WriteLine("bienvenido a las clases de programacion " + texto_escrito + "\n preciona enter para proceguir");
            Console.ReadLine();

            int numero1 = 0;
            int numero2 = 0;
            int numero3;

            Console.WriteLine("pon primer numero a sumar: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pon segundo numero a sumar: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            numero3 = numero1 + numero2;

            Console.WriteLine("resultado: "+numero3);

        }
    }
}
