using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Repository
{
    public interface IEducationLoanRepo
    {
        public void ApplyEducationLoan(EducationLoan educationLoan);
        public IEnumerable<EducationLoan> GetEducationLoanDetails(string custid);

    }
}
