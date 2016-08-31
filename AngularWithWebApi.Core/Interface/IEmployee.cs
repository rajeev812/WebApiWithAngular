using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularWithWebApi.Core.Interface
{
  public  interface IEmployee
    {
        void Save(Employee e);
        void Edit(Employee e);
        List<Employee> GetAllEmployee();
        bool Delete(int id);
        List<Employee> GetEmployeeById(int id);

    }
}
