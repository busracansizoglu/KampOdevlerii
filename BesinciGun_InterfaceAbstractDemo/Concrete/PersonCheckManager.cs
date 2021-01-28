using BesinciGun_InterfaceAbstractDemo.Abstract;
using BesinciGun_InterfaceAbstractDemo.Adstract;
using BesinciGun_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
            //MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient();
            //böyle yaparsak web sitede sıkıntı olursa bizde sıkıntı yaşarız. Bu yüzden;
            //bir adaptöre ihtiyaç var.. yeni klasör oluşturuyoruz..(Adapters)
        }
    }
}
