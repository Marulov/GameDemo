using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    public class SteamSaleManager : ISaleService
    {
        public void BuyGame(IEntity game, IEntity player)
        {
            Console.WriteLine($"{player.Name} adlı oyuncu {game.Name} oyununu Steam platformundan satın aldı.");
        }
    }
}
