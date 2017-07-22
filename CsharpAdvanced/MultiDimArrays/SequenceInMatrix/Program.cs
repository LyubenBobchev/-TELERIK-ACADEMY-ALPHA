using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
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
            Console.WriteLine(CheckSequence(matrix, n, m));


        }

        static void FillMatrix(string[ , ] matrix, int matrixRows, int matrixCols)
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

        static int CheckSequence(string [ , ] matrix, int matrixRows, int matrixCols)
        {
            int rowSeqCounter = 1;
            int colSeqCounter = 1;
            int diagonalSeqCounter = 1;
            int maxCounter = 1;

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    for (int j = 1; j < matrixRows; j++)
                    {
                        if (matrix[row, col] == matrix[row, j + col])
                        {
                            rowSeqCounter++;
                        }
                        if (rowSeqCounter > maxCounter)
                        {
                            maxCounter = rowSeqCounter;
                        }
                        
                    }

                    for (int i = 1; i < matrixCols; i++)
                    {
                        if (matrix[row, col] == matrix[i + row, col])
                        {
                            colSeqCounter++;
                        }
                        if (colSeqCounter > maxCounter)
                        {
                            maxCounter = colSeqCounter;
                        }
                    }

                    for (int x = 1,y = 1; (x < Math.Min((matrixRows - 1), (matrixCols - 1 ))) || (y < Math.Min((matrixRows - 1), (matrixCols - 1))); x++, y++)
                    {
                        if (matrix[row, col] == matrix[x + row , y + col])
                        {
                            diagonalSeqCounter++;
                        }
                        if (diagonalSeqCounter > maxCounter)
                        {
                            maxCounter = diagonalSeqCounter;
                        }

                    }
                }
            }

            return maxCounter;
        }
    }
}
