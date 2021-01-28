using BesinciGun_InterfaceAbstractDemo.Abstract;
using BesinciGun_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Adstract
{
    
    public abstract class BaseCustomerManager : ICustomerService
    {
        //Ortak operasyon // starbucks da verileri doğrulatmak istiyoruz..
        //public virtual---- dersek ben bunu ezebilirim demek.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : "+ customer.FirstName);
            //throw new NotImplementedException();
            //Abstract sınıfın içinde tamamlanmış yani içi dolu metot yapabiliyoruz..
        }
    }
}
