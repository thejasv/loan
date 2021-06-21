using LoanService.Models;
using LoanService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Services
{
    public class PersonalLoanService : IPersonalLoanService
    {
        private IPersonalLoanRepo personalLoanRepo;
        public PersonalLoanService(IPersonalLoanRepo _personalLoanRepo)
        {
            this.personalLoanRepo = _personalLoanRepo;
        }
        public void ApplyPersonalLoan(PersonalLoan personalLoan)
        {
            try
            {
                this.personalLoanRepo.ApplyPersonalLoan(personalLoan);
            }
            catch(Exception)
            {
                throw;
            }
                
        }

        public IEnumerable<PersonalLoan> GetAllPersonalLoans(string custid)
        {
            try
            {
                return this.personalLoanRepo.GetPersonalLoanDetails(custid);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
