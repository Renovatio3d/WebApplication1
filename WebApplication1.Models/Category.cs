using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebApplication1.Models
{
    class Category
    {
        [Key]
        public int ID { get; set; }

       [Required]
       [Display(Name="Display Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Display Order")]
        public int displayOrder { get; set; }
    }
}
