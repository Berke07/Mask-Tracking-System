using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PTTManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PTTManager(IApplicantService applicantService) 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Citizen citizen)
        {
            
            if (_applicantService.ChechkCitizen(citizen)) 
            {
                Console.WriteLine(citizen.Name + "için maske verildi.");
            }
            else
            {
                Console.WriteLine(citizen.Name + "için maske verilemedi.");
            }
        }
    }
}
