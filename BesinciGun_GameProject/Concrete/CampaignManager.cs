using BesinciGun_GameProject.Abstract;
using BesinciGun_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Concrete
{
    class CampaignManager 
    {
        

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }


        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
