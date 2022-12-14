using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentDal = commentdal;
        }
        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetCommentWithBlog()
        {
             return _commentDal.GetListWithBlog();
        }

        public List<Comment> Getlist(int id)
        {
           return _commentDal.GetListAll(x => x.BlogId == id);
        }
    }
}
