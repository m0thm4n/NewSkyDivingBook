using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Likes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Contracts
{
    public interface ILikeService
    {
        void CreateLike(LikeCreateModel likeToCreate);
        IEnumerable<LikeListItem> GetAllLikesOfPost(int postId);
        void DeleteLike(int likeId);
    }
}
