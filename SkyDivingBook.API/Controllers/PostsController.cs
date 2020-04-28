using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Posts;
using SkyDivingBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SkyDivingBook.API.Controllers
{
    public class PostsController : ApiController
    {
        private IPostService _postService;

        [HttpPost]
        [Route("create")]
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

        [HttpGet]
        [Route("{id}")]
        public Post GetPost(int id)
        {
            _postService = new PostService();

            return _postService.GetPost(id);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult DeletePost(int id)
        {
            _postService = new PostService();

            _postService.DeletePost(id);

            return Ok();
        }
    }
}
