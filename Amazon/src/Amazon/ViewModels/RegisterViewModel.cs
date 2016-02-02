using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "User name")]
        [Required(ErrorMessage = "Enter a user name")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter a password")]
        public string Password { get; set; }
    }

    
}