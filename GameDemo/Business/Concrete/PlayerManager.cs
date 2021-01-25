using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    public class PlayerManager : IEntityService
    {
        private IValidationService _validationService;
        public PlayerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }
        public void Add(IEntity entity)
        {
            if (_validationService.CheckRealPerson(entity))
            {
                Console.WriteLine("Yeni oyuncu eklendi : " + entity.Name);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi : " + entity.Name);
            }
            
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Oyuncu silindi : " + entity.Name);
        }

        public void GetAll(List<IEntity> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine(player.Name);
            }
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Oyuncu güncellendi : " + entity.Name);
        }
    }
}
