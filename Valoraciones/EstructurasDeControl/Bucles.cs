using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    class Bucles
    {
        // Funcionalidad : Recorrer colecciones de datos (Array, ArrayList, listas, diccionarios)

        public void BuclesForEach()
        {

            //Con numéricos
            int[] array1 = { 0, 1, 2, 3, 4, 5 };

            foreach(int n in array1)
            {
                //break; // sale del bucle
                //continue; // sale del bucle
                //return; // sale del bucle y del metodo
                //goto Hola; // salta hasta donde esta la etiqueta
                Console.WriteLine("For each int : " + n.ToString());

                //Hola:
                //Console.WriteLine("Me salto el Console");
            }

            //Con Strings
            string[] array2 = { "Hola", "Mundo" };
            foreach(string s in array2)
            {
                Console.WriteLine("For each string : " + s);
            }
        }

        public void BuclesForLoop()
        {

            //Con numéricos
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("For loop int " + array1[i].ToString());
            }

            //Con Strings
            string[] array2 = { "Hola", "Mundo" };
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("For loop string " + array2[i].ToString());
            }
        }

        public void BuclesWhile()
        {
            //Con numéricos
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            while (x < array1.Length)
            {
                Console.WriteLine("While int " + array1[x].ToString());
                x++;
            }

            //Con Strings
            string[] array2 = { "Hola", "Mundo" };
            int y = 0;

            while (y < array2.Length)
            {
                Console.WriteLine("While string " + array2[y]);
                y++;
            }
        }

        public void BuclesDoWhile()
        {
            //Con numéricos
            int[] array1 = { 0, 1, 2, 3, 4, 5 };
            int x = 0;

            do {
                Console.WriteLine("Do While int " + array1[x].ToString());
                x++;
            } while (x < array1.Length);

            //Con Strings
            string[] array2 = { "Hola", "Mundo" };
            int y = 0;

            do
            {
                Console.WriteLine("Do While string " + array2[y]);
                y++;
            } while (y < array2.Length);
        }

    }
}
