using Empresa.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Empresa.DataAccess
{
    public class EmpresaContext: DbContext 
    {
        public DbSet<Employee> employees { get; set; }
    }
}