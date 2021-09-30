using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using entity;

namespace data.Concrete
{
    public class MusicRepo : IMusicRepo
    {
        private readonly BlogContext _context;
        public MusicRepo(BlogContext context)
        {
            _context = context;
        }
        public void Delete(Music entity)
        {
            _context.Music.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Music> GetAll()
        {
           return _context.Music.ToList();
        }

        public Music GetById(int id)
        {
            return _context.Music.Find(id);
        }

        public void Insert(Music entity)
        {
            _context.Music.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Music entity)
        {
           _context.Music.Update(entity);
           _context.SaveChanges();
        }
    }
}