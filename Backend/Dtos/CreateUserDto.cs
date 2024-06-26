﻿using System.ComponentModel.DataAnnotations;

namespace Gerenciador.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password")]
        public string Repassword { get; set; }

        public CreateUserDto()
        {
            
        }

        public CreateUserDto(string username, string email, string password, string repassword)
        {
            Username = username;
            Email = email;
            Password = password;
            Repassword = repassword;
        }
    }
}
