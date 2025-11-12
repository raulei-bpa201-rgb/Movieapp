using MovieApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public  class Movie:Media,IPlayable
    {
        private string genre;

        private bool watched;

        public int Genre 
        {
            set
            {
                switch (value)
                {
                    case 1:
                        genre = "Action";
                        break;
                    case 2:
                        genre = "Comedy";
                        break;
                    case 3:
                        genre = "Drama";
                        break;
                    case 4:
                        genre = "Horror";
                        break;
                    case 5:
                        genre = "SciFi";
                        break;
                    case 6:
                        genre = "Documentary";
                        break;
                    default:
                        Console.WriteLine("there is no such genre of movie");
                        break;
                }
            }
        }

        public Movie(bool watched, int genre ,string title,int year) :base(title,year)
        {
            Genre = genre;
            this.watched = watched;
            Genre = genre;
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
                watched = true;
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
