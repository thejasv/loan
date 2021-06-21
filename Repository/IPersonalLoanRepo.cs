using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Repository
{
    public interface IPersonalLoanRepo
    {
        public void ApplyPersonalLoan(PersonalLoan personalLoan);
        public IEnumerable<PersonalLoan> GetPersonalLoanDetails(string custid);
    }
}
