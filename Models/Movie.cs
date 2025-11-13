using MovieApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Movie:Media,IPlayable
    {

        private bool watched;


        private Genre genre;

        public Genre GenreType
        {
            get => genre;
            set => genre = value;
        }

        public Movie(string title, int year,bool watched, Genre genre) :base(title,year)
        {
            GenreType = genre;
            this.watched = watched;
        }

        public void MarkAsWatched()
        {
            if (!watched)
            {
                watched = true;
                Console.WriteLine("movie staus updated");
            }
            else
            {
                Console.WriteLine("movie is already marked as watched");
            }
        }

        public void MarkAsUnwatched()
        {
            if (watched)
            {
                watched = false;
                Console.WriteLine("movie staus updated");
            }
            else
            {
                Console.WriteLine("movie is already marked as unwatched");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{title} {year} {genre} {watched}");
        }

        public void Start()
        {
            Console.WriteLine($"{title} movie started");
        }

        public void Stop()
        {
            Console.WriteLine($"{title} movie stoped");
        }
    }
}
