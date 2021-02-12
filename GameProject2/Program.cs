using System;
using GameProject2.Abstract;
using GameProject2.Adapter;
using GameProject2.Concrete;
using GameProject2.Entities;
using MernisServiceReference;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() { FirstName = "Yağmur" ,LastName = "Engin", NationalityId = 1, YearOfBirth = 2000};

            BaseGamerManager gamer2 = new BattlefieldGamerManager(new GamerCheckManager());
            gamer2.Save(new Gamer { FirstName = "Gürsel", LastName = "Tantoğlu", NationalityId = 2, YearOfBirth = 1969 });
           

            Console.WriteLine("---------------------------------------------");

            Game game1 = new Game() { GameName = "Battlefield", GamePrice = 159.00 };
            GameManager game2 = new GameManager();
            game2.Add(new Game {GameName = "The Sims 4" , GamePrice = 151.99});

            Console.WriteLine("---------------------------------------------");

            Campaign campaign1 = new Campaign() { CampaignName = "Kış Sezonu ", CampaignDiscount = 10 };
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(new Campaign { CampaignName = "Açılış İndirimi ", CampaignDiscount = 6 });

            Console.WriteLine("---------------------------------------------");

            ISalesService salesService = new SalesManager();
            salesService.CampaignSale(game1,gamer1,campaign1);

           
            

            

        }
    }
}
