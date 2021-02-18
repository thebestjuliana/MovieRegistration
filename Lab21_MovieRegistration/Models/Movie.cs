using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public string[] Actors { get; set; } = new string[4];
        public string[] Directors { get; set; } = new string[3];
    }
}
