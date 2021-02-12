using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Abstract;
using GameProject2.Entities;

namespace GameProject2.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun " + gamer.FirstName  + gamer.LastName + " Adlı Oyuncuya " + campaign.CampaignName 
                + " Kampanyasıyla  %  " + campaign.CampaignDiscount + " indirimle satılmıştır. "  ) ;
        }

        public void GameSale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + "adlı oyun" + gamer.FirstName + gamer.LastName + "adlı oyuncuya satılmıştır");
        }
    }
}
