using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Monsters
{
    class Spider : IMonster
    {
        public void BattleRoar()
        {
            Console.WriteLine("Ааааааааааахрщщщщщщщщщ");
        }

        public override string ToString()
        {
            return "Гигантский паук";
        }

    }
}
