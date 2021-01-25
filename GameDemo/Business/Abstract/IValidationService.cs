using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Abstract
{
    public interface IValidationService
    {
        bool CheckRealPerson(IEntity entity);
    }
}
