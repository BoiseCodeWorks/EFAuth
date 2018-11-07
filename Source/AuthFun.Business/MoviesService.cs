using AuthFun.Data;
using AuthFun.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthFun.Business
{
    public class MoviesService
    {
        private readonly DataContext _ctx;

        public MoviesService(DataContext ctx)
        {
            _ctx = ctx;
        }

        public Movie CreateMovie(Movie m)
        {
            _ctx.Movies.Add(m);
            _ctx.SaveChanges();
            return m;
            
        }


        public IList<Movie> GetMoviesByGenre(int id)
        {
            return _ctx.MovieGenres
                .Where(g => g.GenreId == id)
                .Select(m => m.Movie)
                .ToList();
        }




    }
}
