using BesinciGun_InterfaceAbstractDemo.Adstract;
using BesinciGun_InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Threading.Tasks;

namespace BesinciGun_InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public static async Task<bool> TaskAsync(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
                customer.FirstName, customer.LastName, customer.DateOfBirth.Year));
            return result.Body.TCKimlikNoDogrulaResult;
        }
        public bool CheckIfRealPerson(Customer customer)
        {
            return TaskAsync(customer).Result;
            

        }
    }
    
}
