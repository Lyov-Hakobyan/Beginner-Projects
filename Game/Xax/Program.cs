using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Xax
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please enter your NAME and MONEY\n");
            string name = "";
            while (true)
            {
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Wrong input !!! Try Again");
                }
                else
                {
                    break;
                }
            }
            int money = 0;
            while (true)
            {
                try
                {
                    money = int.Parse(ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Wrong Input !!! Try Again");
                }
            }
            Game xax = new Game(name, money);
        }
    }
}
  
