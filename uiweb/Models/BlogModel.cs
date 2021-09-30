using System;
using System.Collections.Generic;
using entity;

namespace uiweb.Models
{
    public class BlogModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string  image { get; set; }
        public bool hidden { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
        

    }
}