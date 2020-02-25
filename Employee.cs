using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstEmpTask
{
    class Employee
    {   
        [Key]
        public int Eid { get; set; }

        public String Ename { get; set; }

        public String Edesig { get; set; }

        public Double Esal { get; set; }

        public int Did { get; set; }
        public Department dept { get; set; }
    }
}
