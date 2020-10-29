using SharpFactory.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Factories
{
    /// <summary>
    /// Фабрика, генерирующая монстров для простого уровня сложности.
    /// </summary>
    class EasyLevelMonsterFactory : IMonsterFactory
    {
        private static Random rnd = new Random();

        public IMonster Create()
        {
            string[] monsters = new string[]
            {
                "Гигантский паук",
                "Ядовитая змея",
                "Зомби"
            };

            // рандомно генерируем слабых монстров
            switch(monsters[rnd.Next(0, monsters.Length)])
            {
                case "Гигантский паук":
                    return new Spider();
                case "Ядовитая змея":
                    return new Snake();
                case "Зомби":
                    return new Zombi();
                default:
                    throw new Exception("Упомянутый монстр не существует.");
            }
        }

        public override string ToString()
        {
            return "Лёгкий уровень сложности";
        }
    }
}
