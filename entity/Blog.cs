

using System;
using System.Collections.Generic;

namespace entity
{
    public class Blog
    {
        public int id { get; set; }
        public string title { get; set; }
        public string  image { get; set; }
        public bool hidden { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public string description { get; set; }
        public int Tagid { get; set; }
        public ICollection<Tag> Tags { get; set; }
        
        
       
    }
}