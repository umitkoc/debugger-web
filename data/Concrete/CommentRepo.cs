using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class CommentRepo : ICommentRepo
    {
        private readonly BlogContext _context;
        public CommentRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(Comment entity)
        {
            _context.Comment.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Comment> GetAll()
        {
           return _context.Comment.ToList();
        }

        public Comment GetById(int id)
        {
            return _context.Comment.Find(id);
        }

      

        public void Insert(Comment entity)
        {
            _context.Comment.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
           _context.Comment.Update(entity);
           _context.SaveChanges();
        }
    }
}