using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class BlogRepo : IBlogRepo
    {
        private readonly BlogContext _context;
        public BlogRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(Blog entity)
        {
            _context.Blog.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Blog> GetAll()
        {
           return _context.Blog.Where(i=>i.hidden).Include(i=>i.Comments).ToList();
        }

        public ICollection<Blog> GetBlogs()
        {
             return _context.Blog.Include(i=>i.Comments).ToList();
        }

        public Blog GetById(int id)
        {
            return _context.Blog
            .Where(i=>i.id==id).Include(i=>i.Comments)
            .FirstOrDefault();
        }

        public ICollection<Blog> GetSearch(string q)
        {
            return _context.Blog.Where(i=>i.description.ToLower().Contains(q)).Include(i=>i.Comments).ToList();
        }

        public ICollection<Blog> GetTagBlog(int id)
        {
            return _context.Blog.Where(i=>i.Tagid==id).Include(i=>i.Comments).ToList();
        }

        public void Insert(Blog entity)
        {
            _context.Blog.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Blog entity)
        {
           _context.Blog.Update(entity);
           _context.SaveChanges();
        }
    }
}