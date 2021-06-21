using LoanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Repository
{
    public class EducationLoanRepo : IEducationLoanRepo
    {
        private List<EducationLoan> eduloans;
        public EducationLoanRepo()
        {
            eduloans = new List<EducationLoan>();
        }
        public void ApplyEducationLoan(EducationLoan educationLoan)
        {
            try
            {
                this.eduloans.Add(educationLoan);
                
            }
            catch(Exception)
            {
                throw;
                

            }

        }

        public IEnumerable<EducationLoan> GetEducationLoanDetails(string custid)
        {
            try
            {
                return this.eduloans.Where(edu => edu.CustomerId == custid);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
