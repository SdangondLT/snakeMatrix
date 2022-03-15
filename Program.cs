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
            //int[,] matriz = new int[9, 9];
            //int counter = 81;

            //for (int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        matriz[i, j] = counter;
            //        counter = counter - 1;
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

            //AL REVES COMO CULEBRITA
            int[,] matriz = new int[9, 9];
            int counter = 81;

            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                if (fila % 2 == 0)
                {//si es una fila par debe hacer el calculo normal de llenar la matriz

                    for (int colum = 0; colum < matriz.GetLength(1); colum++)
                    {
                        matriz[fila, colum] = counter;
                        counter = counter - 1;
                    }
                }
                else
                {//si es una fila impar que empiece en la cola de su indice

                    for (int colum = matriz.GetLength(1) - 1; colum >= 0; colum--)
                    {
                        matriz[fila, colum] = counter;
                        counter = counter - 1;
                    }
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int colum = 0; colum < matriz.GetLength(1); colum++)
                {
                    Console.Write(" [ " + matriz[i, colum] + " ] ");
                }
            }
            Console.ReadKey();
        }
    }
}
