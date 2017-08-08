﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credit { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public Department department { get; set; }
    }
}
