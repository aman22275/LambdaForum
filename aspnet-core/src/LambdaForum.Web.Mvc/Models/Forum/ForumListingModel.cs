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
       

       public IReadOnlyList<ForumListDto> Forums { get; }

      public ForumListingModel(IReadOnlyList<ForumListDto> forums)
        {
            Forums = forums;
        }

      
    }
}
