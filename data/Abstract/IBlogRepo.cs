using System.Collections.Generic;
using entity;

namespace data.Abstract
{
    public interface IBlogRepo:IRepo<Blog>
    {
         ICollection<Blog> GetTagBlog(int id);
         ICollection<Blog> GetSearch(string q);

         ICollection<Blog> GetBlogs();
    }
}