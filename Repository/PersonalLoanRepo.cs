using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Repository
{
    public class PersonalLoanRepo : IPersonalLoanRepo
    {
        private List<PersonalLoan> personalLoans;
        public PersonalLoanRepo()
        {
            personalLoans = new List<PersonalLoan>();
        }
        public void ApplyPersonalLoan(PersonalLoan personalLoan)
        {
            try
            {
                this.personalLoans.Add(personalLoan);
                
            }
            catch(Exception)
            {
                throw;
            }
        }

        public IEnumerable<PersonalLoan> GetPersonalLoanDetails(string custid)
        {
            try
            {
                return this.personalLoans.Where(per => per.CustomerId == custid);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
