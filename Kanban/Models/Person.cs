﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Issue> Issues { get; set; } = new List<Issue>();
    }
}
