
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MatrixCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Clear();
                Console.WriteLine("Enter sizes of first matrix\n");
                int size1_1 = 0;
                while (true)
                {
                    try
                    {
                        size1_1 = int.Parse(ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
                int size1_2 = 0;
                while (true)
                {
                    try
                    {
                        size1_2 = int.Parse(ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
                Console.WriteLine("Enter sizes of second matrix\n");
                int size2_1 = 0;
                while (true)
                {
                    try
                    {
                        size2_1 = int.Parse(ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
                int size2_2 = 0;
                while (true)
                {
                    try
                    {
                        size2_2 = int.Parse(ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
                Matrix matrix1 = new Matrix(size1_1, size1_2);
                Matrix.MatrixPrint(matrix1);
                Matrix matrix2 = new Matrix(size2_1, size2_2);
                Matrix.MatrixPrint(matrix2);
                Matrix.MatrixPrint(matrix1 * 5);
                Matrix.MatrixPrint(matrix1 * matrix2);
                Matrix.MatrixPrint(matrix1 - matrix2);
                Matrix.MatrixPrint(matrix1 + matrix2);
                WriteLine("Press Enter if you want do this again");
            } while (ReadKey().Key == ConsoleKey.Enter);
        }
    }
}