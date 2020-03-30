using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Statics
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Organisation { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(15)]
        public string Date { get; set; }
    }
}