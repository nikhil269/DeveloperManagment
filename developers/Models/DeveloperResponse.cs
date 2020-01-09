using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace developers.Models
{
    public class DeveloperResponse
    {
        public int Count { get; set; }

        public List<DeveloperList> DeveloperList { get; set; }
    }
}
