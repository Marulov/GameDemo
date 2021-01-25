using GameDemo.Business.Abstract;
using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    public class EdevletValidationManager : IValidationService
    {
        public bool CheckRealPerson(IEntity entity)
        {
                Console.WriteLine("Gerçek oyuncu");
                return true;
        }
    }
}
