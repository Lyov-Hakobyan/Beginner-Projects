using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Xax
{
    class Player
    {
        public string name;
        public int money;
        public Player(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
        public int Stavka()
        {
            int amount = int.Parse(ReadLine());
            if (amount > money)
            {
                WriteLine("Bet bigger than your money\nBet again");
                return Stavka();
            }
            return amount;
        }
        public int YourNumber()
        {
            int number = 0;
            number = int.Parse(ReadLine());
            while (number < 1 || number > 6)
            {
                Console.WriteLine("Invalid number\nEnter number between 1 to 6");
                number = int.Parse(ReadLine());
            }
            return number;
        }
    }
}

