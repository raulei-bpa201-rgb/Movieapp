using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public abstract class Media
    {
        protected string title;

        protected int year;

        public string Title { get { return title; } set { if (value.Trim() != null) title = value; else Console.WriteLine("try again it should be non-empty"); } } 

        public int Year { get { return year; } set { if (value >= 0) year = value; else Console.WriteLine("year must be non negative"); } }

        public Media(string title, int year)
        {
            this.Title = title;
            this.Year = year;
        }

        public abstract void DisplayInfo();
    }
}
