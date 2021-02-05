using BesinciGun_GameProject.Concrete;
using BesinciGun_GameProject.Entities;
using BesinciGun_GameProject.Abstract;
using System;

namespace BesinciGun_GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1996, IdentityNumber = 12345, FirstName = "BÜŞRA NUR", LastName = "CANSIZOĞLU", });
            
            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1, Name = "%50 İndirim!" });
            
            
            OrderManager orderManager = new OrderManager();
            orderManager.Add(new Game {Id=2,CategoryId=22,GameName="Fifa 21" }, new Gamer { Id = 1, BirthYear = 1996, IdentityNumber = 12345, FirstName = "BÜŞRA NUR", LastName = "CANSIZOĞLU" },new Campaign{ Id = 1, Name= "%50 İndirim!" });

            

            

        }
    }
}
