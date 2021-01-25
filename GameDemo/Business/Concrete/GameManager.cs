using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    public class GameManager : IEntityService
    {
        public void Add(IEntity entity)
        {
            
            Console.WriteLine("Yeni oyun eklendi : " + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Oyun silindi : " + entity.Name);
        }

        public void GetAll(List<IEntity> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game.Name);
            }
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Oyun güncellendi : " + entity.Name);
        }
    }
}
