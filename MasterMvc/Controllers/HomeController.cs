using MasterMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FirstName = "Amardeep Kumar";
            ViewBag.LastName = "Amar";
            ViewBag.Address = "Gaya Mau";

            return View();
        }

        public ActionResult GetEmployee()
        {
            List<Employee> employees = new List<Employee>()

            {

                     new Employee()
                     {
                      EmployeeID = 1,
                EmployeeName = "Amardeep Kumar Amar",
                Addess = "Patna",
                DateOfJoining = System.DateTime.Now,
                MartialStatus = 1,
                IsEligibleForLoan = true,
                Salary = 25000.00m,
                CreatedBy = "Admin",
                CreatedDate = System.DateTime.Now

                },
                     new Employee()
                     {
                        EmployeeID = 2,
                        EmployeeName = "Sandeep Kumar Sharma",
                        Addess = "Gadhwa",
                        DateOfJoining = System.DateTime.Now,
                        MartialStatus = 1,
                        IsEligibleForLoan = true,
                        Salary = 45000.00m,
                        CreatedBy = "Admin",
                        CreatedDate = System.DateTime.Now

                },
                     new Employee()
                     {
                        EmployeeID = 3,
                        EmployeeName = "Ramesh Kumar jha",
                        Addess = "Gaya",
                        DateOfJoining = System.DateTime.Now,
                        MartialStatus = 1,
                        IsEligibleForLoan = true,
                        Salary = 15000.00m,
                        CreatedBy = "Admin",
                        CreatedDate = System.DateTime.Now

                },
                     new Employee()
                     {
                        EmployeeID = 4,
                        EmployeeName = "Mitlash Kumar Chorasia",
                        Addess = "Patna",
                        DateOfJoining = System.DateTime.Now,
                        MartialStatus = 1,
                        IsEligibleForLoan = true,
                        Salary = 35000.00m,
                        CreatedBy = "Admin",
                        CreatedDate = System.DateTime.Now

                },
                     new Employee()
                     {
                        EmployeeID = 5,
                        EmployeeName = "Rani Kumari Chorasia",
                        Addess = "Patna",
                        DateOfJoining = System.DateTime.Now,
                        MartialStatus = 1,
                        IsEligibleForLoan = true,
                        Salary = 35000.00m,
                        CreatedBy = "Admin",
                        CreatedDate = System.DateTime.Now

                },
                     new Employee()
                     {
                        EmployeeID = 6,
                        EmployeeName = "Lakchamaan Kumar Chorasia",
                        Addess = "Patna",
                        DateOfJoining = System.DateTime.Now,
                        MartialStatus = 1,
                        IsEligibleForLoan = true,
                        Salary = 35000.00m,
                        CreatedBy = "Admin",
                        CreatedDate = System.DateTime.Now

                }


           };
            ViewBag.Employees = employees;
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}