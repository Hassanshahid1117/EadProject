using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Models
{
    public class Mydb : DbContext
    {
        public Mydb() : base("mycon")
        { }
        public DbSet<customer> customer { get; set; }
       
    }
}