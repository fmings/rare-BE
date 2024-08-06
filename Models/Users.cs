﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rare_BE.Models;

public class Users
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string ProfileImageUrl { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Active { get; set; }
}
