using GameProject2.Abstract;
using System;
namespace GameProject2.Entities
{
   public class Game : IEntity
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
