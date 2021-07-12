using _1911060148_NGUYENTRUNGKIEN_BigSchool1.DTOs;
using _1911060148_NGUYENTRUNGKIEN_BigSchool1.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911060148_NGUYENTRUNGKIEN_BigSchool1.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly  ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exists!");
            var following = new Following
            {
                FolloweeId = followingDto.FolloweeId,
                FollowerId = userId
            };
            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteFollowing(string id)
        {
            var userId = User.Identity.GetUserId();
            var following = _dbContext.Followings.SingleOrDefault(a => a.FollowerId == userId && a.FolloweeId == id);
            if (following == null)
                return NotFound();
            _dbContext.Followings.Remove(following);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
