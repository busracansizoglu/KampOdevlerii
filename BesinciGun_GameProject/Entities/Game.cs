
using BesinciGun_GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Entities
{
    class Game : IEntityGame
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }

    }
}
