﻿using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll be able to attend or not")]
        public bool? WillAttend { get; set; }
    }
}
