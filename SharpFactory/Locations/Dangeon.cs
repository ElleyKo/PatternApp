using SharpFactory.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFactory.Locations
{
    /// <summary>
    /// Класс для локации игры. 
    /// Подземелье
    /// </summary>
    class Dangeon
    {
        /// <summary>
        /// Монстры, которых можно встретить
        /// </summary>
        private IMonster[] monsters;

        /// <summary>
        /// Комнаты персонажей в локации.
        /// </summary>
        private Room[] rooms;

        /// <summary>
        /// Сокровища, которые встречаются в локации.
        /// </summary>
        private Treasure[] treasures;

        public Dangeon(IMonster[] monsters, Room[] rooms, Treasure[] treasures)
        {
            this.monsters = monsters;
            this.rooms = rooms;
            this.treasures = treasures;
        }

        /// <summary>
        /// Выводит информацию о монстрах определенного типа в локации в консоль.
        /// </summary>
        public void MontersInfo()
        {
            var banshes = monsters.Where((item) => {
                return item.ToString() == "Баньши";
            }).Count();

            Console.WriteLine($"{banshes} Баньши");

            var necromancers = monsters.Where((item) => {
                return item.ToString() == "Некромансер";
            }).Count();

            Console.WriteLine($"{necromancers} Некромансер");

            var zombies = monsters.Where((item) => {
                return item.ToString() == "Зомби";
            }).Count();

            Console.WriteLine($"{zombies} Зомби");

            var snakes = monsters.Where((item) => {
                return item.ToString() == "Ядовитая змея";
            }).Count();

            Console.WriteLine($"{snakes} Ядовитая змея");

            var spiders = monsters.Where((item) => {
                return item.ToString() == "Гигантский паук";
            }).Count();

            Console.WriteLine($"{spiders} Гигантский паук");
        }

    }
}
