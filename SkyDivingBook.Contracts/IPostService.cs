using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Contracts
{
    public interface IPostService
    {
        void CreatePost(PostCreateModel postToCreate);
        IEnumerable<PostGetAllModel> GetPosts();
        void DeletePost(int id);
        PostGetModel GetPost(int id);
    }
}
