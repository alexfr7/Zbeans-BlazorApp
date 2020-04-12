using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ZBeans_BlazorApp.Models
{
    public class Manager
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string DefaultPassword { get; set; }
    }
}
