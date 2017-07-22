using System;


namespace FillTheMatrix
{
    class Program
    {
        private static int arraySize;

        static void Main(string[] args)
        {
            
            int matrixSize = int.Parse(Console.ReadLine());
            char typeOfFill = char.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            switch (typeOfFill)
            {
                case 'a':
                    FillA(matrixSize, matrix);
                    break;
                case 'b':
                    FillB(matrixSize, matrix);
                    break;
                case 'c':
                    FillC(matrixSize, matrix);
                    break;
                case 'd':
                    FillD(matrixSize, matrix);
                    break;
            }
            PrintMatrix(matrix);
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] FillA(int matrixSize, int[,] matrix)
        {
            int start = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = start;
                    start++;
                }
            }
            return matrix;
        }

        public static int[,] FillB(int matrixSize, int[,] matrix)
        {
            int start = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (col % 2 == 0)
                    {
                        
                    }
                }
            }
            return matrix;
        }

        public static int[,] FillC(int matrixSize, int[,] matrix)
        {
            int start = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                }
            }
            return matrix;
        }

        public static int[,] FillD(int matrixSize, int[,] matrix)
        {
            int start = 1;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                }
            }
            return matrix;
        }
    }
}
