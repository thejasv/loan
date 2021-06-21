using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Services
{
    public interface IEducationLoanService
    {
        public void ApplyEducationLoan(EducationLoan educationLoan);
        public IEnumerable<EducationLoan> GetAllEducationLoanDetails(string custid);
    }
}
