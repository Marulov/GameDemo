using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(IEntity game);
        void Delete(IEntity game);
        void Update(IEntity game);
    }
}
