using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class AboutRepo : IAboutRepo
    {
        private readonly BlogContext _context;
        public AboutRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(About entity)
        {
            _context.Set<About>().Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<About> GetAll()
        {
           return _context.About
           .Where(i=>i.hidden)
           .ToList();
        }

        public About GetById(int id)
        {
            return _context.Set<About>().Find(id);
        }

        public void Insert(About entity)
        {
            _context.Set<About>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(About entity)
        {
           _context.Set<About>().Update(entity);
           _context.SaveChanges();
        }
    }
}