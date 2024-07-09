﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyCalorie.User.CrossCutting.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        
        public string? Email { get; set; }
        
        public string? PasswordHash { get; set; }
    }
}
