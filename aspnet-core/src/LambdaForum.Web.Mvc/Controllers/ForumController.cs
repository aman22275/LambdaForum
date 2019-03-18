using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using LambdaForum.Common;
using LambdaForum.Common.DTO;
using LambdaForum.Common.Models;
using LambdaForum.Controllers;
using LambdaForum.Web.Models.Forum;
using Microsoft.AspNetCore.Mvc;

namespace LambdaForum.Web.Mvc.Controllers
{
    public class ForumController : AbpController
    {
        private readonly IForumService _forum;
        public ForumController(IForumService forum)
        {
            _forum = forum;
        }

        public async Task<ActionResult> Index()
        {
            /*IEnumerable<ForumListingModel> forums = _forum.GetAll()
                .Select(forum => new ForumListingModel {
                Id = forum.Id,
                Title = forum.Title,
                Description = forum.Description
            });*/
         var s = await _forum.GetAll();

            //var model = new ForumListingModel();
            var model = new ForumListingModel(s);
           
            return View(model);
        }
    }
}