using System;

namespace EdadLegal
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite su nombre y pulse la tecla Enter:");
            string nombre = System.Console.ReadLine();
            System.Console.WriteLine("Digite su edad y pulse la tecla Enter:");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Tu nombre es " + nombre + " y legalmente NO eres mayor de edad");
            }
        }
    }
}
