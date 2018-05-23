using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class Orders
    {
        public int id { get; set; }
        public int uis { get; set; }
        public int cartid { get; set; }
        public int pid { get; set; }
        public string status { get; set; }

    }
}