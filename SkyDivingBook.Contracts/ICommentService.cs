using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Comment;
using SkyDivingBook.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Contracts
{
    public interface ICommentService
    {
        void CreateComment(CommentCreateModel commentToCreate);
        IEnumerable<CommentListModel> GetAllComments();
        CommentDetail GetCommentById(int commentId);
        void UpdateComment(CommentEditModel model);
        void DeleteComment(int commentId);
    }
}
