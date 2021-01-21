using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationMysql.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public float Price { get; set; }
    }
}