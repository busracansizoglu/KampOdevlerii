using BesinciGun_InterfaceAbstractDemo.Adstract;
using BesinciGun_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;


        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        //override --- deyip --- Save(Customer){...}--- diyoruz.

        //public override void save(customer customer)
        //{

        //    base.save(customer);
        //}

        //burası veritabanına kayıt edilen kod burası kalacak "base.Save(customer);" üzerine 
        //mernis doğrulaması yapıcaz..
        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
                

            }
            else
            {
                throw new Exception("Not a valid person");
            }
            //CheckIfRealPerson(customer);
            //base.Save(customer);

        }
        //Create Method yapıyoruz (CheckIfRealPerson)
        //Doğru olmasını istiyoruz 
        //private void CheckIfRealPerson(Customer customer)
        //{
        //     buraya bütün kodları yazabiliriz Fakat Kahve firması yarın;
        //     "Ben Nero içinde doğrulama istiyorum" derse ne yapıcaz???
        //     böyle bir senaryoda devreye İnterfacelerin operasyon sınıflandırılması devreye giriyor..(IPersonCheckService)
        //}
    }
}
