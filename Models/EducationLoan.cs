using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Models
{
    public class EducationLoan
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string LoanType { get; set; }
        public int LoanAmount { get; set; }
        public DateTime LoanApplyDate { get; set; }
        public DateTime LoanIssueDate { get; set; }
        public int RateOfInsterest { get; set; }
        public int Duration { get; set; }
        public int CourseFee { get; set; }
        public string Course { get; set; }
        public string FatherName { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherTotalExperience{get;set;}
        public string FatherExperienceCurrentCompany { get; set; }
        public string RationCardNumber { get; set; }
        public int AnnualIncome { get; set; }
        }
}
