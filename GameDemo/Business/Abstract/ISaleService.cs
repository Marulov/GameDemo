using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Abstract
{
    public interface ISaleService
    {
        void BuyGame(IEntity game, IEntity player);
        
    }
}
