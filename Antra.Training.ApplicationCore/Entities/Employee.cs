using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Antra.Training.ApplicationCore.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Column(TypeName="varchar(20)")]
        public string Name { get; set; }
        
        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
        [EmailAddress(ErrorMessage ="Invalid email")]
        [Column(TypeName ="varchar(250)")]
        public string EmailId { get; set; }

        public Department Department { get; set; }
    }
}
