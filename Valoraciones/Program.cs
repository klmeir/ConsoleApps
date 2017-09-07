using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iniciar objetos
            LibroValoraciones libro = new LibroValoraciones();
            libro.Nombre = "El libro de valoraciones de Prueba";
            libro.Nombre = null;
            Console.WriteLine(libro.Nombre);
            //MisArrays miArray = new MisArrays();

            //SpeechSynthesizer hablar = new SpeechSynthesizer();
            Vector3D miVector;

            //Métodos
            //miArray.ArrayTrabajando();

            //ASignar propiedades
            miVector.x = 10;
            miVector.y = 20;
            miVector.z = 30f;

            libro.Idioma = IdiomaLibro.ES;

            libro.AgregarValoracion(5);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(3);
            libro.AgregarValoracion(0.5f);
            libro.AgregarValoracion(1);
            libro.AgregarValoracion(3.5f);

            //hablar.Speak("Este es el promedio de las valoraciones");
            CalcularValoraciones publicar = libro.PublicarValoraciones();
            float valoracionMax = publicar.ValoracionMax;
            float valoracionMin = publicar.ValoracionMin;
            float promedioValoraciones = publicar.PromedioValoraciones;

            EscribirValoraciones("El promedio de las valoraciones es: ", promedioValoraciones);
            EscribirValoraciones("La valoración máxima es: ", valoracionMax);
            EscribirValoraciones("La valoración mínima es: ", valoracionMin);
            //Console.Beep();
            Console.ReadLine();

        }

        private static void EscribirValoraciones(string descripcion, float valoracion)
        {
            Console.WriteLine("{0}"+"{1}", descripcion, valoracion);
        }

        private static void EscribirValoraciones(string descripcion, int valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
    }
}
