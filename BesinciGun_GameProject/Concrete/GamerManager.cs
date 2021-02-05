using BesinciGun_GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Sayın ;" + gamer.FirstName+" " +gamer.LastName+ " Kaydınız Tamamlandı.");
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Sayın ;" + gamer.FirstName + " " + gamer.LastName + " Kaydınız Silindi.");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Sayın ;" + gamer.FirstName + " " + gamer.LastName + " Kaydınız Güncellendi.");

        }
    }
}
