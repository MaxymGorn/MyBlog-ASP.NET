using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class WHAT_CAN__I_DO
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(200)]
        public string Text { get; set; }
        [Required]
        [StringLength(100)]
        public string Class { get; set; }
    }
}