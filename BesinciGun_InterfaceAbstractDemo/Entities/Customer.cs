using BesinciGun_InterfaceAbstractDemo.Adstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BesinciGun_InterfaceAbstractDemo.Entities
{
    // katmanlı yapılarda(klasörledik) başa public yazıyoruz(public class.... diye yazılır!)
    public class Customer : IEnitity
    {// bir customer nesnem varsa o customer nesnesinin ICustomer'ı olmak zorunda...
     //Somut sınıflar eğer çıplak kalıyorsa yani herhangi bir inheritance veya implemantasyon almıyorsa
     //ilerde nesnellik zaafiyeti yaşayacağız!!! (IEntity ile implemente ediyoruz...)


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; } 
    }
}
