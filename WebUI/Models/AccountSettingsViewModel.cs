using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class AccountSettingsViewModel
    {
        public string Username { get; set; }

        public string FirstName { get; set; }
        public string NewFirstName { get; set; }

        public string LastName { get; set; }
        public string NewLastName { get; set; }

        public string Email { get; set; }
        public string NewEmail { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}