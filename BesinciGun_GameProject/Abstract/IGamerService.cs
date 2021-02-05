using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Abstract
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
