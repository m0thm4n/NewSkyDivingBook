using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Users;
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
    public class UsersController : ApiController
    {
        private IUserService _userService;

        [HttpPost]
        public IHttpActionResult CreatePost([FromBody] UserCreateModel postToCreate)
        {
            _userService = new UserService();
            _userService.CreateUser(postToCreate);

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult GetAllPosts()
        {
            _userService = new UserService();

            return Ok(_userService.GetUsers());
        }

        [HttpGet]
        [Route("{id}")]
        public User GetPost(int id)
        {
            _userService = new UserService();

            return _userService.GetUser(id);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult DeletePost(int id)
        {
            _userService = new UserService();

            _userService.DeleteUser(id);

            return Ok();
        }
    }
}
