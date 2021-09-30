using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorRepo _repo;
        public AuthorManager(IAuthorRepo repo)
        {
            _repo = repo;
        }

        public void Delete(Author entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<Author> GetAll()
        {
           return _repo.GetAll();
        }

        public Author GetById(int id)
        {
           return _repo.GetById(id);
        }

        public void Insert(Author entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Author entity)
        {
            _repo.Update(entity);
        }
    }
}