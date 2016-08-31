using AngularWithWebApi.Core;
using AngularWithWebApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWithWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeRepository Db = new EmployeeRepository();
        // GET: api/Employee
        public List<Employee> GetAllEmployee()
        {
            return Db.GetAllEmployee();
        }

        // GET: api/Employee/5
        public List<Employee> GetEmployeeById(int id)
        {
            return Db.GetEmployeeById(id);
        }

        // POST: api/Employee
        public void PostEmployeSave(Employee ObjEmp)
        {
            Db.Save(ObjEmp);
        }

        // PUT: api/Employee/5
        [HttpPost]
        [Route("api/Employee/PostEmployeeEdit/0")]
        public void PostEmployeeEdit(Employee ObjEmp)
        {
            Db.Edit(ObjEmp);
        }

        // DELETE: api/Employee/5
        public bool DeleteEmployee(int id)
        {
            return Db.Delete(id);
        }
    }
}
