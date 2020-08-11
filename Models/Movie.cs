using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Namespace to Movie
/// </summary>
namespace Blockbuster.Models
{
    /// <summary>
    /// Model to Movie
    /// </summary>
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        // data details 
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2")]
        public decimal Price { get; set; }
    }
}