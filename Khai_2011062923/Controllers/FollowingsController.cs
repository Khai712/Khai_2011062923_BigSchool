using Khai_2011062923.DTOs;
using Khai_2011062923.Models;

using Microsoft.AspNet.Identity;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Khai_2011062923.Controllers
{
    public class FollowingsController : ApiController
    {
   
            // GET: Followings
            private readonly ApplicationDbContext _dbContext;
            public FollowingsController()
            {
                _dbContext = new ApplicationDbContext();
            }
            [System.Web.Http.HttpPost]
            public IHttpActionResult Follow(FollowingDto followingDto)
            {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId
                    && f.FolloweeID == followingDto.FolloweeId))
                    return BadRequest("Following already exists!");

                var following = new Following
                {
                    FollowerId = userId,
                    FolloweeID = followingDto.FolloweeId
                };
                _dbContext.Followings.Add(following);
                _dbContext.SaveChanges();
                return Ok();
            }
        }
 }
