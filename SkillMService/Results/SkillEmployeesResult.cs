﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SkillMService.Models;


namespace SkillMService.Results
{
    public class SkillEmployeesResult: Skill
    {
      
        public List<Employee> JrEmployees { get; set; }
        public List<Employee> IntEmployees { get; set; }
        public List<Employee> SrEmployees { get; set; }
        public List<Employee> LdEmployees { get; set; }
    }
}