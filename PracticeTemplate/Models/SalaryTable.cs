﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeTemplate.Models
{
    public class SalaryTable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Position { get; set; }
        public string Office { get; set; }
        public int Age { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
