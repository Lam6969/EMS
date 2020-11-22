﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagementSystem.Models
{
    //User
    public class UserMetadata
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z ]+", ErrorMessage = "Name should contain alphabets only.")]
        public string name { get; set; }
        [Required]
        [RegularExpression(@"(\+?6?01)[0-46-9]-*[0-9]{7,8}", ErrorMessage = "Invalid format.")]
        public string contact_no { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Username should contain atleast 5 alphabets.")]
        [MaxLength(15, ErrorMessage = "Username cannot have more than 15 alphabets.")]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("password", ErrorMessage = "Password not matched")]
        public string confirmPassword { get; set; }
        public string role { get; set; }
        public Nullable<bool> organizer { get; set; }
        public bool status { get; set; }
        public string recoveryCode { get; set; }
        public string activationCode { get; set; }
    }

    [MetadataType(typeof(UserMetadata))]

    public partial class User { }


}