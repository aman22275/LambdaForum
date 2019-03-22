using Abp.Application.Services;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using LambdaForum.Common.Models;
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
   public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepo;

        public TaskAppService(IRepository<Task> taskRepo)
        {
            _taskRepo = taskRepo;
        }

        public async System.Threading.Tasks.Task Create(CreateTaskDto input)
        {
            var task = ObjectMapper.Map<Task>(input);
            await _taskRepo.InsertAsync(task);
        }

        public async Task<List<TaskListDto>> GetAll(GetAllTasksInput input)
        {
            var tasks = await _taskRepo.GetAll()
                          .Include(t => t.AssignedPerson)
                .ToListAsync();

            return new List<TaskListDto>(ObjectMapper.Map<List<TaskListDto>>(tasks));

        }

        public Task GetTaskById(int id)
        {
            return _taskRepo.FirstOrDefault(i => i.Id == id);
        }
    }
    
}
