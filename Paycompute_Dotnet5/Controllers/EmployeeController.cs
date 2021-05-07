﻿using Microsoft.AspNetCore.Mvc;
using Paycompute_Dotnet5.Models;
using Paycompute_Dotnet5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute_Dotnet5.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            var employees = _employeeService.GetAll().Select(employee => new EmployeeIndexViewModel
            {
                Id = employee.Id,
                EmployeeNo = employee.EmployeeNo,
                FullName = employee.FullName,
                Gender = employee.Gender,
                ImageUrl = employee.ImageUrl,
                DateJoined = employee.DateJoined,
                Designation = employee.Designation,
                City = employee.City
            }).ToList();
            return View(employees);
        }
    }
}
