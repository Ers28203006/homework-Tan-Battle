using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WordOfTanks;

namespace Day7__Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            string tankName;
            int tankLevelAmunition;
            int tankLevelArmor;
            int tankLevelAgility;

            Random random = new Random();
            int numberOfTanks = 5;
            string winner;

            int allyWinCounter = 0;
            int enemyWinCounter = 0;

            bool continueGame = true;
            int gameContinue;

            while (continueGame)
            {
                for (int i = 1; i <= numberOfTanks; i++)
                {
                    tankName = "T-34";
                    tankLevelAmunition = random.Next(0, 100);
                    tankLevelArmor = random.Next(0, 100);
                    tankLevelAgility = random.Next(0, 100);
                    Tank tankAlly = new Tank(tankName, tankLevelAmunition,
                        tankLevelArmor, tankLevelAgility);
                    tankAlly.ShowTankParametrs();

                    tankName = "Pantera";
                    tankLevelAmunition = random.Next(0, 100);
                    tankLevelArmor = random.Next(0, 100);
                    tankLevelAgility = random.Next(0, 100);
                    Tank tankEnemy = new Tank(tankName, tankLevelAmunition,
                        tankLevelArmor, tankLevelAgility);
                    tankEnemy.ShowTankParametrs();

                    winner = tankAlly * tankEnemy;
                    Console.WriteLine("Битву выиграл: " + winner);

                    Console.WriteLine();
                    Console.WriteLine("###################################");
                    if (winner == tankAlly.TankName)
                    {
                        ++allyWinCounter;
                    }

                    if (winner == tankEnemy.TankName)
                    {
                        ++enemyWinCounter;
                    }
                }

                if (allyWinCounter > enemyWinCounter)
                {
                    Console.WriteLine("Победил: T-34 !!!");
                }
                else if (allyWinCounter < enemyWinCounter)
                {
                    Console.WriteLine("Победил: Pantera !!!");
                }

                else
                {
                    Console.WriteLine("Ни чья !!!");
                }

                Console.WriteLine("Хотите еще с играть?");
                Console.WriteLine("ДА - 1");
                Console.WriteLine("НЕТ - 0");
                gameContinue = int.Parse(Console.ReadLine());

                if (gameContinue>0)
                {
                    System.Console.Clear();

                }
                else
                {
                    continueGame = false;
                }
            }
        }
    }
}
