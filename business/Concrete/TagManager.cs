using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class TagManager : ITagService
    {
        private readonly ITagRepo _repo;
        public TagManager(ITagRepo repo)
        {
            _repo = repo;
        }

        public void Delete(Tag entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<Tag> GetAll()
        {
           return _repo.GetAll();
        }

        public Tag GetById(int id)
        {
           return _repo.GetById(id);
        }

        public void Insert(Tag entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Tag entity)
        {
            _repo.Update(entity);
        }
    }
}