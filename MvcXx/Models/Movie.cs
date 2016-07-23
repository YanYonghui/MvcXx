using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcXx.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "上映日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
    public class TestDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }


}