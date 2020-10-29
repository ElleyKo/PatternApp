using SharpFactory.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Factories
{
    /// <summary>
    /// Фабрика, генерирующего монстров для самого сложного уровня.
    /// </summary>
    class HardLevelMonsterFactory : IMonsterFactory
    {
        private static Random rnd = new Random();

        private static int HardMonstersCount = 0;

        public IMonster Create()
        {
            if(HardMonstersCount < 10)
            {
                HardMonstersCount += 1;
                return new Banshi(); // генерируем баньши для сложного уровня
            }
            IMonsterFactory midLevelFactory = new MiddleLevelMonsterFactory();
            return midLevelFactory.Create();
        }

        public override string ToString()
        {
            return "Сложный уровень сложности";
        }
    }
}
