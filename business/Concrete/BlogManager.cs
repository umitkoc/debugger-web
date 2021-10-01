using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class BlogManager : IBlogService
    {
       private readonly IBlogRepo _repo;
        public BlogManager(IBlogRepo repo)
        {
            _repo = repo;
        }

        public void Delete(Blog entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<Blog> GetAll()
        {
           return _repo.GetAll();
        }

        public ICollection<Blog> GetBlogs()
        {
              return _repo.GetBlogs();
        }

        public Blog GetById(int id)
        {
           return _repo.GetById(id);
        }

        public ICollection<Blog> GetSearch(string q)
        {
            return _repo.GetSearch(q);
        }

        public ICollection<Blog> GetTagBlog(int id)
        {
            return _repo.GetTagBlog(id);
        }

        public void Insert(Blog entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Blog entity)
        {
            _repo.Update(entity);
        }
    }
}