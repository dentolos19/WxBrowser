﻿using System.ComponentModel.DataAnnotations;

namespace CommonToolsOnline.Forms
{

    public class PasswordGeneratorForm
    {

        [Required(ErrorMessage = "You must enter a password length.")]
        [Range(8, 64, ErrorMessage = "The length must be between 8 to 64 characters long.")]
        public int PasswordLength { get; set; } = 16;

    }

}