using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectFinal.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int NumberOfStars { get; set; }
        public string Message { get; set; }

    }

    public class MainDBContext : DbContext
    {
        public DbSet <ReviewModel> Reviews { get; set; }
    }

}