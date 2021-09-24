using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManager.Models;

namespace EmployeeManager.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext (DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManager.Models.Employees> Employees { get; set; }
    }
}
