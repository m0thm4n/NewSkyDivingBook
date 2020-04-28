using SkyDivingBook.Contracts;
using SkyDivingBook.Data.Entities;
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
			
		}

		public IEnumerable<Like> GetAllLikesOfPost(int postId)
		{
			throw new NotImplementedException();
		}

		public void DeleteLike()
		{
			throw new NotImplementedException();
		}
	}
}
