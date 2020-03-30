using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Education
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string Univaersity_Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
        [Required]
        [StringLength(20)]
        public string Date { get; set; }

    }
}