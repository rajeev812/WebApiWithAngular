using AngularWithWebApi.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularWithWebApi.Infrastructure
{
    public class EmployeeContext :DbContext
    {
       public EmployeeContext() : base("con") { }

        public DbSet<Employee> Employees { get; set; }
    }
        
}
