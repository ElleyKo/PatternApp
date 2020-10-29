using SharpFactory.GameObjects;
using SharpFactory.Locations;
using System;

namespace SharpFactory.Games
{
    /// <summary>
    /// Экземпляр игры.
    /// </summary>
    class Game
    {
        private Dangeon location;
        private Hero gamer;

        public Game(IMonsterFactory factory)
        {
            gamer = new Hero(); // герой, за которого играем

            //Список комнат в локации
            Room[] rooms = new Room[]
            {
                new Room(),
                new Room(),
                new Room()
            };

            //Список сокровищ в локации
            Treasure[] treasures = new Treasure[]
            {
                new Treasure(),
                new Treasure(),
                new Treasure()
            };

            IMonster[] monsters = new IMonster[50]; // Список монстров в локации

            for(int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = factory.Create(); // задаем тип монстра
            }

            location = new Dangeon(monsters, rooms, treasures); // инициализация игровой локации
        }

        /// <summary>
        /// Рендеринг игровых элементов (в идеале)
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("Локация загружена.");
            Console.WriteLine("Комнаты расставлены.");
            Console.WriteLine("Сокровища расставлены.");
            Console.WriteLine("Монстры на местах");
            Console.WriteLine("Игрок загружен");
            Console.WriteLine("Игра началась...");

            location.MontersInfo(); // Выясним сколько у нас монстров каждого типа
        }

    }
}
