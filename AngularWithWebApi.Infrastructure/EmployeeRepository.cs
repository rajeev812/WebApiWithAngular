using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularWithWebApi.Core;
using AngularWithWebApi.Core.Interface;
namespace AngularWithWebApi.Infrastructure
{
   public class EmployeeRepository :IEmployee
    {
       EmployeeContext Context = new EmployeeContext();
        public void Save(Employee e)
        {
            //throw new NotImplementedException();
            Context.Employees.Add(e);
            Context.SaveChanges();
        }

        public void Edit(Employee e)
        {
            Context.Entry(e).State = System.Data.Entity.EntityState.Modified;
        }

        public List<Employee> GetAllEmployee()
        {
            return Context.Employees.ToList();
        }

        public bool Delete(int id)
        {
            try
            {
                var Record = Context.Employees.Find(id);
                Context.Employees.Remove(Record);
                Context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Employee> GetEmployeeById(int id)
        {
            var result = Context.Employees.Where(x => x.Id == id).ToList();
            return result;
        }
    }
}
