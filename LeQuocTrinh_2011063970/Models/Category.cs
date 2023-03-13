using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeQuocTrinh_2011063970.Models
{
    public class Category    // byte 0-255
    {
            public byte Id { get; set; }
            [Required]
            [StringLength(255)]
            public string Name { get; set; }
    }
}