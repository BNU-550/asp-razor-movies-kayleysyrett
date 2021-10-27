using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Razor_Movies.Models
{
    public enum Genres
    {
        Comedy, Drama, Horror, Romance
    }
    
    /// <summary>
    /// 
    /// </summary>
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [StringLength(60), Required]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genres genre { get; set; }

        [Range(5.99, 12.99)]
        public decimal Price { get; set; }
    }
}
