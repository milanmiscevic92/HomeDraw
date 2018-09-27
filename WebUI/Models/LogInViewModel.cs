using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Please enter your username.")]
        public string Username { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }
    }
}