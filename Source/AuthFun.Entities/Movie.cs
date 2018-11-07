using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace AuthFun.Entities
{

    public enum Ratings
    {
        G = 1,
        PG = 8,
        PG13 = 13,
        R = 17,
        NC17 = 18
    }

    public class MovieGenres
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        [IgnoreDataMember]
        public Movie Movie { get; set; }
        [IgnoreDataMember]
        public Genre Genre { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Ratings Rating { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<MovieGenres> MovieGenres { get; set; }
    }
}
