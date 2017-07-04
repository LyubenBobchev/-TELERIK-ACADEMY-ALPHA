using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAreaInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            string[,] matrix = new string[n, m];

            FillMatrix(matrix, n, m);
            


        }


        static void FillMatrix(string[,] matrix, int matrixRows, int matrixCols)
        {
            for (int row = 0; row < matrixRows; row++)
            {
                string[] RowFilling = Console.ReadLine().Split();

                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = RowFilling[col];
                }

            }
        }
    }
}
