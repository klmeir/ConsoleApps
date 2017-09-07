using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones.EstructurasDeControl
{
    class OperadoresYExpresiones
    {
        int x = 10;

        //if((x != 10) && ( x > 5)) || ((x > 20) && (x < 25))

        /*
         * Dos tipos de declaración
         * 
         * Literal
         * int i = 5;
         * 
         * Nombre 
         * int numMax = 5;
         * 
         * Expresión Invocación
         * ();
         * 
         */

        // Operadores
        /*
        
        Operadores primarios
        
        x.y acceso a miembros de clase
        x?.y  acceso a miembros de clase con condicional
        
        M(x) Invocación de Método (con parámetros opcional)
        a[x] Posicion de Array
        a?[x] Posicion de Array con condicional
        x++ Post-incremento
        x-- Post-decremento
        new T(...)  Creación de Objetos
        new T(...){...} Creación de Objetos con inicializador

        Operadores Unarios
        
        +x   Indica numero positivo
        -x   Indica numero negativo
        !x   negacion lógica
        ++x  Pre-incremento
        --x  Pre-decremento
        (T)x Conversión de tipos explícita
        
       Operadores de multiplicación
        
        * Multiplicación
        / División
        % Módulo o resto
        
        Operadores adición 
        
        x + y  Sumas, concatenación de strings, 
        x - y  Sustracción

        Operadores de relación
        
        x < y  menor que
        x > y  mayor que
        x <= y menor o igual que
        x >= y mayor o igual que
        
       
        Operadores de igualdad
       
        x == y Equal
        x != y Not equal
       
        
        Operadores Logical, Conditional
       
        x && y Lógico AND     if (x == 10 && y == 20 && n == 40 && z == 60)
                              {
                                    // Si se cumplen todos los casos
                              }
       
        x || y Condicional OR if (x == 10 ||  y == 20)
                              {
                                    // Si se cumple uno de los casos
                              }
        
       
       
        // Asignación 
        
        = Asignación
        x op = y
        +=, -=, *=, /=, %=, &=, |=, !=, (Asignadores compuestos)
        

        Operadores Asociación
       
        int a, b, c;
        c = 1;
        a = b = c;
        a = (b = c);
        a = b
        a, b, =
        a = b + c
        a, b, c, +, =
        a = b + c * d
        a, b, c, d, *, +, =
        a = b * c + d
        a, b, c, *, d, +, =
        a = b - c + d
        a, b, c, -, d, +, =
        a += b -= c
        a, b, c, -=, +=
        
        Agregando parentesis 

        a = (b + c) * d
        
        a = b - (c + d)
       
        a = (b + c) * (d - e)
     
         
        */
    }
}
