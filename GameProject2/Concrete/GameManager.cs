using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Abstract;
using GameProject2.Entities;

namespace GameProject2.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi  " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi " + game.GameName);
        }
    }
}
