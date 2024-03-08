using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.ApplicationCore.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Department Name is required")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Location is required")]
        public string Location { get; set; }
    }
}
