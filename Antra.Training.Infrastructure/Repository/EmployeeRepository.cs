using Antra.Training.ApplicationCore.Entities;
using Antra.Training.ApplicationCore.RepositoryInterface;
using Antra.Training.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.Infrastructure.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(TrainingDbContext tb) : base(tb)
        {
        }
    }
}
