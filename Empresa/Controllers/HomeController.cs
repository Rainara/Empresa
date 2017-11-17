using Empresa.DataAccess;
using Empresa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empresa.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext employeeContext;

        // GET: Home

        public HomeController(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }


        public ActionResult Index(String search)
        {
            EmpresaContext db = new EmpresaContext();
            IList<Employee> employees;
            if (!string.IsNullOrEmpty(search))
            {
                employees = db.employees.Where(x => x.Name.StartsWith(search)).ToList();
                return View(employees);
            }
            else
            {
                return View(db.employees.ToList());
            }

        }

        public JsonResult GetEmployees(string search)
        {
            EmpresaContext db = new EmpresaContext();
            IList<Employee> employees = db.employees.Where(x => x.Name.Contains(search)).Select(x => new Employee
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return new JsonResult { Data = employees, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


    }
}