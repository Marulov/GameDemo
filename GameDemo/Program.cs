using GameDemo.Business.Abstract;
using GameDemo.Business.Concrete;
using System;
using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oyuncuları ekledik
            IEntity player1 = new Player { Id = 1, Name = "Nazım", LastName = "Marul", DateOfBirthYear = "1999", NationalityNumber = "12345678901" };
            IEntity player2 = new Player { Id = 2, Name = "Emre", LastName = "Yılmaz", DateOfBirthYear = "2001", NationalityNumber = "59124853215" };
            IEntity player3 = new Player { Id = 3, Name = "Zeynep", LastName = "Çakır", DateOfBirthYear = "1998", NationalityNumber = "15482452565" };
            // oyuncu ekleme işlemi
            IEntityService playerManager = new PlayerManager(new EdevletValidationManager());
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

            Console.WriteLine("*****************************\nTüm oyuncular");

            // tüm playerları döndük.
            List<IEntity> players = new List<IEntity> { player1, player2, player3 };
            playerManager.GetAll(players);

            Console.WriteLine("*****************************");

            //Oyunları ekledik
            IEntity game1 = new Game { Id = 1, Name = "GTA5", Price = 85, Stock = 1000 };
            IEntity game2 = new Game { Id = 2, Name = "Pubg", Price = 49, Stock = 500 };
            IEntity game3 = new Game { Id = 3, Name = "Valorant", Price = 0, Stock = 8000 };
            // oyun ekleme işlemi
            IEntityService gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Console.WriteLine("*****************************\nTüm oyunlar");

            //tüm oyunları döndük.
            List<IEntity> games = new List<IEntity> { game1, game2, game3 };
            gameManager.GetAll(games);
            Console.WriteLine("*****************************");

            // epicten oyun satın alınmasını simüle ettik
            ISaleService saleEpic = new EpicSaleManager();
            saleEpic.BuyGame(game1, player2);

            Console.WriteLine("*****************************");

            //steamden oyun satın alınmasını simüle ettik.
            ISaleService saleSteam = new SteamSaleManager();
            saleSteam.BuyGame(game2, player1);

            Console.WriteLine("*****************************");

            // yeni yıl kampanyası 
            ICampaignService newYearCampaign = new NewYearCampaignManager();
            newYearCampaign.Add(game1);

            Console.WriteLine("*****************************");

            // cadılar bayramı kampanyası
            ICampaignService halloweenCampaign = new HalloweenCampaignManager();
            halloweenCampaign.Add(game2);
            Console.WriteLine("*****************************");





        }
    }
}
