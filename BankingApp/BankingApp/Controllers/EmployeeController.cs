using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingApp.Models;

namespace BankingApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult demo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Aakash",
                Gender = "Male",
                City = "London"
            };
            return View(employee);
        }
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
          /*  Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Aakash",
                Gender = "Male",
                City = "London"
            };
            */
            return View(employee);
        }
    }
}