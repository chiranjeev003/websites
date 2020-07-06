using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genres
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
    }
}