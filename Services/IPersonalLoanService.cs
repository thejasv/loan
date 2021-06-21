using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Services
{
    public interface IPersonalLoanService
    {
        public void ApplyPersonalLoan(PersonalLoan personalLoan);
        public IEnumerable<PersonalLoan> GetAllPersonalLoans(string custid);
    }
}
