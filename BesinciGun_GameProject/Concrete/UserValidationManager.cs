using BesinciGun_GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1996 && gamer.FirstName=="BÜŞRA NUR"&& gamer.LastName=="CANSIZOĞLU"&& gamer.Id==1 && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
