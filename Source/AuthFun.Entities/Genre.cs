using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AuthFun.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<MovieGenres> Movies { get; set; }
    }
}
