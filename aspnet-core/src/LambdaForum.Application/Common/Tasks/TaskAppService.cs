using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using LambdaForum.Common.Tasks.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = LambdaForum.Common.Models.Task;

namespace LambdaForum.Common.Tasks
{
    class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepo;

        public TaskAppService(IRepository<Task> taskRepo)
        {
            _taskRepo = taskRepo;
        }
        public async Task<List<TaskListDto>> GetAll(GetAllTasksInput input)
        {
            var tasks = await _taskRepo.GetAll().ToListAsync();
            var c = tasks.WhereIf(input.State.HasValue, t => t.State == input.State.Value)
              .OrderByDescending(t => t.CreationTime);

            return new List<TaskListDto>(ObjectMapper.Map<List<TaskListDto>>(c));

        }
    }
    
}
