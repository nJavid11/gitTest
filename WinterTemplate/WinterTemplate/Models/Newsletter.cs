﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterTemplate.Models
{
    public class Newsletter
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

    }
}
