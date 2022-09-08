using System;

namespace ConsoleApp7
{
    class multiplication
    {
        static void Main1(string[] args)
        {
            int i, j, n, m, p, q;
            int[,] my_array1 = new int[20, 20];
            int[,] my_array2 = new int[20, 20];
           
            Console.WriteLine(" number of rows and columns for matrix 1:\n");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter elements in matrix1:");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {

                    my_array1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("number of rows and column for matrix 2:\n");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter elements in matrix2:");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {

                    my_array2[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.Write("\nfirst matrix is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", my_array1[i, j]);
                }
            }
            Console.Write("\nsecond matrix is:\n");
            for (i = 0; i < p; i++)
            {
                Console.Write("\n");
                for (j = 0; j < q; j++)
                {
                    Console.Write("{0}\t", my_array2[i, j]);
                }
            }
            if (m!= p)
            {
                Console.WriteLine("matrix multiplication not possible");
            }
            else
            {
                int[,] my_array3 = new int[n,q];
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        my_array3[i, j] = 0;
                        for (int k = 0; k < m; k++)
                        {
                            my_array3[i, j] += my_array1[i, k] * my_array2[k, j];
                        }
                    }
                }

                Console.Write("\nMultiplication of two matrixs are:\n");
                for (i = 0; i < n; i++)
                {
                 
                    for (j = 0; j < m; j++)
                    {
                        Console.Write(my_array3[i, j]+ "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
