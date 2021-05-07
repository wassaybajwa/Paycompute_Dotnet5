﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute_Dotnet5.Models
{
    public class EmployeeIndexViewModel
    {
        public int Id { get; set; }
       // [Required]
        public string EmployeeNo { get; set; }
       // [Required, MaxLength(50)]
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateJoined { get; set; }
        public string Designation { get; set; }
        public string City { get; set; }
    }
}
