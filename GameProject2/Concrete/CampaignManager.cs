using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Entities;
using GameProject2.Abstract;

namespace GameProject2.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi " + campaign.CampaignName);
        }
    }
}
