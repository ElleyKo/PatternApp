using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Monsters
{
    class Banshi : IMonster
    {
        public void BattleRoar()
        {
            Console.WriteLine("Вот мы и встретились с твоей душой! Аааааааааааааа!");
        }

        public override string ToString()
        {
            return "Баньши";
        }

    }
}
