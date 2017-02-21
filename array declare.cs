using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_variables_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 12;
            int{ } numbersArray = new int { 5 };
            int actionPts = 15;
            int{ } numbersArray2 = new int { 15 };
            double armor = 5.5;
            double{ } numbersArray3 = new double { 5.5 };
            double attack = 17;
            double{ } attackArray = new double { 17 };
            Console.WriteLine(health);
            Console.ReadLine(health fully restored);
            Console.WriteLine(actionPts);
            Console.ReadLine(Action points);
            Console.WriteLine(armor);
            Console.ReadLine(armor restored);
            Console.WriteLine(attack);
            Console.ReadLine(damage on the enemy);
            ChangeStats(ref health, ref actionPts, ref armor, ref attack);
            Console.WriteLine(health);
            Console.ReadLine(health fully restored);
            Console.WriteLine(actionPts);
            Console.ReadLine(Action points);
            Console.WriteLine(armor);
            Console.ReadLine(armor restored);
            Console.WriteLine(attack);
            Console.ReadLine(damage on the enemy);
            Console.ReadLine();
        }
        static void ChangeStats(ref int health, ref int actionPts, ref double armor, ref double attack)
        {
            health = health + 5;
            actionPts = actionPts + 1;
            armor = armor - 1;
            attack = attack + 10;
        }
    }
}
