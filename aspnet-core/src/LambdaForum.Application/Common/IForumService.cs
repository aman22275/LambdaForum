using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using LambdaForum.Common.Models;
using LambdaForum.Common.DTO;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;

namespace LambdaForum.Common
{
    public interface IForumService : IApplicationService
    {
       Forum GetById(int id);
        Task<List<ForumListDto>> GetAll();
       //IEnumerable<Forum> GetAll();
       IEnumerable<ApplicationUser> GetAllActiveUsers();
       Task Create(ForumCreateDto input);
       Task Delete(int id);
       Task UpdateForumTitle(int id, string newTitle);
       Task UpdateForumDescription(int id, string newDescription);

    }
}
