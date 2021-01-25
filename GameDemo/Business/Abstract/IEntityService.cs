using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Abstract
{
    public interface IEntityService
    {
        void GetAll(List<IEntity> entities);
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
        
    }
}
