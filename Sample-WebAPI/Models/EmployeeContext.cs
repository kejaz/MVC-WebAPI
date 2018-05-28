using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sample_WebAPI.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> employee { get; set; }
    }
}