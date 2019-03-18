using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using LambdaForum.Common.DTO;

namespace LambdaForum.Web.Models.Forum
{
    public class ForumListingModel
    {
        public List<ForumListDto> s { get; }

       public IReadOnlyList<ForumListDto> forums { get; }

      public ForumListingModel(IReadOnlyList<ForumListDto> forums)
        {
            this.forums = forums;
        }

      
    }
}
