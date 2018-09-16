using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MatrixCalculator
{


    public class Matrix
    {
        private int Size1 { get; }
        private int Size2 { get; }
        private int[,] matrix;
        static Random rd = new Random();
        private bool CanPrint;

        public Matrix(int size1, int size2)
        {
            this.Size1 = size1;
            this.Size2 = size2;
            matrix = new int[Size1, Size2];
            CanPrint = false;
            MakeMatrix();
        }

        private int[,] MakeMatrix()
        {
            for (int i = 0; i < Size1; i++)
            {
                for (int j = 0; j < Size2; j++)
                {
                    matrix[i, j] = rd.Next(-99, 100);
                }
            }
            CanPrint = true;
            return matrix;
        }
        public static void MatrixPrint(Matrix anyMatrix)
        {
            Console.WriteLine("---------------------------------------------");
            if (anyMatrix.CanPrint == true)
            {
                for (int i = 0; i < anyMatrix.Size1; i++)
                {
                    for (int j = 0; j < anyMatrix.Size2; j++)
                    {
                        Write(anyMatrix.matrix[i, j] + " ");
                    }
                    WriteLine();
                }
                Write("\n");
                anyMatrix.CanPrint = false;
            }
            Console.WriteLine("---------------------------------------------");
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            WriteLine("----------------First * Second---------------\n");
            Matrix multiply = new Matrix(matrix1.Size1, matrix2.Size2);
            if (matrix1.Size2 == matrix2.Size1)
            {
                for (int i = 0; i < matrix1.Size1; i++)
                {
                    for (int j = 0; j < matrix2.Size2; j++)
                    {
                        for (int k = 0; k < matrix1.Size2; k++)
                        {
                            multiply.matrix[i, j] += matrix1.matrix[i, k] * matrix2.matrix[k, j];
                        }

                    }
                }
                multiply.CanPrint = true;
                return multiply;
            }
            else
            {
                multiply.CanPrint = false;
                Console.WriteLine("Cann't do this operation...( * )\n");
                return multiply;
            }
        }
        public static Matrix operator *(Matrix matrix1, int number)
        {
            WriteLine("-----------------Matrix *  5-----------------\n");
            Matrix multiply = new Matrix(matrix1.Size1, matrix1.Size2);
            for (int i = 0; i < matrix1.Size1; i++)
            {
                for (int j = 0; j < matrix1.Size2; j++)
                {
                    multiply.matrix[i, j] = matrix1.matrix[i, j] * number;
                }
            }
            multiply.CanPrint = true;
            return multiply;
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            WriteLine("---------------First + Second----------------\n");
            Matrix add = new Matrix(matrix1.Size1, matrix1.Size2);
            if (matrix1.Size1 == matrix2.Size1 && matrix1.Size2 == matrix2.Size2)
            {
                for (int i = 0; i < matrix1.Size1; i++)
                {
                    for (int j = 0; j < matrix1.Size2; j++)
                    {
                        add.matrix[i, j] = matrix1.matrix[i, j] + matrix2.matrix[i, j];
                    }
                }
                add.CanPrint = true;
                return add;
            }
            else
            {
                Console.WriteLine("Can't do this operation...( + )\n");
                add.CanPrint = false;
                return add;
            }

        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            WriteLine("---------------First - Second----------------\n");
            Matrix minus = new Matrix(matrix1.Size1, matrix1.Size2);
            if (matrix1.Size1 == matrix2.Size1 && matrix1.Size2 == matrix2.Size2)
            {
                for (int i = 0; i < matrix1.Size1; i++)
                {
                    for (int j = 0; j < matrix1.Size2; j++)
                    {
                        minus.matrix[i, j] = matrix1.matrix[i, j] - matrix2.matrix[i, j];
                    }
                }
                minus.CanPrint = true;
                return minus;
            }
            else
            {
                Console.WriteLine("Can't do this operation...( - )\n");
                minus.CanPrint = false;
                return minus;
            }
        }
    }
}