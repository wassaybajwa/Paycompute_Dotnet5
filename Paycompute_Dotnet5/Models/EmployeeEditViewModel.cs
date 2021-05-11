using Microsoft.AspNetCore.Http;
using Paycompute_Dotnet5.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute_Dotnet5.Models
{
    public class EmployeeEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Number is required."), RegularExpression(@"^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNo { get; set; }
        [Required(ErrorMessage = ("First Name is required")), StringLength(50, MinimumLength = (2)), RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [StringLength(50), MinLength(2)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = ("Last Name is required")), StringLength(50, MinimumLength = (2)), RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Photo")]
        public IFormFile ImageUrl { get; set; }
        [DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }
        [Display(Name = "Phone No.")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Job role is Required"), StringLength(100)]
        public string Designation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(50), Display(Name = "Social Insurance Number")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{3}$")] /*(@"^[A-CEGHJ-PR-TW-Z]{1}[A-CEGHJ-NPR-TW-Z]{1}[0-9]{6}[A-D\s]$")*/ /*My way [0-9]{3}[\s]{1}[0-9]{3}[\s]{1}[0-9]{3}*/
        public string SIN { get; set; }
        [Display(Name = "Payment Method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Student Loan")]
        public StudentLoan StudentLoan { get; set; }
        [Display(Name = "Union Member")]
        public UnionMember UnionMember { get; set; }
        [Required, StringLength(150)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string City { get; set; }
        [Required, StringLength(50), Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
    }
}
