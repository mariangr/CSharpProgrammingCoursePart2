using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._06_Matrix
{
    class Matrix
    {
        private readonly int row, col;
        private readonly int[,] matrix;

        public int Row
        {
            get { return this.row; }
        }

        public int Col
        {
            get { return this.col; }
        }

        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;

            this.matrix = new int[row, col];
        }

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col)
            {
                throw new ArgumentException("Invalid sizes");
            }

            Matrix result = new Matrix(matrix1.row, matrix1.col);

            for (int i = 0; i < matrix1.row; i++)
            {
                for (int j = 0; j < matrix1.col; j++)
                {
                    result[i, j] = matrix1[i, j] + (dynamic)matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col)
            {
                throw new ArgumentException("Invalid sizes");
            }

            Matrix result = new Matrix(matrix1.row, matrix1.col);

            for (int i = 0; i < matrix1.row; i++)
            {
                for (int j = 0; j < matrix1.col; j++)
                {
                    result[i, j] = matrix1[i, j] - (dynamic)matrix2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Col != matrix2.Row)
            {
                throw new ArgumentException("Inalid sizes");
            }

            Matrix result = new Matrix(matrix1.row, matrix2.col);

            for (int i = 0; i < result.row; i++)
            {
                for (int j = 0; j < result.col; j++)
                {
                    for (int p = 0; p < matrix1.col; p++)
                    {
                        result[i, j] += (dynamic)matrix1[i, p] * matrix2[p, j];
                    }
                }
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();

            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    build.Append(this.matrix[i, j]);

                    if (j == this.Col - 1)
                    {
                        build.AppendLine();
                    }
                    else
                    {
                        build.Append(", ");
                    }
                }
            }
            return build.ToString();
        }
    
    }


    class Program
    {


        const int SIZE = 5;
        static void Main()
        {
            Matrix matrix1 = new Matrix(SIZE, SIZE);
            Matrix matrix2 = new Matrix(SIZE, SIZE);

            int number = 0;

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    matrix1[i, j] = number++;
                    matrix2[i, j] = number * 2;
                }
            }

            Matrix summary = matrix1 + matrix2;
            Matrix difference = matrix1 - matrix2;
            Matrix product = matrix1 * matrix2;

            Console.WriteLine(summary.ToString());
            Console.WriteLine(difference.ToString());
            Console.WriteLine(product.ToString());
        }
    }
}
