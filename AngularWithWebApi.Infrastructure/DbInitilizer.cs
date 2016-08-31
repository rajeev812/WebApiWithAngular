using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace AngularWithWebApi.Infrastructure
{
    public class DbInitilizer : CreateDatabaseIfNotExists<EmployeeContext>
    {
        //public override void InitializeDatabase(EmployeeContext context)
        //{
        //    base.InitializeDatabase(context);
        //}
        protected override void Seed(EmployeeContext context)
        {
            base.Seed(context);
        }
    }
}
