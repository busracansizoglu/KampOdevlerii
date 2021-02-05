using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_GameProject.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
