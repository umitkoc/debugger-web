using System.Collections.Generic;
using business.Abstract;
using data.Abstract;
using entity;

namespace business.Concrete
{
    public class CommentManager : ICommentService
    {
      private readonly ICommentRepo _repo;
        public CommentManager(ICommentRepo repo)
        {
            _repo = repo;
        }

        public void Delete(Comment entity)
        {
           _repo.Delete(entity);
        }

        public ICollection<Comment> GetAll()
        {
           return _repo.GetAll();
        }

        public Comment GetById(int id)
        {
           return _repo.GetById(id);
        }

        public void Insert(Comment entity)
        {
            _repo.Insert(entity);
        }

        public void Update(Comment entity)
        {
            _repo.Update(entity);
        }
    }
}