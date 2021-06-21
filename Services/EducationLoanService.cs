using LoanService.Models;
using LoanService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Services
{
    public class EducationLoanService : IEducationLoanService
    {
        IEducationLoanRepo educationLoanRepo;
        public EducationLoanService(IEducationLoanRepo _educationLoanRepo)
        {
            this.educationLoanRepo = _educationLoanRepo;
        }
        public void ApplyEducationLoan(EducationLoan educationLoan)
        {
            try
            {
                this.educationLoanRepo.ApplyEducationLoan(educationLoan);
            }
            catch(Exception)
            {
                throw;
            }
                 
        }

        public IEnumerable<EducationLoan> GetAllEducationLoanDetails(string custid)
        {
            try
            {
                return this.educationLoanRepo.GetEducationLoanDetails(custid);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
