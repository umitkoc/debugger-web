using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class AuthorRepo : IAuthorRepo
    {




       private readonly BlogContext _context;
        public AuthorRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(Author entity)
        {
            _context.Author.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Author> GetAll()
        {
           return _context.Author.ToList();
        }

        public Author GetById(int id)
        {
            return _context.Author.Find(id);
        }

        public void Insert(Author entity)
        {
            _context.Author.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Author entity)
        {
           _context.Author.Update(entity);
           _context.SaveChanges();
        }
    }
}