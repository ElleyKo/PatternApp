using SharpFactory.Factories;
using SharpFactory.Games;
using System;

namespace SharpFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonsterFactory[] lvls = new IMonsterFactory[]
            {
                new EasyLevelMonsterFactory(),
                new MiddleLevelMonsterFactory(),
                new HardLevelMonsterFactory()
            };

            Console.WriteLine("Выберите уровень сложности и введите его номер.");
            
            // Выведем все уровни сложности пользователю
            for(int i = 0; i < lvls.Length; i++)
            {
                Console.WriteLine($"{i+1}.{lvls[i].ToString()}");
            }

            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            if(lvlNumber > -1 && lvlNumber < lvls.Length)
            {
                Game game = new Game(lvls[lvlNumber]); // создаем игру
                game.StartGame();
            }
            else
            {
                Console.WriteLine("Указанный уровень отсутствует.");
            }

            Console.ReadKey(); // Задержка экрана.
        }
    }
}
