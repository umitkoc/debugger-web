using System.Collections.Generic;
using entity;

namespace uiweb.Models
{
    public class BlogListModel
    {
        public ICollection<BlogModel> BlogList { get; set; }
        public int Comments { get; set; }
    }
}