﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Class9
    {
        public static void Main45()
        {
            int i, j, m, n,p,q;
            int[,] array1 = new int[20, 20];
            int[,] array2 = new int[20, 20];
           

            Console.WriteLine("\nEnter  number of rows and columns for array1:\n");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Enter elements in array1:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("\nEnter  number of rows and columns for array2:\n");
            p = Convert.ToInt32(Console.ReadLine());
            q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter elements in array2:\n");
            for (i = 0; i < p; i++)
            {
                for (j = 0; j < q; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("\narray1 is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", array1[i, j]);
                }

            }
            Console.WriteLine("\narray2 is:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", array2[i, j]);
                }

            }
           if(m != p)
            {
                Console.WriteLine("multiplication not possible");
            }
            else
            {
                int[,] array3 = new int[n,q];
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < q; j++)
                    {
                        array3[i, j] = 0;
                        for(int k = 0; k < m; k++)
                        {
                            array3[i, j] = array1[i, j] * array2[i, j];

                        }
                    }
                }
                Console.WriteLine("\nmultiplication of two arrays are:\n");
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
