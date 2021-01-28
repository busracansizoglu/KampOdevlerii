using BesinciGun_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer); //interface yapan herkes bu implementasyonu kullanmak zorunda (İmza diyoruz..)
    }
}
