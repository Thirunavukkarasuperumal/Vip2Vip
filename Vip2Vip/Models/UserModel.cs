using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vip2Vip.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Year { get; set; }
        public string Position { get; set; }
        public DateTime? Dob { get; set; }
    }
}
