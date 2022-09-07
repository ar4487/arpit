using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class4
    {
     public static void Main12()
        {
            int[,] matrix = new int[2, 2];//{{1,2},{3,4}};
            for(int row = 0; row < 2; row++)
            {
                for (int col=0; col < 2; col++)
                {
                    Console.Write("enter value to matrix["+row+","+col+"]:");
                    matrix[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int row=0; row<2;row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }

        }
            }

        }
    

