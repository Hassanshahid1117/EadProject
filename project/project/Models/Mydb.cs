

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace project.Models
{
    public class Mydb : DbContext
    {
        public Mydb() : base("mycon")
        { }
        public DbSet<customer> customer { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<cart> cart { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Admin> Admin { get; set; }

    }
}