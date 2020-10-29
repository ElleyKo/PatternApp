using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Monsters
{
    class Necromancer : IMonster
    {
        public void BattleRoar()
        {
            Console.WriteLine("Как давно я не находил материала для моего эксперимента. Здравствуй, путник. Сейчас ты умрёшь.");
        }

        public override string ToString()
        {
            return "Некромансер";
        }

    }
}
