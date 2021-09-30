using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class MusicManager : IMusicService
    {
       private readonly IMusicRepo _repo;
        public MusicManager(IMusicRepo repo)
        {
            _repo = repo;
        }

        public void Delete(Music entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<Music> GetAll()
        {
           return _repo.GetAll();
        }

        public Music GetById(int id)
        {
           return _repo.GetById(id);
        }

        public void Insert(Music entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Music entity)
        {
            _repo.Update(entity);
        }
    }
}