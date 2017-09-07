using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public class MisArrays
    {
        public void ArrayTrabajando()
        {

            string[] arrayString;
            arrayString = new string[3];

            //string[] arrayString = new string{A,B,C};

            arrayString[0] = "A";
            arrayString[1] = "B";
            arrayString[2] = "C";

            string[] arrayString2 = arrayString;
            arrayString2[1] = "A";

            int[] numeros = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

            foreach (int i in numeros)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            int[,] numeros2D = new int[3, 3] { { 9, 99, 9 }, { 3, 33, 3 }, { 5, 55, 5 } };
            foreach (int i in numeros2D)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            int[,] numeros2DResumido = { { 99, 99 }, { 33, 33 }, { 55, 55 } };
            foreach (int i in numeros2DResumido)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
