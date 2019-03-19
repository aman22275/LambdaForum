using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using LambdaForum.Common.DTO;
using LambdaForum.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaForum.Common
{
    public class ForumService : ApplicationService, IForumService
    {
        private readonly IRepository<Forum> _forumRepo;
        private readonly IObjectMapper _objectMapper;
        public ForumService(IRepository<Forum> forumRepo)
        {
            _forumRepo = forumRepo;
       

        }

        public System.Threading.Tasks.Task Create(ForumCreateDto input)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            return _forumRepo.FirstOrDefault(f => f.Id == id);
        }

        public System.Threading.Tasks.Task UpdateForumDescription(int id, string newDescription)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task UpdateForumTitle(int id, string newTitle)
        {
            throw new NotImplementedException();
        }


       public async Task<List<ForumListDto>> GetAll()
        {
            var t = await _forumRepo.GetAll().ToListAsync();
            //IEnumerable<Forum>  d = t.Where(c => c.Title == "aman").ToList<>
                   

            return new List<ForumListDto>(ObjectMapper.Map<List<ForumListDto>>(t));
        }
    }
}
