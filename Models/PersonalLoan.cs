using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Models
{
    public class PersonalLoan
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string LoanType { get; set; }
        public int LoanAmount { get; set; }
        public DateTime LoanApplyDate { get; set; }
        public DateTime LoanIssueDate { get; set; }
        public int RateOfInterest { get; set; }
        public int Duration { get; set; }
        public string CompanyName { get; set; }
        public int AnnualIncome { get; set; }
        public string Designation { get; set; }
        public int TotalExperience{ get;set; }
        public int ExperienceinCurrentCompany { get; set; }
    }
}
