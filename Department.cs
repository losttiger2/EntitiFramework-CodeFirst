using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstEmpTask
{
    class Department
    {
        [Key]
        public int Did { get; set; }

        [Required]
        public String Dname { get; set; }

        [Required]
        public String Dlocation { get; set; }
    }
}
