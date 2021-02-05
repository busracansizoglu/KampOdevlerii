using BesinciGun_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Abstract
{
    internal interface ICampaignService
    {
        internal void Add(Campaign campaign);
        internal void Update(Campaign campaign);
        internal void Delete(Campaign campaign);
        
    }
}
