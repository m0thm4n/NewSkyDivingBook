using SkyDivingBook.API.Models;
using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
using SkyDivingBook.Models.Likes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDivingBook.Services
{
    public class LikeService : ILikeService
    {
		private readonly Guid _userId;
		public LikeService(Guid userId)
		{
			_userId = userId;
		}

		public void CreateLike(LikeCreateModel likeToCreate)
		{
			var entity = new Like()
			{
				UserId = _userId,
				PostId = likeToCreate.PostId
			};

			using (var ctx = new ApplicationDbContext())
			{
				ctx.Likes.Add(entity);
				ctx.SaveChanges();
			}
		}

		public IEnumerable<LikeListItem> GetAllLikesOfPost(int postId)
		{
			using (var ctx = new ApplicationDbContext())
			{
				var request = ctx.Likes.Where(e => e.PostId == postId).Select(e => new LikeListItem
				{
					Name = ctx.Posts.FirstOrDefault(x => x.PostId == postId).User.Name
				});

				return request.ToArray();
			}
		}

		public void DeleteLike(int likeId)
		{
			using (var ctx = new ApplicationDbContext())
			{
				var entity = ctx.Likes.Single(e => e.LikeId == likeId && e.UserId == _userId);
				ctx.Likes.Remove(entity);
				ctx.SaveChanges();
			}
		}
	}
}
