using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class sumofarray
    {
        public static void Main7()
        {
            int i, j,m, n;
            Console.Write("Enter number of row and coloumn in matrix:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[10, 10];
            int[,] matrix2 = new int[10, 10];
            int[,] matrix3 = new int[10, 10];
            
            Console.Write("Enter number of elements in the first matrix:\n");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
                Console.Write("Enter number of elements in the second matrix:\n");
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nfirst matrixis:\n");
                for (i = 0; i < m; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", matrix1[i, j]);
                }
                Console.Write("\nsecond matrixis:\n");
                for (i = 0; i < m; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", matrix2[i, j]);
                }
                for (i = 0; i < m; i++)
                    for (j = 0; j < n; j++)
                        matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write("\n adding two matrices:\n");
                for (i = 0; i < m; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t",matrix3[i,j]);
                }
                Console.Write("\n\n");
            }

        }
    }

