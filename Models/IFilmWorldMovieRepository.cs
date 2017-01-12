﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    //Interface - Signature of methods
    interface IFilmWorldMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie Get(int id);
    }
}
