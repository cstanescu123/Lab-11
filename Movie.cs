using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    internal class Movie
    {
        public Movie()
        {
        }

        public Movie(string title, string category)
        {
            Category = category;
            Title = title;
        }
        public string Category { get; set; }
        public string Title { get; set; }

    }


}
