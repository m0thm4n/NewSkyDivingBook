using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Post;
using SkyDivingBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkyDivingBook.API.Controllers
{
    public class PostsController : ApiController
    {
        private IPostService _postService;

        [HttpPost]
        public IHttpActionResult CreatePost([FromBody] PostCreateModel postToCreate)
        {
            _postService = new PostService();
            _postService.CreatePost(postToCreate);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAllPosts()
        {
            _postService = new PostService();

            return Ok(_postService.GetPosts());
        }
    }
}
