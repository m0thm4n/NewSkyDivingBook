using Microsoft.AspNet.Identity;
using SkyDivingBook.Models.Likes;
using SkyDivingBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkyDivingBook.API.Controllers
{
    public class LikeController : ApiController
    {
        public IHttpActionResult Post(LikeCreateModel like)
        {
            LikeService likeService = CreateLikeService();
            likeService.CreateLike(like);
            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            LikeService likeService = CreateLikeService();
            return Ok(likeService.GetAllLikesOfPost(id));
        }

        public IHttpActionResult Delete(int id)
        {
            LikeService likeService = CreateLikeService();
            likeService.DeleteLike(id);
            return Ok();
        }

        private LikeService CreateLikeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var likeService = new LikeService(userId);
            return likeService;
        }
    }
}
