using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class SocialManager : ISocialService
    {
        private readonly ISocialRepo _repo;
        public SocialManager(ISocialRepo repo)
        {
            _repo = repo;
        }

        public void Delete(Social entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<Social> GetAll()
        {
           return _repo.GetAll();
        }

        public Social GetById(int id)
        {
           return _repo.GetById(id);
        }

        public void Insert(Social entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Social entity)
        {
            _repo.Update(entity);
        }
    }
}