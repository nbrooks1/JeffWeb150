using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShowsSite.Models
{
    public class PostShowCreate
    {
        [Required]
        public string Title { get; set; }
        [MaxLength(30)]
        public string Network { get; set; }
    }
}
