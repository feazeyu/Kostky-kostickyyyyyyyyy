using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavLidi
{
    class Program
    {
        public static int selected = 1;
        public static char pressedKey;
        public static int times;
        public static List<Dice> playerDiceList = new List<Dice>();
        static void Main(string[] args)
        {
            playerDiceList.Add(new Dice(6));
            while (true) {
                pressedKey = Console.ReadKey().KeyChar;

                switch (pressedKey)
                {
                    default: Console.Clear(); Console.WriteLine("No");break;
                    case 'e': Environment.Exit(0); break;
                    case 'd':Console.Clear(); Console.WriteLine($"You rolled: {rollAll(playerDiceList)} in total"); break;
                    case 'n':Console.Clear(); Console.WriteLine("How many sides should thy die have?");playerDiceList.Add(new Dice(int.Parse(Console.ReadLine())));Console.Clear();break;
                    case 'g':Console.Clear();Console.WriteLine("How many times do you want to roll the dice?"); times = int.Parse(Console.ReadLine()); for (int l = 0; l < times;l++){ rollAll(playerDiceList);} ; break;
                }
                }
        }
        static void select(int dir) {
            selected += dir;

        }
        static int rollAll(List<Dice> list) {
            int sum = 0;
            foreach (Dice x in list) {
               int rollResult = x.Roll();
               sum += rollResult;
                x.hits[rollResult-1] += 1;
                Console.WriteLine($"{x.sides}-sided die:");
                for (int i = 0; i < x.sides; i++)
                {
                    Console.WriteLine($"{i+1} was rolled {x.hits[i]} times on this die, totaling {x.hits[i]*100/x.rolls}%");
                }
                Console.WriteLine($"You have rolled this die {x.rolls} times");
                Console.WriteLine();
            }
            return sum;
        }
    }
}
