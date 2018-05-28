using Sample_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample_WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeContext employeeContext = new EmployeeContext();
        // GET: api/Employee
        public IEnumerable<Employee> Get()
        {
            return employeeContext.employee.ToList();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Employee/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }   

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
