using Business.Abstract;
using Entities.Concrate;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class PersonManager:IAplicantService
    {
        public void AplayForMask(Person person)
        {

        }
        public List<Person> GetAllPersons()
        {
            return null;
        }
        public bool CheckRealPerson(Person person) {
            KPSPublicSoapClient client = new KPSPublicSoapClient(new KPSPublicSoapClient.EndpointConfiguration());
            Console.WriteLine("Sorgulanyor");
            
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
           // bool a = client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest()).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
