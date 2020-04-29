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
    [RoutePrefix("api/[controller]")]
    public class LikesController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post(LikeCreateModel like)
        {
            LikeService likeService = CreateLikeService();
            likeService.CreateLike(like);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetLike(int id)
        {
            LikeService likeService = CreateLikeService(); 
            likeService.GetAllLikesOfPost(id);
            return Ok();
        }

        [HttpDelete]
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
