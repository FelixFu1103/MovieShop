using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class UserLoginRequestModel
    {
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}