using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace developers.Models
{
    public class TechModel
    {
        [Key]
        public int item_id { get; set; }
        public string item_text { get; set; }
    }
}
