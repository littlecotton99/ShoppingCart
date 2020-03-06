using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ShoppingCart.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MinLength(3, ErrorMessage = "Mini length is 2")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name should be letters only")]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public int Sorting { get; set; }

    }
}
