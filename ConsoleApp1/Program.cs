using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matrice1 = CreateMatrix();
            Console.WriteLine("----------------------------");
            PrintMatrix(matrice1);
            Console.WriteLine($"Matrix identity \"{CheckIfMatrixIdentity(matrice1)}\"");
        }

        public static int[,] CreateMatrix ()
        {
            Console.Write("Introdu numarul de randuri = ");
            int randuri = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdu numarul de coloane = ");
            int coloane = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[randuri, coloane];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"Element of matrix [{i}] [{j}] = ");
                    int element = Convert.ToInt32(Console.ReadLine());
                    matrix[i, j] = element;
                }
            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix)
        {
            if(matrix is null)
            {
                Console.WriteLine("Matrix is null !");
                return;
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 6}");
                }

                Console.WriteLine();
            }
        }

        public static bool CheckIfMatrixIdentity (int[,] matrix)
        {
            bool isPerfect = false;
            bool perfectElseWhere = false;
            bool perfectDiagonal = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j && matrix[i, j] == 1)
                    {
                        perfectDiagonal = true;
                    }
                    if(i != j && matrix[i, j] == 0)
                    {
                        perfectElseWhere = true;
                    }
                }
            }
            if (perfectDiagonal == true && perfectElseWhere == true)
            {
                isPerfect = true;
            }
            return isPerfect;
        }
    }
}
