using BesinciGun_InterfaceAbstractDemo.Adstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Concrete
{
    //concrete- somut / daha sonra soyut yapıcaz..
    //NeroCustomerManager & StarbucksCustomerManager da ikisindede aynı kod yazılacak dolayısıyla ;
    //şöyle yapabilirdik;
    //public class NeroCustomerManager : ICustomerService diyip NeroCustomerManager'a ayrı kodlayıp 
    //Starbucks'a ayrı kodlayıp aynı şeyi yapabilirdik Ama ;
    //NeroCustomerManager & StarbucksCustomerManager da ikisindede ortak kod var yani code implementasyonu var
    //yani ABSTRACT olacak...

    public class NeroCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;
        public NeroCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;

        }
        public override void Save(Entities.Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
                throw new Exception("Tebrikler..");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
      
