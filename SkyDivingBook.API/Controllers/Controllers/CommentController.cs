using SkyDivingBook.Contracts;
using SkyDivingBook.Models.Comment;
using SkyDivingBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkyDivingBook.API.Controllers
{
    [Route("api/comments")]
    public class CommentController : ApiController
    {
        private ICommentService _commentService;

        [HttpPost]
        public IHttpActionResult Create([FromBody] CommentCreateModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _commentService = new CommentService();

            _commentService.CreateComment(model);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult List()
        {
            _commentService = new CommentService();
            return Ok(_commentService.GetAllComments());
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            _commentService = new CommentService();
            _commentService.GetCommentById(id);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] CommentEditModel comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _commentService = new CommentService();

            _commentService.UpdateComment(comment);

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _commentService = new CommentService();
            _commentService.DeleteComment(id);
            return Ok();
        }
    }
}
