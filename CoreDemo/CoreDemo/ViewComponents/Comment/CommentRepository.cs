using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentRepository : ICommentDal
    {
        public void Delete(EntityLayer.Concrete.Comment t)
        {
            throw new NotImplementedException();
        }

        public EntityLayer.Concrete.Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.Comment> GetListAll(Expression<Func<EntityLayer.Concrete.Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<EntityLayer.Concrete.Comment> GetListWithBlog()
        {
            throw new NotImplementedException();
        }

        public void Insert(EntityLayer.Concrete.Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityLayer.Concrete.Comment t)
        {
            throw new NotImplementedException();
        }
    }
}