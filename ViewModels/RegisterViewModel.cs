using System.ComponentModel.DataAnnotations;
using aspnetcoreNewWeb.Utilites;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action:"IsEmailInUse",controller:"Account")]
        [ValidEmailDomain(allowDomain: "aboulmagd.com", ErrorMessage="Email domain must be aboulmagd.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}