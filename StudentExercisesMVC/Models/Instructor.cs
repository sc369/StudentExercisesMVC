﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Slackhandle { get; set; }

        public string Specialty { get; set; }

        public Cohort Cohort { get; set; }
       
    }
}
