using BesinciGun_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Abstract
{
    interface IOrderService
    {
        void Add(Gamer gamer, Game game, Campaign campaign);
        void Update(Gamer gamer, Game game, Campaign campaign);
    }
}
