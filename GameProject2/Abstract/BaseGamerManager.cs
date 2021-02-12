using GameProject2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Abstract//ortak operasyon
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(" Saved to db : " + gamer.FirstName);
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Deleted from db : " + gamer.FirstName);
        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine(" Updated in db : " + gamer.FirstName);
        }
    }
}
