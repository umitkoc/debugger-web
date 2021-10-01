


using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity
{
    public class Comment
    {
        public int id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
        public bool hidden { get; set; }
        public DateTime date { get; set; }
        public string message { get; set; }
        public int Blogid { get; set; }
        
        
    }
}