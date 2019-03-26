using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.UI;
using AutoMapper;
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


        //Assign Task , with dropdown
        public async System.Threading.Tasks.Task Create(CreateTaskDto input)
        {
            var task = ObjectMapper.Map<Task>(input);
            await _taskRepo.InsertAsync(task);
        }

        //Delete Tasks , call from javscript no controller used.
        public async System.Threading.Tasks.Task Delete(DeleteTaskDto input)
        {
            await _taskRepo.DeleteAsync(input.Id);
        }

        //Get All Tasks.
        public async Task<List<TaskListDto>> GetAll(GetAllTasksInput input)
        {
            var tasks = await _taskRepo.GetAll()
                          .Include(t => t.AssignedPerson)
                .ToListAsync();

            return new List<TaskListDto>(ObjectMapper.Map<List<TaskListDto>>(tasks));

        }

        //Get Task By id.
        public Task GetTaskById(int id)
        {
            return _taskRepo.FirstOrDefault(i => i.Id == id);
        }

  

        public void Update(UpdateTaskDto input)
        {
            Task update = _taskRepo.FirstOrDefault(i => i.Id == input.Id);
            update.Name = input.Name;
            update.Description = input.Description;        

             _taskRepo.UpdateAsync(update);
        //ObjectMapper.Map<UpdateTaskDto>(update);
        }
    }
    
}
