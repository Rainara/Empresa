using Empresa.DataAccess;
using Empresa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext employeeContext;

        // GET: Employee
        public EmployeeController(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }
        public ActionResult EmployeeForm()
        {
            return View();
        }

        public ActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeContext.AddNew(employee);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("EmployeeForm", employee);
            }

        }
    }
}
