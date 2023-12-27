﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DatingApp;

public class AppUser
{
    public int Id { get; set; }
    public string UserName {get; set;}
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}
