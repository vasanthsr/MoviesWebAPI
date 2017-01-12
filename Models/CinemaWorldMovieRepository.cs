using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class CinemaWorldMovieRepository : ICinemaWorldMovieRepository
    {
        private List<Movie> lstMovies = new List<Movie>();
        private int _nextId = 1;
        //Hard coded data. Most of the data retreived from the sample API that was provided by webjet test
        public CinemaWorldMovieRepository()
        {
            Add(new Movie { Title = "A New Hope", Year = "1977", Category = "Fiction", Poster = "http://ia.media-imdb.com/images/M/MV5BOTIyMDY2NGQtOGJjNi00OTk4LWFhMDgtYmE3M2NiYzM0YTVmXkEyXkFqcGdeQXVyNTU1NTcwOTk@._V1_SX300.jpg"
                ,Language="English", Director="James", Rating="PG-13", Released="04-Jan-1977", Runtime="138 mins", Price = 5.4M, Plot= "30 years after the defeat of Darth Vader and the Empire,Rey, a scavenger from the planet Jakku, finds a BB - 8 droid that knows the whereabouts of the long lost Luke Skywalker.Rey, as well as a rogue stormtrooper and two smugglers, are thrown into the middle of a battle between the Resistance and the daunting legions of the First Order." });
            Add(new Movie { Title = "The Empire Strikes Back", Year = "1980", Category = "Fiction", Poster = "http://ia.media-imdb.com/images/M/MV5BMjE2MzQwMTgxN15BMl5BanBnXkFtZTcwMDQzNjk2OQ@@._V1_SX300.jpg",                
                Language = "English",
                Director = "Packer",
                Rating = "PG-15",
                Released = "16-Mar-1980",
                Runtime = "145 mins",
                Price = 2.4M,
                Plot = "After the rebels have been brutally overpowered by the Empire on their newly established base, Luke Skywalker takes advanced Jedi training with Master Yoda, while his friends are pursued by Darth Vader as part of his plan to capture Luke"
            });
            Add(new Movie { Title = "Return of the Jedi", Year = "1983", Category = "Fiction", Poster = "http://ia.media-imdb.com/images/M/MV5BMTQ0MzI1NjYwOF5BMl5BanBnXkFtZTgwODU3NDU2MTE@._V1._CR93,97,1209,1861_SX89_AL_.jpg_V1_SX300.jpg", Price = 6.4M,
                Language = "English",
                Director = "Campbell",
                Rating = "PG-15",
                Released = "16-Mar-1980",
                Runtime = "145 mins", Plot= "After rescuing Han Solo from the palace of Jabba the Hutt, the rebels attempt to destroy the second Death Star, while Luke struggles to make Vader return from the dark side of the Force"
            });
            Add(new Movie { Title = "The Force Awakens", Year = "2015", Category = "Fiction", Poster = "http://ia.media-imdb.com/images/M/MV5BOTAzODEzNDAzMl5BMl5BanBnXkFtZTgwMDU1MTgzNzE@._V1_SX300.jpg", Price = 1.4M,
                Language = "English",
                Director = "Sally",
                Rating = "PG-15",
                Released = "23-Mar-2015",
                Runtime = "145 mins", Plot= "Three decades after the defeat of the Galactic Empire, a new threat arises. The First Order attempts to rule the galaxy and only a ragtag group of heroes can stop them, along with the help of the Resistance"
            });
            Add(new Movie { Title = "Attack of the Clones", Year = "2002", Category = "Fiction", Poster = "http://ia.media-imdb.com/images/M/MV5BMTY5MjI5NTIwNl5BMl5BanBnXkFtZTYwMTM1Njg2._V1_SX300.jpg", Price = 1.1M,
                Language = "English",
                Director = "Kelly",
                Rating = "PG-15",
                Released = "16-Apr-2002",
                Runtime = "125 mins", Plot= "Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé, while Obi-Wan investigates an assassination attempt on the Senator and discovers a secret clone army crafted for the Jedi"
            });
            Add(new Movie { Title = "Revenge of the Sith", Year = "2005", Category = "Fiction", Poster = "http://ia.media-imdb.com/images/M/MV5BNTc4MTc3NTQ5OF5BMl5BanBnXkFtZTcwOTg0NjI4NA@@._V1_SX300.jpg", Price = 3.2M,
                Language = "French",
                Director = "Packer",
                Rating = "PG-15",
                Released = "19-Mar-2005",
                Runtime = "165 mins", Plot= "Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy"

            });
            


        }
        //Get all movies
        public IEnumerable<Movie> GetAll()
        {
            return lstMovies;
        }
        //Get movie by id
        public Movie Get(int id)
        {
            return lstMovies.Find(o => o.Id == id);
        }
        //Add movie item to movies list
        public Movie Add(Movie item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            lstMovies.Add(item);
            return item;

        }
    }
}