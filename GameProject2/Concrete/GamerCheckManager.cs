using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Abstract;
using GameProject2.Entities;
using MernisServiceReference;

namespace GameProject2.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
            
        }
    }
}
