﻿using System.ComponentModel.DataAnnotations;

namespace demos.Models.BindingModels.Users
{
   public class EditUserBm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
