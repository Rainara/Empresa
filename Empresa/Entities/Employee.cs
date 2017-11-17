using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empresa.Entities
{
    public class Employee
    {
        
            public int Id { get; set; }


            public String Name { get; set; }


            public String Position { get; set; }


            public decimal Salary { get; set; }


            public String department { get; set; }
        
    }
}