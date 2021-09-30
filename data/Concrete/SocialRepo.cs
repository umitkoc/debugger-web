using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class SocialRepo : ISocialRepo
    {
        private readonly BlogContext _context;
        public SocialRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(Social entity)
        {
            _context.Set<Social>().Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Social> GetAll()
        {
           return _context.Set<Social>().ToList();
        }

        public Social GetById(int id)
        {
            return _context.Set<Social>().Find(id);
        }

        public void Insert(Social entity)
        {
            _context.Set<Social>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Social entity)
        {
           _context.Set<Social>().Update(entity);
           _context.SaveChanges();
        }
    }
}