using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Movie
    {
        public string title;
        public string director;
        public string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            this.rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "PG-13")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
