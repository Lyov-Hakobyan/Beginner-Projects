using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace FormPrint
{

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Clear();
                Console.WriteLine("Enter form\n1 - Triangle\n2 - Rectangle\n3 - Circle");
                string figure = ReadLine();
                figure = figure.ToLower();
                if (figure == "triangle" || figure == "1")
                {
                    Console.WriteLine("Enter size");
                    int tiv1 = 0;
                    while (true)
                    {
                        try
                        {
                            tiv1 = int.Parse(ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong Input...Try again");
                        }
                    }
                    Triangle tiv = new Triangle(tiv1);
                    tiv.TrianglePrint();
                }
                else if (figure == "rectangle" || figure == "2")
                {
                    Console.WriteLine("Enter sizes");
                    int tiv1 = 0;
                    while (true)
                    {
                        try
                        {
                            tiv1 = int.Parse(ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong Input...Try again");
                        }
                    }
                    int tiv2 = 0;
                    while (true)
                    {
                        try
                        {
                            tiv2 = int.Parse(ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong Input...Try again");
                        }
                    }
                    Rectangle tiv = new Rectangle(tiv1, tiv2);
                    tiv.RectanglePrint();

                }
                else if (figure == "circle" || figure == "3")
                {
                    Console.WriteLine("Enter Radius");
                    int tiv1 = 0;
                    while (true)
                    {
                        try
                        {
                            tiv1 = int.Parse(ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong Input...Try again");
                        }
                    }
                    Circle radius = new Circle(tiv1);
                    radius.CirclePrint();
                }
                else
                {
                    WriteLine("Wrong input!!!");
                }
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Press enter to continue");
            } while (ReadKey().Key == ConsoleKey.Enter);
        }
    }

    
    class Triangle
    {
        int a;
        public Triangle(int a)
        {
            this.a = a;
        }
        public void TrianglePrint()
        {
            Random rd = new Random();


            for (int i = 0; i < a; i++)
            {
                ForegroundColor = (ConsoleColor)rd.Next(1, 16);
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i || i == a - 1)
                        Write("* ");
                    else
                        Write("  ");

                }
                WriteLine();
            }
        }
    }
    class Rectangle
    {
        int a;
        int b;
        Random rd = new Random();
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void RectanglePrint()
        {

            ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < a; i++)
            {
                Write("*");
                for (int k = 0; k < (b - 2); k++)
                {
                    if (i == 0 || i == a - 1)
                    {
                        Write("*");
                    }
                    else Write(" ");
                }
                WriteLine("*");
            }
        }
    }
    class Circle
    {
        int r;
        public Circle(int r)
        {
            this.r = r;
        }
        public void CirclePrint()
        {
            Random rd = new Random();

            while (r > 0)
            {
                if (r > Math.Min(WindowWidth / 2, WindowHeight / 2))
                {
                    WriteLine("Radius should be less then " + Math.Min(WindowHeight / 2, WindowWidth / 2));
                    WriteLine("Enter new Radius");
                    while (true)
                    {
                        try
                        {
                            r = int.Parse(ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Wrong Input...Try again");
                        }
                    };
                    continue;
                }

                for (double x = -r; x <= r; x++)
                {
                    int yTop = (int)Sqrt(Pow(r, 2) - Pow(x, 2)) / 2;
                    int yBattom = -yTop;
                    yTop += WindowHeight / 2;
                    yBattom += WindowHeight / 2;
                    ForegroundColor = ConsoleColor.White;
                    SetCursorPosition((int)x + WindowWidth / 2, yTop);
                    WriteLine("*");
                    SetCursorPosition((int)x + WindowWidth / 2, yBattom);
                    WriteLine("*");
                }
                ResetColor();
                r--;
            }
        }
    }
}