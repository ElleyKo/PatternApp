using SharpFactory.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Factories
{
    /// <summary>
    /// Средний уровень сложности. Фабрика, генерирующая монстров.
    /// </summary>
    class MiddleLevelMonsterFactory : IMonsterFactory
    {
        private static Random rnd = new Random();

        private static int necromancerCount = 0;

        public IMonster Create()
        {
            if (necromancerCount < 10)
            {
                necromancerCount += 1;
                return new Necromancer(); // генерируем баньши для сложного уровня
            }
            IMonsterFactory easyFactory = new EasyLevelMonsterFactory();
            return easyFactory.Create();
        }

        public override string ToString()
        {
            return "Средний уровень сложности";
        }
    }
}
