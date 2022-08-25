//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal, aquí se construyen 100 instancias del objeto Train.
        /// </summary>
        /*
        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Train tren = new Train(i.ToString());
                Console.WriteLine(tren.Count);
            }
        }
        */
        /// <summary>
        /// Punto de entrada al programa principal, aquí se construyen 10.000.000 instancias del objeto Train.
        /// </summary>
        /*
        public static void Main()
        {
            for (int i = 1; i <= 10000000; i++)
            {
                Train tren = new Train(i.ToString());
                Console.WriteLine(tren.Count);
            }
        }
        Al ejecutarse la primera iteración del for, se crea una nueva instancia del objeto Train,
        la cual es asignada a la variable llamada "tren". Cuando se pasa a la segunda iteración,
        se crea otra instancia del objeto Train, y se le asigna a la variable tren. La instancia
        anterior de Train queda ocupando espacio en la memoria, pero no es referenciada por ninguna
        variable. Como tampoco es destruida, llega un momento que se acaba la memoria, entonces
        falla la ejecución.
        */
        public static void Main()
        {
            {
                Train t1 = new Train("Last Train To London");
                Train t2 = new Train("Last Train To London");
                Train t3 = new Train("Runaway Train");
                Console.WriteLine($"{t3.Count}");
                Console.WriteLine($"{t1 == t2}, {t2 == t3}");
            }
        }
    }
}