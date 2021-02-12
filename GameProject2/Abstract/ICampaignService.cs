using System;
using System.Collections.Generic;
using System.Text;
using GameProject2.Entities;
namespace GameProject2.Abstract
{
   public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
