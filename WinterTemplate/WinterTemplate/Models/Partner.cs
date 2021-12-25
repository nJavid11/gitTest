using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WinterTemplate.Models
{
    public class Partner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Image { get; set; }
    }
}
