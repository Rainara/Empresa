using Empresa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empresa.DataAccess
{
    public class EmployeeContext
    {
        private EmpresaContext context;

        public EmployeeContext(EmpresaContext context)
        {
            this.context = context;
        }

        public void AddNew(Employee employee)
        {
            context.employees.Add(employee);
            context.SaveChanges();
        }
        public IList<Employee> ListData()
        {
            return context.employees.ToList();
        }
    }
}