using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    class HalloweenCampaignManager : ICampaignService
    {
        public void Add(IEntity game)
        {
            Console.WriteLine($"{game.Name} oyununa cadılar bayramı indirimi uygulanmıştır.");
        }

        public void Delete(IEntity game)
        {
            Console.WriteLine($"{game.Name} oyununun cadılar bayramı indirimi kaldırılmıştır.");
        }

        public void Update(IEntity game)
        {
            Console.WriteLine($"{game.Name} oyununun cadılar bayramı indirimi güncellenmiştir.");
        }
    }
}
