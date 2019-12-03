using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name{ get; set; }
        public string Author { get; set; }

        [DataType(DataType.Currency)]
        [Range(0.01,100.00, ErrorMessage="Price {0} must be between {1} and {2}")]  
        public double Price { get; set; }

    }
}
