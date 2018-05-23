using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace project.Models
{
    public class cart
    {

        public int id { get; set; }
        public int cid { get; set; }
        public int pid { get; set; }
        public List<Products> products { get; set; }
    }
}