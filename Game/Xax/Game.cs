using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Xax
{
    enum EasyMediumHard
    {
        Easy = 1,
        Medium,
        Hard,
    }
    class Game
    {
        private Player player;
        Bot bot;
        public Game(string name, int money)
        {
            this.player = new Player(name, money);
            bot = new Bot();
            Start();
        }
        class Bot
        {
            Random rd = new Random();
            public int Zar()
            {
                int zar = rd.Next(1, 7);
                return zar;
            }
        }
        private void Start()
        {
            int Money = player.money;
            while (Money > 0)
            {
                bool TypeOfGame = false;
                int[] Numbers;
                int EnumNumber = 1;
                while (TypeOfGame == false)
                {
                    WriteLine("\nEasy?\nMedium?\nHard?\n");
                    string Easy_Madium_Hard = ReadLine().ToLower();
                    while (EnumNumber < 4)
                    {
                        if (((EasyMediumHard)(EnumNumber)).ToString().ToLower() == Easy_Madium_Hard)
                        {
                            WriteLine("-----" + (EasyMediumHard)(EnumNumber) + "-----\n");
                            TypeOfGame = true;
                            break;
                        }
                        EnumNumber++;
                    }
                    if (TypeOfGame == false)
                    {
                        EnumNumber = 0;
                        Clear();
                        WriteLine("\nWrong type of game\nEnter type again");
                    }
                }
                Clear();
                Numbers = new int[EnumNumber * 2];
                int count = 0;
                WriteLine("-----Bet-----\n");
                int stavka = player.Stavka();
                WriteLine("Enter your numbers\n");
                int number = 0;
                while (count < EnumNumber)
                {
                    number = player.YourNumber();
                    Numbers[count] = number;
                    count++;
                }
                int zar = 0;
                Console.WriteLine("-----Random-----\n");
                while (count < 2 * EnumNumber)
                {
                    zar = bot.Zar();
                    Console.Write(zar + "\t");
                    Numbers[count] = zar;
                    count++;
                }
                WriteLine();
                bool b = false;
                for (int i = 0; i < EnumNumber; i++)
                {
                    for (int j = EnumNumber; j < EnumNumber * 2; j++)
                    {
                        if (Numbers[i] == Numbers[j])
                        {
                            Numbers[j] = 0;
                            b = true;
                            break;
                        }
                        else
                        {
                            b = false;
                        }
                    }
                    if (b == false)
                    {
                        break;
                    }
                }
                if (b == true)
                {
                    Money += stavka;
                    player.money = Money;
                    Console.WriteLine("You win!!!...Your money = " + Money + "\n");
                }
                else
                {
                    Money -= stavka;
                    player.money = Money;
                    Console.WriteLine("You Lose...Your money = " + Money + "\n");
                }
                if (Money > 0)
                {
                    Console.WriteLine("Press enter if you want play again");
                    if (ReadKey().Key == ConsoleKey.Enter)
                    {
                        Clear();
                        WriteLine(player.name + " you have " + Money + " money!!!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Dear " + player.name.ToUpper() + " your money = " + Money + "\nGoodbye...");

                    }
                }

            }
            Console.WriteLine("Game over");
        }
    }

}