using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Expirience
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string DateStart { get; set; }
        [Required]
        [StringLength(20)]
        public string DateEnd { get; set; }
        [Required]
        [StringLength(500)]
        public string Text { get; set; }
        [Required]
        [StringLength(50)]
        public string Company { get; set; }
    }
}