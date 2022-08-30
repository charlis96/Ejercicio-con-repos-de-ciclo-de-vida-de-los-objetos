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
        /// Punto de entrada al programa principal, aquí se construyen 100 instancias de la clase Train.
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
        /// Punto de entrada al programa principal, aquí se construyen 10.000.000 instancias de la clase Train.
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
        Al ejecutarse la primera iteración del for, se crea una nueva instancia de la clase Train,
        la cual es asignada a la variable llamada "tren". Cuando se pasa a la segunda iteración,
        se crea otra instancia de Train, y se le asigna a la misma variable tren. La instancia
        anterior de Train queda ocupando espacio en la memoria, pero no es referenciada por ninguna
        variable. Como tampoco es destruida, llega un momento que se acaba la memoria, entonces
        falla la ejecución.
        */
        /// <summary>
        /// Punto de entrada al programa principal, aquí se construyen 10.000.000 instancias de la clase Train.
        /// </summary>
        public static void Main()
        {
            {
                Train t1 = new Train("Last Train To London");
                Train t2 = new Train("Last Train To London");
                Train t3 = new Train("Runaway Train");
                Console.WriteLine($"{t1 == t2}, {t2 == t3}");
                Console.WriteLine(Train.count);
            }
            /*
            El motivo por el cual ninguna de las comparaciones es verdadera es porque se crean 3
            instancias de la clase Train, y cada una es asignada a una variable distinta.
            Por más que las variables t1 y t2 apuntan a un objeto cuya identificación es
            "Last Train To London", se trata de 2 instancias distintas, que ocupan 2 lugares
            distintos en la memoria. En definitiva, las variables t1 y t2 apuntan a 2 lugares distintos
            de la memoria. Lo mismo sucede con la variable t3, pero aquí hay menos lugar a
            error ya que la identificación del objeto al que apunta no es igual a la de las otras
            variables.
            */
        }
    }
}