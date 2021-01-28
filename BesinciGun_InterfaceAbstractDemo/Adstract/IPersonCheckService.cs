using BesinciGun_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Adstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        
    }
}
