using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Abstract;
using GameProject2.Entities;

namespace GameProject2.Concrete
{
  public  class BattlefieldGamerManager : BaseGamerManager 
    {
        IGamerCheckService _gamerCheckService;

        public BattlefieldGamerManager(IGamerCheckService gamerCheckService)
        {
            this._gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
                Console.WriteLine("Valid person");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
           

        }
        

    }
}
