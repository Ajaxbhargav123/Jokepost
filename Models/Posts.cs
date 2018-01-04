using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FunTour.Models;
using Microsoft.AspNet.Identity;
using System.Security.Principal;
using System.Web.Mvc;

namespace FunTour.Models
{
    public class Posts
    {
        public int Id { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(300)]
        public string Post { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        [MaxLength(22)]
        public string title { get; set; }

    }
}