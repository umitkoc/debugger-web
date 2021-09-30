using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class AboutManager : IAboutService
    {

        private readonly IAboutRepo _repo;
        public AboutManager(IAboutRepo repo)
        {
            _repo = repo;
        }

        public void Delete(About entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<About> GetAll()
        {
           return _repo.GetAll();
        }

        public About GetById(int id)
        {
           return _repo.GetById(id);
        }

        public void Insert(About entity)
        {
            _repo.Insert(entity);
        }

        public void Update(About entity)
        {
            _repo.Update(entity);
        }
    }
}