using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Entities;
namespace GameProject2.Abstract
{
  public  interface IGamerService
    {
        void Save(Gamer gamer );
        void Update(Gamer gamer);
        void Delete(Gamer gamer);



    }
}
