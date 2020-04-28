using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Replies;
using SkyDivingBook.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkyDivingBook.API.Controllers
{
    public class RepliesController : ApiController
    {
        private IReplyService _replyService;

        [HttpPost]
        [Route("create")]
        public IHttpActionResult CreateReply([FromBody] ReplyCreateModel replyToCreate)
        {
            _replyService = new ReplyService();
            _replyService.CreateReply(replyToCreate);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAllPosts()
        {
            _replyService = new ReplyService();

            return Ok(_replyService.GetReplies());
        }

        [HttpGet]
        [Route("{id}")]
        public Reply GetPost(int id)
        {
            _replyService = new ReplyService();

            return _replyService.GetReply(id);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult DeletePost(int id)
        {
            _replyService = new ReplyService();

            _replyService.DeleteReply(id);

            return Ok();
        }
    }
}
