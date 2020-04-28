﻿using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Post;
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
        IEnumerable<Post> GetPosts();
        void DeletePost(int id);
        Post GetPost(int id);
    }
}
