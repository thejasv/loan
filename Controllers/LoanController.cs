using LoanService.Models;
using LoanService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private IEducationLoanService educationLoanService;
        private IPersonalLoanService personalLoanService;
        public LoanController(IEducationLoanService _educationLoanService, IPersonalLoanService _personalLoanService)
        {
            this.educationLoanService = _educationLoanService;
            this.personalLoanService = _personalLoanService;
        }
        [HttpPost("ApplyEducationLoan")]
        public IActionResult ApplyEducationLoan(EducationLoan educationLoan)
        {
            try
            {
                this.educationLoanService.ApplyEducationLoan(educationLoan);
                return  Ok();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest(500);
            }
        }
        [HttpPost("ApplyPersonalLoan")]
        public IActionResult ApplyPersonalLoan(PersonalLoan personalLoan)
        {
            try
            {
                this.personalLoanService.ApplyPersonalLoan(personalLoan);
                return Ok();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest();
            }
        }
        [HttpGet("GetEducationLoanDetails")]
        public IActionResult GetEducationLoanDetails(string custid)
        {
            try
            {
                IEnumerable<EducationLoan> eduloan = this.educationLoanService.GetAllEducationLoanDetails(custid);
                if (eduloan.Any())
                    return Ok(eduloan);
                else
                    return NotFound("no  data  of education loan");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest(" something  went wrong");
            }
        }
        [HttpGet("GetPersonalLoanDetails")]
        public IActionResult GetPersonalLoanDetails(string custid)
        {
            try
            {
                IEnumerable<PersonalLoan> personalLoans = this.personalLoanService.GetAllPersonalLoans(custid);
                if (personalLoans.Any())
                    return Ok(personalLoans);
                else
                    return NotFound("no data of personal loan");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return BadRequest("Something went wrong");
            }
        }
        
    }
}
