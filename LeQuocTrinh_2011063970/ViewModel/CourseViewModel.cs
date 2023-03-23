﻿using LeQuocTrinh_2011063970.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeQuocTrinh_2011063970.ViewModel
{
    public class CourseViewModel
    {
        [Required]
        public string Place { set; get; }

        [Required]
        [FutureDate]
        public string Date { set; get; }

        [Required]
        [ValidTime]
        public string Time { set; get; }

        [Required]
        public byte Category { set; get; }
        public IEnumerable<Category> Categories { set; get; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}