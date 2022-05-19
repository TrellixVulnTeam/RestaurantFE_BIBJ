﻿using System.ComponentModel.DataAnnotations;

namespace Restaurant.Business.Requests
{
    public class AuthorizeRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
