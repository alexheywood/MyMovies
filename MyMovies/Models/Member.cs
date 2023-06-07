using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        [Display(Name = "Is this user an admin?")]
        public bool isAdmin { get; set; }
    }
}