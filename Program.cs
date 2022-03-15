using System;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese el tamaño de las filas: ");
            //Console.WriteLine("Ingrese el tamaño de las columnas: ");

            //AL DERECHO
            //int[,] matriz = new int[9, 9];
            //int counter = 0;

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = counter;
            //        counter = counter + 1;
            //    }
            //}

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        Console.Write(" [ " + matriz[i, j] + " ] ");
            //    }
            //}
            //Console.ReadKey();

            //AL REVES PERO NORMAL
            int[,] matriz = new int[9, 9];
            int counter = 81;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = counter;
                    counter = counter - 1;
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" [ " + matriz[i, j] + " ] ");
                }
            }
            Console.ReadKey();
        }
    }
}
