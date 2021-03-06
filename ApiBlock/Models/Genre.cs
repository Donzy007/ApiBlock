﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApiBlock.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}