using System;

namespace area_del_cuadro
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado = 10.2;

            Console.WriteLine("escribe perimetro de un lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            double resultado = lado * lado;
            
            Console.WriteLine("area del cuadrado: " + resultado);
        }
    }
}
