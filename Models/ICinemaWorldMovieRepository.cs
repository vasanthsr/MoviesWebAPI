using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    interface ICinemaWorldMovieRepository
    {
        //Interface - Signature of methods
        IEnumerable<Movie> GetAll();
        Movie Get(int id);
    }
}
