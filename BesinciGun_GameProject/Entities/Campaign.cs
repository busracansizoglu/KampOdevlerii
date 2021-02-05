using BesinciGun_GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Entities
{
    public class Campaign : ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
