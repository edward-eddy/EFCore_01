using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    // 2. Data Annotation
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Ins_Id { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
