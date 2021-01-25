using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    class NewYearCampaignManager : ICampaignService
    {
        public void Add(IEntity game)
        {
            Console.WriteLine($"{game.Name} oyununa yeni yıl indirimi uygulanmıştır.");
        }

        public void Delete(IEntity game)
        {
            Console.WriteLine($"{game.Name} oyununun yeni yıl indirimi kaldırılmıştır.");
        }

        public void Update(IEntity game)
        {
            Console.WriteLine($"{game.Name} oyununun yeni yıl indirimi güncellenmiştir.");
        }
    }
}
