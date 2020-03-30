using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Images
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string Source { get; set; }
    }
}