using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antra.Training.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Antra.Training.Infrastructure.Data
{
    public class TrainingDbContext:DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
