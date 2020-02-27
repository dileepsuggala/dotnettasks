﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mvcwebappdemo.Models
{
    public class book
    {
        [Required]
        [Key]
        public int Bid { get; set; }
        [Display(Name ="Book Title")]
        [Required]
        public string Btitle { get; set; }

        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [Display(Name ="Author Name")]
        [Required]
        public string Authorname { get; set; }
        [Required]
        public string Publisher { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name ="Release Date")]
        public DateTime Releasedate { get; set; }

    }
}
