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


    }
}