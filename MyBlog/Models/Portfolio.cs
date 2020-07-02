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
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Text { get; set; }
 

    }
}