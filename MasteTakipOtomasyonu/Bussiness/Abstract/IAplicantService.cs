using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAplicantService
    {
        void AplayForMask(Person person);
        
        List<Person> GetAllPersons();


        bool CheckRealPerson(Person person);
        
    }
}
