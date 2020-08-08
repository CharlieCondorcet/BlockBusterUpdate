using System;
using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}