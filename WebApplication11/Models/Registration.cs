using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }
}
