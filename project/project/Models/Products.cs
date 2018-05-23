
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace project.Models
{
    public class Products
    {
        public int id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Discription { get; set; }

        public cart cart { get; set; }


    }
}