using System;
using System.ComponentModel.DataAnnotations;

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

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Ratings Rating { get; set; }
        public string UserId { get; set; }
    }
}
