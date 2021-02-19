using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab21_MovieRegistration.Models
{

    public enum Genre
    {
        Comedy, 
        Horror, 
        Romance, 
        Kids, 
        Action, 
        Indie,
        Adventure, 
        Drama,
        Animation,
        Other,
    }
    public class Movie
    {
        [Key]
        [Required(ErrorMessage ="Please Enter a movie ID number!")]
        public int ID { get; set; }
        [Required(ErrorMessage ="Please Enter your Movie Name")]
        [MaxLength(50, ErrorMessage ="Your movie title cannot be longer than 50 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="You must list your movie Genre")]
        public Genre Genre { get; set; }
        
        public int Year { get; set; }
        [Required(ErrorMessage ="You must list at least one actor.")]
        public List<string> Actors { get; set; } = new List<string>();
        [Required(ErrorMessage = "You must list at least one director.")]
        public List<string> Directors { get; set; } = new List<string>();
    }
}
