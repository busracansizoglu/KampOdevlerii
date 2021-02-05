using BesinciGun_GameProject.Abstract;
using BesinciGun_GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using BesinciGun_GameProject.Concrete;

namespace BesinciGun_GameProject.Concrete
{
    public class OrderManager 
    {
        internal void Add(Game game,Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Sayın: " + " " + gamer.FirstName + " " + gamer.LastName + " " + campaign.Name + " Kampanyalı " + game.GameName + " Oyun Siparişiniz eklendi.");
        }

        internal void Delete(Game game, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine("Sayın: " + " " + gamer.FirstName + " " + gamer.LastName + " " + campaign.Name + " Kampanyalı " + game.GameName + " Oyun Siparişiniz silindi.");
        }
    }   
  
}
