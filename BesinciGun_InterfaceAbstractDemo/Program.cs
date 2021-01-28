using BesinciGun_InterfaceAbstractDemo.Adapters;
using BesinciGun_InterfaceAbstractDemo.Adstract;
using BesinciGun_InterfaceAbstractDemo.Concrete;
using BesinciGun_InterfaceAbstractDemo.Entities;
using System;

namespace BesinciGun_InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter ());
            customerManager.Save(new Customer {DateOfBirth= new DateTime(1996,12,15), FirstName ="BÜŞRA NUR" , LastName = "CANSIZOĞLU", NationalityId = "63799215024"});
            Console.ReadLine();
            
        }
    }
}


