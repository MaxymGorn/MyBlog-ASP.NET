using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Portfolio
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}