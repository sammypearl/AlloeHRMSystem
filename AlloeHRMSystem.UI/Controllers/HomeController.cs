﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlloeHRMSystem.UI.Models;
using AlloeHRMSystem.Persistence.IServices;
using AlloeHRMSystem.UI.ViewModels;
using AlloeHRMSystem.Domain.Entities;

namespace AlloeHRMSystem.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(ILogger<HomeController> logger, IEmployeeRepository employeeRepository)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
        }

        //public async Task<IActionResult> Index(string searchString)
        //{
        //    var movies = from m in _context.Movie
        //                 select m;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        movies = movies.Where(s => s.Title.Contains(searchString));
        //    }
        //    return View(await movies.ToListAsync());
        //}

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult HomeIndex(string searchString)
        { 
           var employeeList = _employeeRepository.GetAllEmployee();
            if (!String.IsNullOrEmpty(searchString))
            {
                employeeList = employeeList.Where(t => t.Firstname.Contains(searchString)
                    || t.Lastname.Contains(searchString)
                    || t.City.Contains(searchString)
                    || t.Country.Contains(searchString)
                    || t.Phone.Contains(searchString));
            }
                var listingResult = employeeList
            
                   .Select(e => new Employee
                   {
                       EmployeeId = e.EmployeeId,
                       Firstname = e.Firstname,
                       Lastname = e.Lastname,
                       Department = e.Department,
                       JobTitle = e.JobTitle,
                       Rank = e.Rank,
                       Phone = e.Phone,
                       Email = e.Email,
                       City = e.City,
                       Country = e.Country,
                       Gender = e.Gender,
                   }).ToList();
            
            return View(listingResult);
        }

    }
}
