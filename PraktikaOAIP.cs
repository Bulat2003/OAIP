using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A;
            int n1, m1, n2, m2;
            Console.Write("Введите кол-во строк для матрицы А: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов для матрицы А: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во строк для матрицы В: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов для матрицы В: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            A = new int[n1, m1];
            int[,] B = new int[n2, m2];
            func1(A, n1, m1);
            Console.WriteLine("Матрица A");
            OutputFunc1(A, n1, m1);
            func1(B, n2, m2);
            Console.WriteLine("Матрица B");
            OutputFunc1(B, n2, m2);
            Console.WriteLine("Матрица C");
            int[,] C = new int[n1, m2];
            MatrixUmnogenie(A, B, C, n1, m1, n2, m2);
        }
        static void func1(int[,] mt, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mt[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void OutputFunc1(int[,] mt, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mt[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void MatrixUmnogenie(int[,] A, int[,] B, int[,] C, int n1, int m1, int n2, int m2)
        {
            if (n1 == m2)
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                        Console.Write(C[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Кол-во столбцов первой матрицы не равно вол-ву строк второй матрицы");
            }

            Console.ReadKey();
        }
    }
}