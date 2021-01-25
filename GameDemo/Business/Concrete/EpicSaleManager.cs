using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using GameDemo.Business.Concrete;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    public class EpicSaleManager : ISaleService
    {
        public void BuyGame(IEntity game, IEntity player)
        {
           
            Console.WriteLine($"{player.Name} adlı oyuncu {game.Name} oyununu Epic platformundan satın aldı.");
        }

    }
}
