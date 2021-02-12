using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Entities;


namespace GameProject2.Abstract
{
    public interface ISalesService
    {
        void GameSale(Game game , Gamer gamer);
        void CampaignSale(Game game, Gamer gamer, Campaign campaign);
    }
}
