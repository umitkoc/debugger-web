using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class TagRepo : ITagRepo
    {
        private readonly BlogContext _context;
        public TagRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(Tag entity)
        {
            _context.Set<Tag>().Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Tag> GetAll()
        {
           return _context.Set<Tag>().ToList();
        }

        public Tag GetById(int id)
        {
            return _context.Set<Tag>().Find(id);
        }

        public void Insert(Tag entity)
        {
            _context.Set<Tag>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(Tag entity)
        {
           _context.Set<Tag>().Update(entity);
           _context.SaveChanges();
        }
    }
}