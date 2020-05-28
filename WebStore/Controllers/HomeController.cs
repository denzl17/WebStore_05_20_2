﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Surname = "Иванов",
                FirstName = "Иван",
                Patronymic = "Иванович",
                Age = 50,
                Office = "Street1",
                Hobby = "Baseball",
                Birthdate = DateTime.Today.AddYears(-50).AddDays(-45)
            },
            new Employee
            {
                Id = 2,
                Surname = "Петров",
                FirstName = "Пётр",
                Patronymic = "Петрович",
                Age = 25,
                Office = "Street2",
                Hobby = "Dancing",
                Birthdate = DateTime.Today.AddYears(-25).AddDays(56)
            },
            new Employee
            {
                Id = 3,
                Surname = "Сидоров",
                FirstName = "Сидор",
                Patronymic = "Сидорович",
                Age = 30,
                Office = "Street3",
                Hobby = "Bicycle",
                Birthdate = DateTime.Today.AddYears(-30).AddDays(12)
            },
        };


        public IActionResult Index()
        {
            //ViewBag.Title = "Hello World";
            ViewData["Title"] = "Hello World!";

            return View(__Employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employee = __Employees.FirstOrDefault(e => e.Id == id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }

        public IActionResult AnotherAction()
        {
            return Content("Another action result");
        }
    }
}