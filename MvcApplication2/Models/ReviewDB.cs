using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class ReviewDB: DbContext
    {
        public ReviewDB()
            : base("ReviewDB")
        {

        }
        public DbSet<Review> reviews { get; set; }

    }
}