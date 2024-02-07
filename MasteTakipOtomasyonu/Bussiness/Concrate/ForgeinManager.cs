using Business.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class ForgeinManager:IAplicantService
    {
        public void AplayForMask(Person person)
        {

        }
        public List<Person> GetAllPersons()
        {
            return null;
        }
        public bool CheckRealPerson(Person person)
        {
            return true;
        }
    }
}
