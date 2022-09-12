using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Class9
    {
        public static void Main123456()
        {
            int i, j, m, n, p, q;
            int[,] array1 = new int[10, 10];
            int[,] array2 = new int[10, 10];

            Console.WriteLine("Enter number of rows and columns in matrix1");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of rows and columns in matrix1");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Elements in array1 :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Elements in array2 :");
            for (i = 0; i < p; i++)
            {
                for (j = 0; q < m; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" Elements in array1 :");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m; j++)
                {
                    Console.Write("\t{0}", array1[i, j]);
                }
            }
            Console.WriteLine("\n Elements in array2 :");
            for (i = 0; i < p; i++)
            {
                Console.Write("\n");
                for (j = 0; j < q; j++)
                {
                    Console.Write("\t{0}", array2[i, j]);
                }
            }
            if (m != p)
            {
                Console.Write("multiplication not possible");

            }
            else
            {
                int[,] array3 = new int[n, q];
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        array3[i, j] = 0;
                        for (int k = 0; k < m; k++)
                        {
                            array3[i, j] += array1[i, k] * array2[k, j];
                        }
                    }
                }
                Console.Write("\nMultiplication of two matrix are:\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < m; j++)
                    {
                        Console.Write(array3[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
