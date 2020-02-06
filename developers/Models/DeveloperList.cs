using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace developers.Models
{
    public class DeveloperList
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Technology { get; set; }
        public string GithubLink { get; set; }
       
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        //public int Experience { get; set; }

        //public int Salary { get; set; }

        public List<TechModel> Tech { get; set; }
    }
}
