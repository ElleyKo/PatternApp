using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Monsters
{
    class Snake : IMonster
    {
        public void BattleRoar()
        {
            Console.WriteLine("Шшшшшшшшшшшшшш");
        }

        public override string ToString()
        {
            return "Ядовитая змея";
        }

    }
}
