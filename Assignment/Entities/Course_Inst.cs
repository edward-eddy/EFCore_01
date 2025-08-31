using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    // 1. By Convention [Default Behaviour]
    [PrimaryKey(nameof(Inst_ID), nameof(Course_ID))]
    internal class Course_Inst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int Evaluate { get; set; }
    }
}
