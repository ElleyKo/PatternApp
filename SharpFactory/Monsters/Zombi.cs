using System;

namespace SharpFactory.Monsters
{
    class Zombi : IMonster
    {
        public void BattleRoar()
        {
            Console.WriteLine("Я голоден. Вот и еда пожаловала!");
        }

        public override string ToString()
        {
            return "Зомби";
        }

    }
}
