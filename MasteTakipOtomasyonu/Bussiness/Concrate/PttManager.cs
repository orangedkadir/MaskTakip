using Business.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class PttManager:ISupplier
    {
        public IAplicantService _aplicantService;
        public PttManager(IAplicantService aplicantService)
        {
            _aplicantService = aplicantService;
        }
        public void GiveMask(Person person)
        {
            if (_aplicantService.CheckRealPerson(person)) {
                Console.WriteLine("Maske Verildi.");
            }else { Console.WriteLine("Maske Verilemez  "); }
        }
    }
}
