using System.Collections.Generic;
using entity;

namespace business.Abstract
{
    public interface IBlogService : IService<Blog>
    {
        ICollection<Blog> GetTagBlog(int id);
        ICollection<Blog> GetSearch(string q);
    }
}