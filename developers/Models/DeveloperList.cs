﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace developers.Models
{
    public class DeveloperList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Technology { get; set; }
        public int Experience { get; set; }
        public string GithubLink { get; set; }
    }
}
