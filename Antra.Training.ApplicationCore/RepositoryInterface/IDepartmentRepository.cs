﻿using Antra.Training.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.ApplicationCore.RepositoryInterface
{
    public interface IDepartmentRepository:IRepository<Department>
    {
        IEnumerable<Department> GetByLocation(string location);
    }
}
