﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View("Index",employees);
        }
    }
}
